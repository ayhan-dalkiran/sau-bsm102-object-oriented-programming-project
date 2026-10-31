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
using System.Drawing;
using System.Windows.Forms;

namespace Project;

partial class MainForm {
	/// <summary>
	///  Required designer variable.
	/// </summary>
	private System.ComponentModel.IContainer components = null;

	/// <summary>
	///  Clean up any resources being used.
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
	///  Required method for Designer support - do not modify
	///  the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent() {
		this.components = new System.ComponentModel.Container();
		this.tabControl1 = new TabControl();
		this.tabPage1 = new TabPage();
		this.ServicesDataPanel = new DataPanel();
		this.tabPage2 = new TabPage();
		this.PersonnelsDataPanel = new DataPanel();
		this.tabPage3 = new TabPage();
		this.AppointmentsDataPanel = new DataPanel();
		this.tabPage4 = new TabPage();
		this.TransactionsDataPanel = new DataPanel();
		this.PersistenceTimer = new Timer(this.components);
		this.tabControl1.SuspendLayout();
		this.tabPage1.SuspendLayout();
		this.tabPage2.SuspendLayout();
		this.tabPage3.SuspendLayout();
		this.tabPage4.SuspendLayout();
		this.SuspendLayout();
		// 
		// tabControl1
		// 
		this.tabControl1.Controls.Add(this.tabPage1);
		this.tabControl1.Controls.Add(this.tabPage2);
		this.tabControl1.Controls.Add(this.tabPage3);
		this.tabControl1.Controls.Add(this.tabPage4);
		this.tabControl1.Dock = DockStyle.Fill;
		this.tabControl1.Location = new Point(0, 0);
		this.tabControl1.Name = "tabControl1";
		this.tabControl1.SelectedIndex = 0;
		this.tabControl1.Size = new Size(800, 450);
		this.tabControl1.TabIndex = 0;
		// 
		// tabPage1
		// 
		this.tabPage1.Controls.Add(this.ServicesDataPanel);
		this.tabPage1.Location = new Point(4, 24);
		this.tabPage1.Name = "tabPage1";
		this.tabPage1.Padding = new Padding(3);
		this.tabPage1.Size = new Size(792, 422);
		this.tabPage1.TabIndex = 0;
		this.tabPage1.Text = "Hizmetler";
		this.tabPage1.UseVisualStyleBackColor = true;
		// 
		// ServicesDataPanel
		// 
		this.ServicesDataPanel.Dock = DockStyle.Fill;
		this.ServicesDataPanel.Location = new Point(3, 3);
		this.ServicesDataPanel.MinimumSize = new Size(245, 200);
		this.ServicesDataPanel.Name = "ServicesDataPanel";
		this.ServicesDataPanel.Size = new Size(786, 416);
		this.ServicesDataPanel.TabIndex = 0;
		this.ServicesDataPanel.AddRequested += this.ServicesDataPanel_AddRequested;
		this.ServicesDataPanel.ModifyRequested += this.ServicesDataPanel_ModifyRequested;
		this.ServicesDataPanel.RemoveRequested += this.ServicesDataPanel_RemoveRequested;
		// 
		// tabPage2
		// 
		this.tabPage2.Controls.Add(this.PersonnelsDataPanel);
		this.tabPage2.Location = new Point(4, 24);
		this.tabPage2.Name = "tabPage2";
		this.tabPage2.Padding = new Padding(3);
		this.tabPage2.Size = new Size(792, 422);
		this.tabPage2.TabIndex = 1;
		this.tabPage2.Text = "Personeller";
		this.tabPage2.UseVisualStyleBackColor = true;
		// 
		// PersonnelsDataPanel
		// 
		this.PersonnelsDataPanel.Dock = DockStyle.Fill;
		this.PersonnelsDataPanel.Location = new Point(3, 3);
		this.PersonnelsDataPanel.MinimumSize = new Size(245, 200);
		this.PersonnelsDataPanel.Name = "PersonnelsDataPanel";
		this.PersonnelsDataPanel.Size = new Size(786, 416);
		this.PersonnelsDataPanel.TabIndex = 0;
		this.PersonnelsDataPanel.AddRequested += this.PersonnelsDataPanel_AddRequested;
		this.PersonnelsDataPanel.ModifyRequested += this.PersonnelsDataPanel_ModifyRequested;
		this.PersonnelsDataPanel.RemoveRequested += this.PersonnelsDataPanel_RemoveRequested;
		// 
		// tabPage3
		// 
		this.tabPage3.Controls.Add(this.AppointmentsDataPanel);
		this.tabPage3.Location = new Point(4, 24);
		this.tabPage3.Name = "tabPage3";
		this.tabPage3.Padding = new Padding(3);
		this.tabPage3.Size = new Size(792, 422);
		this.tabPage3.TabIndex = 2;
		this.tabPage3.Text = "Randevular";
		this.tabPage3.UseVisualStyleBackColor = true;
		// 
		// AppointmentsDataPanel
		// 
		this.AppointmentsDataPanel.Dock = DockStyle.Fill;
		this.AppointmentsDataPanel.Location = new Point(3, 3);
		this.AppointmentsDataPanel.MinimumSize = new Size(245, 200);
		this.AppointmentsDataPanel.Name = "AppointmentsDataPanel";
		this.AppointmentsDataPanel.Size = new Size(786, 416);
		this.AppointmentsDataPanel.TabIndex = 1;
		this.AppointmentsDataPanel.AddRequested += this.AppointmentsDataPanel_AddRequested;
		this.AppointmentsDataPanel.ModifyRequested += this.AppointmentsDataPanel_ModifyRequested;
		this.AppointmentsDataPanel.RemoveRequested += this.AppointmentsDataPanel_RemoveRequested;
		// 
		// tabPage4
		// 
		this.tabPage4.Controls.Add(this.TransactionsDataPanel);
		this.tabPage4.Location = new Point(4, 24);
		this.tabPage4.Name = "tabPage4";
		this.tabPage4.Padding = new Padding(3);
		this.tabPage4.Size = new Size(792, 422);
		this.tabPage4.TabIndex = 3;
		this.tabPage4.Text = "İşlemler";
		this.tabPage4.UseVisualStyleBackColor = true;
		// 
		// TransactionsDataPanel
		// 
		this.TransactionsDataPanel.Dock = DockStyle.Fill;
		this.TransactionsDataPanel.Location = new Point(3, 3);
		this.TransactionsDataPanel.MinimumSize = new Size(245, 200);
		this.TransactionsDataPanel.Name = "TransactionsDataPanel";
		this.TransactionsDataPanel.Size = new Size(786, 416);
		this.TransactionsDataPanel.TabIndex = 1;
		this.TransactionsDataPanel.AddRequested += this.TransactionsDataPanel_AddRequested;
		this.TransactionsDataPanel.ModifyRequested += this.TransactionsDataPanel_ModifyRequested;
		this.TransactionsDataPanel.RemoveRequested += this.TransactionsDataPanel_RemoveRequested;
		// 
		// PersistenceTimer
		// 
		this.PersistenceTimer.Enabled = true;
		this.PersistenceTimer.Interval = 30000;
		this.PersistenceTimer.Tick += this.PersistenceTimer_Tick;
		// 
		// MainForm
		// 
		this.AutoScaleDimensions = new SizeF(7F, 15F);
		this.AutoScaleMode = AutoScaleMode.Font;
		this.ClientSize = new Size(800, 450);
		this.Controls.Add(this.tabControl1);
		this.Name = "MainForm";
		this.ShowIcon = false;
		this.Text = "Kuaför Programı";
		this.FormClosing += this.MainForm_FormClosing;
		this.tabControl1.ResumeLayout(false);
		this.tabPage1.ResumeLayout(false);
		this.tabPage2.ResumeLayout(false);
		this.tabPage3.ResumeLayout(false);
		this.tabPage4.ResumeLayout(false);
		this.ResumeLayout(false);
	}

	#endregion

	private TabControl tabControl1;
	private TabPage tabPage1;
	private TabPage tabPage2;
	private TabPage tabPage3;
	private TabPage tabPage4;
	private DataPanel ServicesDataPanel;
	private DataPanel PersonnelsDataPanel;
	private DataPanel AppointmentsDataPanel;
	private DataPanel TransactionsDataPanel;
	private Timer PersistenceTimer;
}
