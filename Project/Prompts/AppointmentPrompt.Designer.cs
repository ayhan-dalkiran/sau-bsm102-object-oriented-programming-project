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
namespace Project.Prompts;

partial class AppointmentPrompt {
	/// <summary>
	/// Required designer variable.
	/// </summary>
	private System.ComponentModel.IContainer components = null;

	/// <summary>
	/// Clean up any resources being used.
	/// </summary>
	/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	protected override void Dispose(bool disposing) {
		if (disposing && (components != null)) {
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	#region Windows Form Designer generated code

	/// <summary>
	/// Required method for Designer support - do not modify
	/// the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent() {
		this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
		this.label1 = new System.Windows.Forms.Label();
		this.label2 = new System.Windows.Forms.Label();
		this.label3 = new System.Windows.Forms.Label();
		this.label4 = new System.Windows.Forms.Label();
		this.DatePicker = new System.Windows.Forms.DateTimePicker();
		this.TimePicker = new System.Windows.Forms.DateTimePicker();
		this.CustomerNameBox = new System.Windows.Forms.TextBox();
		this.CustomerTelephoneNumberBox = new System.Windows.Forms.MaskedTextBox();
		this.DescriptionBox = new System.Windows.Forms.TextBox();
		this.tableLayoutPanel1.SuspendLayout();
		this.SuspendLayout();
		// 
		// CancelationButton
		// 
		this.CancelationButton.Location = new System.Drawing.Point(239, 134);
		// 
		// AcceptationButton
		// 
		this.AcceptationButton.Location = new System.Drawing.Point(320, 134);
		// 
		// tableLayoutPanel1
		// 
		this.tableLayoutPanel1.AutoSize = true;
		this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.tableLayoutPanel1.ColumnCount = 3;
		this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
		this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
		this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
		this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
		this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
		this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
		this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
		this.tableLayoutPanel1.Controls.Add(this.DatePicker, 1, 0);
		this.tableLayoutPanel1.Controls.Add(this.TimePicker, 2, 0);
		this.tableLayoutPanel1.Controls.Add(this.CustomerNameBox, 1, 1);
		this.tableLayoutPanel1.Controls.Add(this.CustomerTelephoneNumberBox, 1, 2);
		this.tableLayoutPanel1.Controls.Add(this.DescriptionBox, 1, 3);
		this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
		this.tableLayoutPanel1.Name = "tableLayoutPanel1";
		this.tableLayoutPanel1.RowCount = 4;
		this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
		this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
		this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
		this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
		this.tableLayoutPanel1.Size = new System.Drawing.Size(383, 116);
		this.tableLayoutPanel1.TabIndex = 15;
		// 
		// label1
		// 
		this.label1.AutoSize = true;
		this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label1.Location = new System.Drawing.Point(3, 0);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(145, 29);
		this.label1.TabIndex = 2;
		this.label1.Text = "Randevu Tarihi:";
		this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		// 
		// label2
		// 
		this.label2.AutoSize = true;
		this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label2.Location = new System.Drawing.Point(3, 29);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(145, 29);
		this.label2.TabIndex = 4;
		this.label2.Text = "Müşteri Adı:";
		this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		// 
		// label3
		// 
		this.label3.AutoSize = true;
		this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label3.Location = new System.Drawing.Point(3, 58);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(145, 29);
		this.label3.TabIndex = 6;
		this.label3.Text = "Müşteri Telefon Numarası:";
		this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		// 
		// label4
		// 
		this.label4.AutoSize = true;
		this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label4.Location = new System.Drawing.Point(3, 87);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(145, 29);
		this.label4.TabIndex = 8;
		this.label4.Text = "Açıklama:";
		this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		// 
		// DatePicker
		// 
		this.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.DatePicker.Location = new System.Drawing.Point(154, 3);
		this.DatePicker.Name = "DatePicker";
		this.DatePicker.Size = new System.Drawing.Size(110, 23);
		this.DatePicker.TabIndex = 14;
		// 
		// TimePicker
		// 
		this.TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
		this.TimePicker.Location = new System.Drawing.Point(270, 3);
		this.TimePicker.Name = "TimePicker";
		this.TimePicker.ShowUpDown = true;
		this.TimePicker.Size = new System.Drawing.Size(110, 23);
		this.TimePicker.TabIndex = 15;
		// 
		// CustomerNameBox
		// 
		this.CustomerNameBox.Location = new System.Drawing.Point(154, 32);
		this.CustomerNameBox.Name = "CustomerNameBox";
		this.CustomerNameBox.Size = new System.Drawing.Size(110, 23);
		this.CustomerNameBox.TabIndex = 7;
		// 
		// CustomerTelephoneNumberBox
		// 
		this.CustomerTelephoneNumberBox.Location = new System.Drawing.Point(154, 61);
		this.CustomerTelephoneNumberBox.Mask = "+\\9\\0 (000) 000 0000";
		this.CustomerTelephoneNumberBox.Name = "CustomerTelephoneNumberBox";
		this.CustomerTelephoneNumberBox.Size = new System.Drawing.Size(110, 23);
		this.CustomerTelephoneNumberBox.TabIndex = 13;
		this.CustomerTelephoneNumberBox.TextChanged += this.CustomerTelephoneNumberBox_TextChanged;
		// 
		// DescriptionBox
		// 
		this.tableLayoutPanel1.SetColumnSpan(this.DescriptionBox, 2);
		this.DescriptionBox.Location = new System.Drawing.Point(154, 90);
		this.DescriptionBox.Name = "DescriptionBox";
		this.DescriptionBox.Size = new System.Drawing.Size(226, 23);
		this.DescriptionBox.TabIndex = 16;
		// 
		// AppointmentPrompt
		// 
		this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.ClientSize = new System.Drawing.Size(398, 160);
		this.Controls.Add(this.tableLayoutPanel1);
		this.Name = "AppointmentPrompt";
		this.Text = "Randevu Ayarları";
		this.Controls.SetChildIndex(this.CancelationButton, 0);
		this.Controls.SetChildIndex(this.AcceptationButton, 0);
		this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
		this.tableLayoutPanel1.ResumeLayout(false);
		this.tableLayoutPanel1.PerformLayout();
		this.ResumeLayout(false);
		this.PerformLayout();
	}

	#endregion

	private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
	private System.Windows.Forms.Label label1;
	private System.Windows.Forms.Label label2;
	private System.Windows.Forms.Label label3;
	private System.Windows.Forms.Label label4;
	private System.Windows.Forms.TextBox CustomerNameBox;
	private System.Windows.Forms.MaskedTextBox CustomerTelephoneNumberBox;
	private System.Windows.Forms.DateTimePicker DatePicker;
	private System.Windows.Forms.DateTimePicker TimePicker;
	private System.Windows.Forms.TextBox DescriptionBox;
}