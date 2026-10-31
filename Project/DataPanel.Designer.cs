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
namespace Project;

partial class DataPanel {
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

	#region Component Designer generated code

	/// <summary> 
	/// Required method for Designer support - do not modify 
	/// the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent() {
		this.components = new System.ComponentModel.Container();
		this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
		this.DataGrid = new System.Windows.Forms.DataGridView();
		this.ContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
		this.AddToolButton = new System.Windows.Forms.ToolStripMenuItem();
		this.RemoveToolButton = new System.Windows.Forms.ToolStripMenuItem();
		this.ModifyToolButton = new System.Windows.Forms.ToolStripMenuItem();
		this.AddButton = new System.Windows.Forms.Button();
		this.RemoveButton = new System.Windows.Forms.Button();
		this.ModifyButton = new System.Windows.Forms.Button();
		this.tableLayoutPanel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.DataGrid).BeginInit();
		this.ContextMenu.SuspendLayout();
		this.SuspendLayout();
		// 
		// tableLayoutPanel1
		// 
		this.tableLayoutPanel1.ColumnCount = 4;
		this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
		this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
		this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
		this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
		this.tableLayoutPanel1.Controls.Add(this.DataGrid, 0, 0);
		this.tableLayoutPanel1.Controls.Add(this.AddButton, 0, 1);
		this.tableLayoutPanel1.Controls.Add(this.RemoveButton, 1, 1);
		this.tableLayoutPanel1.Controls.Add(this.ModifyButton, 2, 1);
		this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
		this.tableLayoutPanel1.Name = "tableLayoutPanel1";
		this.tableLayoutPanel1.RowCount = 2;
		this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
		this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
		this.tableLayoutPanel1.Size = new System.Drawing.Size(245, 200);
		this.tableLayoutPanel1.TabIndex = 1;
		// 
		// DataGrid
		// 
		this.DataGrid.AllowUserToAddRows = false;
		this.DataGrid.AllowUserToDeleteRows = false;
		this.DataGrid.AllowUserToOrderColumns = true;
		this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.tableLayoutPanel1.SetColumnSpan(this.DataGrid, 4);
		this.DataGrid.ContextMenuStrip = this.ContextMenu;
		this.DataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
		this.DataGrid.Location = new System.Drawing.Point(3, 3);
		this.DataGrid.Name = "DataGrid";
		this.DataGrid.ReadOnly = true;
		this.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.DataGrid.Size = new System.Drawing.Size(239, 165);
		this.DataGrid.TabIndex = 0;
		this.DataGrid.SelectionChanged += this.DataGrid_SelectionChanged;
		// 
		// ContextMenu
		// 
		this.ContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.AddToolButton, this.RemoveToolButton, this.ModifyToolButton });
		this.ContextMenu.Name = "ContextMenu";
		this.ContextMenu.Size = new System.Drawing.Size(181, 92);
		// 
		// AddToolButton
		// 
		this.AddToolButton.Name = "AddToolButton";
		this.AddToolButton.Size = new System.Drawing.Size(180, 22);
		this.AddToolButton.Text = "Ekle..";
		// 
		// RemoveToolButton
		// 
		this.RemoveToolButton.Name = "RemoveToolButton";
		this.RemoveToolButton.Size = new System.Drawing.Size(180, 22);
		this.RemoveToolButton.Text = "Sil";
		this.RemoveToolButton.Click += this.RemoveButton_Click;
		// 
		// ModifyToolButton
		// 
		this.ModifyToolButton.Name = "ModifyToolButton";
		this.ModifyToolButton.Size = new System.Drawing.Size(180, 22);
		this.ModifyToolButton.Text = "Düzenle..";
		// 
		// AddButton
		// 
		this.AddButton.Location = new System.Drawing.Point(3, 174);
		this.AddButton.Name = "AddButton";
		this.AddButton.Size = new System.Drawing.Size(75, 23);
		this.AddButton.TabIndex = 1;
		this.AddButton.Text = "Ekle..";
		this.AddButton.UseVisualStyleBackColor = true;
		// 
		// RemoveButton
		// 
		this.RemoveButton.Enabled = false;
		this.RemoveButton.Location = new System.Drawing.Point(84, 174);
		this.RemoveButton.Name = "RemoveButton";
		this.RemoveButton.Size = new System.Drawing.Size(75, 23);
		this.RemoveButton.TabIndex = 2;
		this.RemoveButton.Text = "Sil";
		this.RemoveButton.UseVisualStyleBackColor = true;
		this.RemoveButton.Click += this.RemoveButton_Click;
		// 
		// ModifyButton
		// 
		this.ModifyButton.Enabled = false;
		this.ModifyButton.Location = new System.Drawing.Point(165, 174);
		this.ModifyButton.Name = "ModifyButton";
		this.ModifyButton.Size = new System.Drawing.Size(75, 23);
		this.ModifyButton.TabIndex = 3;
		this.ModifyButton.Text = "Düzenle..";
		this.ModifyButton.UseVisualStyleBackColor = true;
		// 
		// DataPanel
		// 
		this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.Controls.Add(this.tableLayoutPanel1);
		this.MinimumSize = new System.Drawing.Size(245, 200);
		this.Name = "DataPanel";
		this.Size = new System.Drawing.Size(245, 200);
		this.tableLayoutPanel1.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.DataGrid).EndInit();
		this.ContextMenu.ResumeLayout(false);
		this.ResumeLayout(false);
	}

	#endregion

	private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
	private System.Windows.Forms.DataGridView DataGrid;
	private System.Windows.Forms.Button AddButton;
	private System.Windows.Forms.Button RemoveButton;
	private System.Windows.Forms.Button ModifyButton;
	private System.Windows.Forms.ContextMenuStrip ContextMenu;
	private System.Windows.Forms.ToolStripMenuItem AddToolButton;
	private System.Windows.Forms.ToolStripMenuItem RemoveToolButton;
	private System.Windows.Forms.ToolStripMenuItem ModifyToolButton;
}
