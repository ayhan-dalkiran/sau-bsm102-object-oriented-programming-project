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
public class Transaction : DataPanelObject {
	public DateTime Date { get => this._Date; set => SetField(ref _Date, value); }
	public decimal Amount { get => this._Amount; set => SetField(ref _Amount, value); }
	public string Description { get => this._Description; set => SetField(ref _Description, value); }

	public Transaction() {}

	protected DateTime _Date = DateTime.Now;
	protected decimal _Amount = 0.00m;
	protected string _Description = string.Empty;
}
