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
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Project;
public static class Persistence {
	public static void SaveData() {
		File.WriteAllText(ServicesPath, JsonSerializer.Serialize(Services, Options));
		File.WriteAllText(PersonnelsPath, JsonSerializer.Serialize(Personnels, Options));
		File.WriteAllText(AppointmentsPath, JsonSerializer.Serialize(Appointments, Options));
		File.WriteAllText(TransactionsPath, JsonSerializer.Serialize(Transactions, Options));
	}
	public static void LoadData() {
		Services = JsonSerializer.Deserialize<HashSet<Service>>(File.ReadAllText(ServicesPath), Options)!;
		Personnels = JsonSerializer.Deserialize<HashSet<Personnel>>(File.ReadAllText(PersonnelsPath), Options)!;
		Appointments = JsonSerializer.Deserialize<HashSet<Appointment>>(File.ReadAllText(AppointmentsPath), Options)!;
		Transactions = JsonSerializer.Deserialize<HashSet<Transaction>>(File.ReadAllText(TransactionsPath), Options)!;
	}

	public static HashSet<Service> Services { get; set; } = new();
	public static HashSet<Personnel> Personnels { get; set; } = new();
	public static HashSet<Appointment> Appointments { get; set; } = new();
	public static HashSet<Transaction> Transactions { get; set; } = new();

	private static string ServicesPath = Path.Combine(Environment.CurrentDirectory, @"Persistence\Services.json");
	private static string PersonnelsPath = Path.Combine(Environment.CurrentDirectory, @"Persistence\Personnels.json");
	private static string AppointmentsPath = Path.Combine(Environment.CurrentDirectory, @"Persistence\Appointments.json");
	private static string TransactionsPath = Path.Combine(Environment.CurrentDirectory, @"Persistence\Transactions.json");

	//Json serialization because I'm lazy.
	private static JsonSerializerOptions Options = new() {
		Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
		WriteIndented = false
	};
}
