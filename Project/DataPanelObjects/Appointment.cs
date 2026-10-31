/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2023-2024 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: Proje 1
**				ÖĞRENCİ ADI............: Ayhan Dalkıran
**				ÖĞRENCİ NUMARASI.......: G221210020
**				DERSİN ALINDIĞI GRUP...: 2. Öğretim C
****************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Project;
public class Appointment : DataPanelObject {
	public DateTime Date { get => this._Date; set => SetField(ref _Date, value); }
	//JsonIgnore attribute is required to stop this property from serializing.
	[JsonIgnore] public Person Customer {
		get => this._Customer;
		set {
			this.Customer.PropertyChanged -= OnCustomerPropertyChanged;
			SetField(ref _Customer, value);
			value.PropertyChanged += OnCustomerPropertyChanged;
		}
	}
	public string Description { get => this._Description; set => SetField(ref _Description, value); }

	//Properties used for serializing customer info.
	//JsonInclude attributes are required due to protected setters invalidating the default getter/setter requirement.
	[JsonInclude] public string CustomerName { get => this.Customer.Name; protected set => this.Customer.Name = value; }
	[JsonInclude] public TelephoneNumber CustomerTelephone { get => this.Customer.Telephone; protected set => this.Customer.Telephone = value; }

	public Appointment() => this.Customer.PropertyChanged += OnCustomerPropertyChanged;

	protected DateTime _Date = DateTime.Now;
	protected Person _Customer = new();
	protected string _Description = string.Empty;

	//Have to add the prefix "Customer" at the beginning of the property name, otherwise data panel won't recognise it.
	//I kinda wish that I hadn't used a seperate object for customer info.
	private void OnCustomerPropertyChanged(object? sender, string propertyName) => InvokePropertyChanged(this, "Customer" + propertyName);
}
