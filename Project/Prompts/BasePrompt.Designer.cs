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

partial class BasePrompt {
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
		this.CancelationButton = new System.Windows.Forms.Button();
		this.AcceptationButton = new System.Windows.Forms.Button();
		this.SuspendLayout();
		// 
		// CancelationButton
		// 
		this.CancelationButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
		this.CancelationButton.Location = new System.Drawing.Point(14, 14);
		this.CancelationButton.Name = "CancelationButton";
		this.CancelationButton.Size = new System.Drawing.Size(75, 23);
		this.CancelationButton.TabIndex = 0;
		this.CancelationButton.Text = "İptal";
		this.CancelationButton.UseVisualStyleBackColor = true;
		// 
		// AcceptationButton
		// 
		this.AcceptationButton.DialogResult = System.Windows.Forms.DialogResult.OK;
		this.AcceptationButton.Location = new System.Drawing.Point(95, 14);
		this.AcceptationButton.Name = "AcceptationButton";
		this.AcceptationButton.Size = new System.Drawing.Size(75, 23);
		this.AcceptationButton.TabIndex = 1;
		this.AcceptationButton.Text = "Kaydet";
		this.AcceptationButton.UseVisualStyleBackColor = true;
		// 
		// BasePrompt
		// 
		this.AcceptButton = this.AcceptationButton;
		this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.AutoSize = true;
		this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.CancelButton = this.CancelationButton;
		this.ClientSize = new System.Drawing.Size(188, 52);
		this.Controls.Add(this.AcceptationButton);
		this.Controls.Add(this.CancelationButton);
		this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		this.MaximizeBox = false;
		this.MinimizeBox = false;
		this.Name = "BasePrompt";
		this.ShowIcon = false;
		this.ShowInTaskbar = false;
		this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "BasePrompt";
		this.TopMost = true;
		this.ResumeLayout(false);
	}

	#endregion

	protected System.Windows.Forms.Button CancelationButton;
	protected System.Windows.Forms.Button AcceptationButton;
}