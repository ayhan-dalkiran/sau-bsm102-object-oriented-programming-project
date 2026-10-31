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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project;
public class Person : DataPanelObject {
	public string Name { get => this._Name; set => SetField(ref _Name, value); }
	public TelephoneNumber Telephone { get => this._Telephone; set => SetField(ref _Telephone, value); }

	public Person() {}

	protected string _Name = string.Empty;
	protected TelephoneNumber _Telephone = new();
}
