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
using System;
using System.Windows.Forms;

namespace Project;

internal static class Program {
	/// <summary>
	///  The main entry point for the application.
	/// </summary>
	[STAThread]
	static void Main() {
		// To customize application configuration such as set high DPI settings or default font,
		// see https://aka.ms/applicationconfiguration.
		ApplicationConfiguration.Initialize();
		Application.Run(new MainForm());
	}
}