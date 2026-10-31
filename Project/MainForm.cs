/****************************************************************************
**					SAKARYA ÜNÝVERSÝTESÝ
**				BÝLGÝSAYAR VE BÝLÝÞÝM BÝLÝMLERÝ FAKÜLTESÝ
**				    BÝLGÝSAYAR MÜHENDÝSLÝÐÝ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSÝ
**					2023-2024 BAHAR DÖNEMÝ
**	
**				ÖDEV NUMARASI..........: Proje 1
**				ÖÐRENCÝ ADI............: Ayhan Dalkýran
**				ÖÐRENCÝ NUMARASI.......: G221210020
**				DERSÝN ALINDIÐI GRUP...: 2. Öðretim C
****************************************************************************/
using Project.Prompts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Project;

public partial class MainForm : Form {
	public MainForm() {
		InitializeComponent();
		Persistence.LoadData();

		//Subscribing to properties and adding data read from the files.
		this.ServicesDataPanel.SubscribeToProperty("Name", "Hizmet Ýsmi");
		this.ServicesDataPanel.SubscribeToProperty("Price", "Ücret");
		this.ServicesDataPanel.AddData(Persistence.Services);

		this.PersonnelsDataPanel.SubscribeToProperty("Name", "Personel Ýsmi");
		this.PersonnelsDataPanel.SubscribeToProperty("Telephone", "Telefon Numarasý");
		this.PersonnelsDataPanel.SubscribeToProperty("Wage", "Maaþ");
		this.PersonnelsDataPanel.SubscribeToProperty("Position", "Makam");
		this.PersonnelsDataPanel.AddData(Persistence.Personnels);

		this.AppointmentsDataPanel.SubscribeToProperty("Date", "Tarih");
		this.AppointmentsDataPanel.SubscribeToProperty("CustomerName", "Müþteri Ýsmi");
		this.AppointmentsDataPanel.SubscribeToProperty("CustomerTelephone", "Müþteri Telefon Numarasý");
		this.AppointmentsDataPanel.SubscribeToProperty("Description", "Açýklama");
		this.AppointmentsDataPanel.AddData(Persistence.Appointments);

		this.TransactionsDataPanel.SubscribeToProperty("Date", "Tarih");
		this.TransactionsDataPanel.SubscribeToProperty("Amount", "Tutar");
		this.TransactionsDataPanel.SubscribeToProperty("Description", "Açýklama");
		this.TransactionsDataPanel.AddData(Persistence.Transactions);
	}

	//A lot of copy-paste methods because visual studio designer does not support generic controls.
	#region EventHandlers

	private void ServicesDataPanel_AddRequested(object sender, EventArgs e) {
		var data = new Service();
		var result = ServicePrompt.ShowPrompt(data);

		if (result == DialogResult.OK) {
			Persistence.Services.Add(data);
			this.ServicesDataPanel.AddData(data);
		}
	}
	private void ServicesDataPanel_ModifyRequested(object sender, EventArgs e) {
		var service = (Service)this.ServicesDataPanel.GetSelection()!;
		ServicePrompt.ShowPrompt(service);
	}
	private void ServicesDataPanel_RemoveRequested(DataPanel sender, DataPanelObject[] list) {
		foreach (var data in list)
			Persistence.Services.Remove((Service)data);
	}

	private void PersonnelsDataPanel_AddRequested(object sender, EventArgs e) {
		var data = new Personnel();
		var result = PersonnelPrompt.ShowPrompt(data);

		if (result == DialogResult.OK) {
			Persistence.Personnels.Add(data);
			this.PersonnelsDataPanel.AddData(data);
		}
	}
	private void PersonnelsDataPanel_ModifyRequested(object sender, EventArgs e) {
		var data = (Personnel)this.PersonnelsDataPanel.GetSelection()!;
		PersonnelPrompt.ShowPrompt(data);
	}
	private void PersonnelsDataPanel_RemoveRequested(DataPanel sender, DataPanelObject[] list) {
		foreach (var data in list)
			Persistence.Personnels.Remove((Personnel)data);
	}

	private void AppointmentsDataPanel_AddRequested(object sender, EventArgs e) {
		var data = new Appointment();
		var result = AppointmentPrompt.ShowPrompt(data);

		if (result == DialogResult.OK) {
			Persistence.Appointments.Add(data);
			this.AppointmentsDataPanel.AddData(data);
		}
	}
	private void AppointmentsDataPanel_ModifyRequested(object sender, EventArgs e) {
		var data = (Appointment)this.AppointmentsDataPanel.GetSelection()!;
		AppointmentPrompt.ShowPrompt(data);
	}
	private void AppointmentsDataPanel_RemoveRequested(DataPanel sender, DataPanelObject[] list) {
		foreach (var data in list)
			Persistence.Appointments.Remove((Appointment)data);
	}

	private void TransactionsDataPanel_AddRequested(object sender, EventArgs e) {
		var data = new Transaction();
		var result = TransactionPrompt.ShowPrompt(data);

		if (result == DialogResult.OK) {
			Persistence.Transactions.Add(data);
			this.TransactionsDataPanel.AddData(data);
		}
	}
	private void TransactionsDataPanel_ModifyRequested(object sender, EventArgs e) {
		var data = (Transaction)this.TransactionsDataPanel.GetSelection()!;
		TransactionPrompt.ShowPrompt(data);
	}
	private void TransactionsDataPanel_RemoveRequested(DataPanel sender, DataPanelObject[] list) {
		foreach (var data in list)
			Persistence.Transactions.Remove((Transaction)data);
	}

	#endregion

	private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
		Persistence.SaveData();
	}

	//Data is saved every 30 seconds.
	private void PersistenceTimer_Tick(object sender, EventArgs e) {
		Persistence.SaveData();
	}
}
