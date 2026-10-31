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

partial class ServicePrompt {
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
		this.NameBox = new System.Windows.Forms.TextBox();
		this.label1 = new System.Windows.Forms.Label();
		this.label2 = new System.Windows.Forms.Label();
		this.PriceUpDown = new System.Windows.Forms.NumericUpDown();
		this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
		((System.ComponentModel.ISupportInitialize)this.PriceUpDown).BeginInit();
		this.tableLayoutPanel1.SuspendLayout();
		this.SuspendLayout();
		// 
		// CancelationButton
		// 
		this.CancelationButton.Location = new System.Drawing.Point(51, 76);
		// 
		// AcceptationButton
		// 
		this.AcceptationButton.Location = new System.Drawing.Point(132, 76);
		// 
		// NameBox
		// 
		this.NameBox.Location = new System.Drawing.Point(82, 3);
		this.NameBox.MaxLength = 100;
		this.NameBox.Name = "NameBox";
		this.NameBox.Size = new System.Drawing.Size(110, 23);
		this.NameBox.TabIndex = 3;
		// 
		// label1
		// 
		this.label1.AutoSize = true;
		this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label1.Location = new System.Drawing.Point(3, 0);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(73, 29);
		this.label1.TabIndex = 2;
		this.label1.Text = "Hizmet ismi:";
		this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		// 
		// label2
		// 
		this.label2.AutoSize = true;
		this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label2.Location = new System.Drawing.Point(3, 29);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(73, 29);
		this.label2.TabIndex = 4;
		this.label2.Text = "Ücret:";
		this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		// 
		// PriceUpDown
		// 
		this.PriceUpDown.DecimalPlaces = 2;
		this.PriceUpDown.Location = new System.Drawing.Point(82, 32);
		this.PriceUpDown.Maximum = new decimal(new int[] { -1, -1, -1, 0 });
		this.PriceUpDown.Name = "PriceUpDown";
		this.PriceUpDown.Size = new System.Drawing.Size(110, 23);
		this.PriceUpDown.TabIndex = 5;
		// 
		// tableLayoutPanel1
		// 
		this.tableLayoutPanel1.AutoSize = true;
		this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.tableLayoutPanel1.ColumnCount = 2;
		this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
		this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
		this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
		this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
		this.tableLayoutPanel1.Controls.Add(this.NameBox, 1, 0);
		this.tableLayoutPanel1.Controls.Add(this.PriceUpDown, 1, 1);
		this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
		this.tableLayoutPanel1.Name = "tableLayoutPanel1";
		this.tableLayoutPanel1.RowCount = 2;
		this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
		this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
		this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
		this.tableLayoutPanel1.Size = new System.Drawing.Size(195, 58);
		this.tableLayoutPanel1.TabIndex = 6;
		// 
		// ServicePrompt
		// 
		this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.AutoSize = true;
		this.ClientSize = new System.Drawing.Size(210, 102);
		this.Controls.Add(this.tableLayoutPanel1);
		this.Name = "ServicePrompt";
		this.Text = "Hizmet Ayarları";
		this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
		this.Controls.SetChildIndex(this.CancelationButton, 0);
		this.Controls.SetChildIndex(this.AcceptationButton, 0);
		((System.ComponentModel.ISupportInitialize)this.PriceUpDown).EndInit();
		this.tableLayoutPanel1.ResumeLayout(false);
		this.tableLayoutPanel1.PerformLayout();
		this.ResumeLayout(false);
		this.PerformLayout();
	}

	#endregion

	private System.Windows.Forms.TextBox NameBox;
	private System.Windows.Forms.Label label1;
	private System.Windows.Forms.Label label2;
	private System.Windows.Forms.NumericUpDown PriceUpDown;
	private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
}