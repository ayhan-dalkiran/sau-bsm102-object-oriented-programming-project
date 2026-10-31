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
public partial class AppointmentPrompt : BasePrompt {
	public static DialogResult ShowPrompt(Appointment data) {
		using var prompt = new AppointmentPrompt();
		prompt.DatePicker.Value = data.Date;
		prompt.TimePicker.Value = data.Date;
		prompt.CustomerNameBox.Text = data.Customer.Name;
		prompt.CustomerTelephoneNumberBox.Text = data.Customer.Telephone.FullNumber;
		prompt.DescriptionBox.Text = data.Description;

		var result = prompt.ShowDialog();
		if (result == DialogResult.OK) {
			data.Date = new(DateOnly.FromDateTime(prompt.DatePicker.Value), TimeOnly.FromDateTime(prompt.TimePicker.Value));
			data.Customer.Name = prompt.CustomerNameBox.Text;
			data.Customer.Telephone = new(prompt.CustomerTelephoneNumberBox.Text);
			data.Description = prompt.DescriptionBox.Text;
		}

		return result;
	}

	public AppointmentPrompt() {
		InitializeComponent();
	}

	private void CustomerTelephoneNumberBox_TextChanged(object sender, EventArgs e) {
		if (TelephoneNumber.TryValidate(this.CustomerTelephoneNumberBox.Text))
			this.AcceptationButton.Enabled = true;
		else
			this.AcceptationButton.Enabled = false;
	}
}
