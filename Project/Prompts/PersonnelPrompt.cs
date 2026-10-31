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
public partial class PersonnelPrompt : BasePrompt {
	public static DialogResult ShowPrompt(Personnel data) {
		using var prompt = new PersonnelPrompt();
		prompt.NameBox.Text = data.Name;
		prompt.TelephoneNumberBox.Text = data.Telephone.FullNumber;
		prompt.WageUpDown.Value = data.Wage;
		prompt.PositionBox.Text = data.Position;

		var result = prompt.ShowDialog();
		if (result == DialogResult.OK) {
			data.Name = prompt.NameBox.Text;
			data.Telephone = new(prompt.TelephoneNumberBox.Text);
			data.Wage = prompt.WageUpDown.Value;
			data.Position = prompt.PositionBox.Text;
		}

		return result;
	}

	public PersonnelPrompt() {
		InitializeComponent();
	}

	private void TelephoneNumberBox_TextChanged(object sender, EventArgs e) {
		if (TelephoneNumber.TryValidate(this.TelephoneNumberBox.Text))
			this.AcceptationButton.Enabled = true;
		else
			this.AcceptationButton.Enabled = false;
	}
}
