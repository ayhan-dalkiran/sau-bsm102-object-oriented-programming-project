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

partial class TransactionPrompt {
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
		this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
		this.label5 = new System.Windows.Forms.Label();
		this.label7 = new System.Windows.Forms.Label();
		this.label8 = new System.Windows.Forms.Label();
		this.DatePicker = new System.Windows.Forms.DateTimePicker();
		this.TimePicker = new System.Windows.Forms.DateTimePicker();
		this.AmountUpDown = new System.Windows.Forms.NumericUpDown();
		this.DescriptionBox = new System.Windows.Forms.TextBox();
		this.tableLayoutPanel2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.AmountUpDown).BeginInit();
		this.SuspendLayout();
		// 
		// CancelationButton
		// 
		this.CancelationButton.Location = new System.Drawing.Point(163, 105);
		// 
		// AcceptationButton
		// 
		this.AcceptationButton.Location = new System.Drawing.Point(244, 105);
		// 
		// tableLayoutPanel2
		// 
		this.tableLayoutPanel2.AutoSize = true;
		this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.tableLayoutPanel2.ColumnCount = 3;
		this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
		this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
		this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
		this.tableLayoutPanel2.Controls.Add(this.label5, 0, 0);
		this.tableLayoutPanel2.Controls.Add(this.label7, 0, 1);
		this.tableLayoutPanel2.Controls.Add(this.label8, 0, 2);
		this.tableLayoutPanel2.Controls.Add(this.DatePicker, 1, 0);
		this.tableLayoutPanel2.Controls.Add(this.TimePicker, 2, 0);
		this.tableLayoutPanel2.Controls.Add(this.AmountUpDown, 1, 1);
		this.tableLayoutPanel2.Controls.Add(this.DescriptionBox, 1, 2);
		this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 12);
		this.tableLayoutPanel2.Name = "tableLayoutPanel2";
		this.tableLayoutPanel2.RowCount = 3;
		this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
		this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
		this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
		this.tableLayoutPanel2.Size = new System.Drawing.Size(307, 87);
		this.tableLayoutPanel2.TabIndex = 16;
		// 
		// label5
		// 
		this.label5.AutoSize = true;
		this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label5.Location = new System.Drawing.Point(3, 0);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(69, 29);
		this.label5.TabIndex = 2;
		this.label5.Text = "İşlem Tarihi:";
		this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		// 
		// label7
		// 
		this.label7.AutoSize = true;
		this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label7.Location = new System.Drawing.Point(3, 29);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(69, 29);
		this.label7.TabIndex = 6;
		this.label7.Text = "Miktar:";
		this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		// 
		// label8
		// 
		this.label8.AutoSize = true;
		this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label8.Location = new System.Drawing.Point(3, 58);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(69, 29);
		this.label8.TabIndex = 8;
		this.label8.Text = "Açıklama:";
		this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		// 
		// DatePicker
		// 
		this.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.DatePicker.Location = new System.Drawing.Point(78, 3);
		this.DatePicker.Name = "DatePicker";
		this.DatePicker.Size = new System.Drawing.Size(110, 23);
		this.DatePicker.TabIndex = 14;
		// 
		// TimePicker
		// 
		this.TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
		this.TimePicker.Location = new System.Drawing.Point(194, 3);
		this.TimePicker.Name = "TimePicker";
		this.TimePicker.ShowUpDown = true;
		this.TimePicker.Size = new System.Drawing.Size(110, 23);
		this.TimePicker.TabIndex = 15;
		// 
		// AmountUpDown
		// 
		this.AmountUpDown.DecimalPlaces = 2;
		this.AmountUpDown.Location = new System.Drawing.Point(78, 32);
		this.AmountUpDown.Maximum = new decimal(new int[] { -1, -1, -1, 0 });
		this.AmountUpDown.Name = "AmountUpDown";
		this.AmountUpDown.Size = new System.Drawing.Size(110, 23);
		this.AmountUpDown.TabIndex = 16;
		// 
		// DescriptionBox
		// 
		this.tableLayoutPanel2.SetColumnSpan(this.DescriptionBox, 2);
		this.DescriptionBox.Location = new System.Drawing.Point(78, 61);
		this.DescriptionBox.Name = "DescriptionBox";
		this.DescriptionBox.Size = new System.Drawing.Size(226, 23);
		this.DescriptionBox.TabIndex = 17;
		// 
		// TransactionPrompt
		// 
		this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.ClientSize = new System.Drawing.Size(322, 131);
		this.Controls.Add(this.tableLayoutPanel2);
		this.Name = "TransactionPrompt";
		this.Text = "İşlem Ayarları";
		this.Controls.SetChildIndex(this.CancelationButton, 0);
		this.Controls.SetChildIndex(this.AcceptationButton, 0);
		this.Controls.SetChildIndex(this.tableLayoutPanel2, 0);
		this.tableLayoutPanel2.ResumeLayout(false);
		this.tableLayoutPanel2.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.AmountUpDown).EndInit();
		this.ResumeLayout(false);
		this.PerformLayout();
	}

	#endregion
	private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
	private System.Windows.Forms.Label label5;
	private System.Windows.Forms.Label label7;
	private System.Windows.Forms.Label label8;
	private System.Windows.Forms.DateTimePicker DatePicker;
	private System.Windows.Forms.DateTimePicker TimePicker;
	private System.Windows.Forms.NumericUpDown AmountUpDown;
	private System.Windows.Forms.TextBox DescriptionBox;
}