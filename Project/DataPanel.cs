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
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project;
public partial class DataPanel : UserControl {
	public event EventHandler? AddRequested {
		add {
			this.AddButton.Click += value;
			this.AddToolButton.Click += value;
		}
		remove {
			this.AddButton.Click -= value;
			this.AddToolButton.Click -= value;
		}
	}
	public event EventHandler? ModifyRequested {
		add {
			this.ModifyButton.Click += value;
			this.ModifyToolButton.Click += value;
		}
		remove {
			this.ModifyButton.Click -= value;
			this.ModifyToolButton.Click -= value;
		}
	}
	public event RemoveRequestedEventHandler? RemoveRequested;

	public void AddData(DataPanelObject data) {
		if (this.DataMap.ContainsKey(data))
			return;

		//For some reason, constructing the DataGridViewRow object
		//and adding it to the collecting by yourself doesn't work.
		int rowIndex = this.DataGrid.Rows.Add();
		var row = this.DataGrid.Rows[rowIndex];

		foreach (var propertyName in this.SubscribedProperties)
			row.Cells[propertyName].Value = data.GetProperty<object>(propertyName);

		data.PropertyChanged += this.DataPanelObject_PropertyChanged;
		this.DataMap[data] = row;
		this.RowMap[row] = data;
	}
	public void AddData(IEnumerable<DataPanelObject> datalist) {
		foreach (var data in datalist)
			AddData(data);
	}

	public void RemoveData(DataPanelObject data) {
		var row = DataMap[data];
		this.DataGrid.Rows.Remove(row);
		DataMap.Remove(data);
		RowMap.Remove(row);
		data.PropertyChanged -= this.DataPanelObject_PropertyChanged;
	}
	public void RemoveData(IEnumerable<DataPanelObject> dataList) {
		foreach (var data in dataList)
			RemoveData(data);
	}

	public DataPanelObject? GetSelection() {
		var selection = this.DataGrid.SelectedRows;

		if (selection.Count == 0)
			return null;
		else
			return RowMap[selection[0]];
	}
	public DataPanelObject[] GetSelections() {
		var selection = this.DataGrid.SelectedRows;
		var list = new DataPanelObject[selection.Count];
		for (int i = 0; i < selection.Count; i++)
			list[i] = RowMap[selection[i]];
		return list;
	}

	public void SubscribeToProperty(string propertyName, string headerText) {
		if (this.DataGrid.Columns.Contains(propertyName)) {
			this.DataGrid.Columns[propertyName].HeaderText = headerText;
			return;
		}

		var column = new DataGridViewTextBoxColumn();
		column.Name = propertyName;
		column.HeaderText = headerText;
		column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.DataGrid.Columns.Add(column);
		this.SubscribedProperties.Add(propertyName);

		foreach (var pair in DataMap) {
			pair.Value.Cells[propertyName].Value = pair.Key.GetProperty<object>(propertyName);
		}
	}

	public DataPanel() {
		InitializeComponent();
	}

	[Browsable(false)] protected Dictionary<DataPanelObject, DataGridViewRow> DataMap { get; } = new();
	[Browsable(false)] protected Dictionary<DataGridViewRow, DataPanelObject> RowMap { get; } = new();
	[Browsable(false)] protected HashSet<string> SubscribedProperties { get; } = new();

	private void DataPanelObject_PropertyChanged(DataPanelObject sender, string propertyName) {
		if (!this.SubscribedProperties.Contains(propertyName))
			return;

		this.DataMap[sender].Cells[propertyName].Value = sender.GetProperty<object>(propertyName);
	}

	private void DataGrid_SelectionChanged(object sender, EventArgs e) {
		switch (this.DataGrid.SelectedRows.Count) {
			case 0:
				this.RemoveButton.Enabled = false;
				this.RemoveToolButton.Enabled = false;

				this.ModifyButton.Enabled = false;
				this.ModifyToolButton.Enabled = false;
				break;
			case 1:
				this.RemoveButton.Enabled = true;
				this.RemoveToolButton.Enabled = true;

				this.ModifyButton.Enabled = true;
				this.ModifyToolButton.Enabled = true;
				break;
			default:
				this.RemoveButton.Enabled = true;
				this.RemoveToolButton.Enabled = true;

				this.ModifyButton.Enabled = false;
				this.ModifyToolButton.Enabled = false;
				break;
		}
	}

	private void RemoveButton_Click(object sender, EventArgs e) {
		var result = MessageBox.Show(
			$"{this.DataGrid.SelectedRows.Count} tane bilgi silinecek.", "Emin misiniz?",
			MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning,
			MessageBoxDefaultButton.Button3
			);
		if (result == DialogResult.Yes) {
			var selection = this.GetSelections();
			this.RemoveData(selection);
			this.RemoveRequested?.Invoke(this, selection);
		}
	}
}

public delegate void RemoveRequestedEventHandler(DataPanel sender, DataPanelObject[] list);
