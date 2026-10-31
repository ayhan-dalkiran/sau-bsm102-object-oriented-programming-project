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
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Prompts;
public partial class TransactionPrompt : BasePrompt {
	public static DialogResult ShowPrompt(Transaction data) {
		using var prompt = new TransactionPrompt();
		prompt.DatePicker.Value = data.Date;
		prompt.TimePicker.Value = data.Date;
		prompt.AmountUpDown.Value = data.Amount;
		prompt.DescriptionBox.Text = data.Description;

		var result = prompt.ShowDialog();
		if (result == DialogResult.OK) {
			data.Date = new(DateOnly.FromDateTime(prompt.DatePicker.Value), TimeOnly.FromDateTime(prompt.TimePicker.Value));
			data.Amount = prompt.AmountUpDown.Value;
			data.Description = prompt.DescriptionBox.Text;
		}

		return result;
	}

	public TransactionPrompt() {
		InitializeComponent();
	}
}
