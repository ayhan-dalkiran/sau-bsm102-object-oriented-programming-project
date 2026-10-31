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
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Project;
[JsonConverter(typeof(TelephoneNumberConverter))]
public readonly record struct TelephoneNumber {
	public string FullNumber { get => $"{CountryCode} ({AreaCode}) {SubscriberCode.Substring(0, 3)} {SubscriberCode.Substring(3, 4)}"; }

	public string CountryCode { get; } = "+90";
	public string AreaCode { get; } = "000";
	public string SubscriberCode { get; } = "0000000";

	public static bool TryValidate(string number) => _Pattern.IsMatch(number.Replace(" ", ""));
	public override string ToString() => this.FullNumber;

	public TelephoneNumber() { }
	public TelephoneNumber(string number) {
		if (!TryValidate(number))
			throw new ArgumentException("Invalid telephone number.");

		var match = _Pattern.Match(number.Replace(" ", ""));
		this.CountryCode = match.Groups["Country"].Value;
		this.AreaCode = match.Groups["Area"].Value;
		this.SubscriberCode = match.Groups["Subscriber"].Value;
	}

	private readonly static Regex _Pattern = new(@"\A(?<Country>\+90)\(?(?<Area>[0-9]{3})\)?(?<Subscriber>[0-9]{7})\z", RegexOptions.Compiled);
}

//For serializing a telephone number to a string and vice versa.
file class TelephoneNumberConverter : JsonConverter<TelephoneNumber> {
	public override TelephoneNumber Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => new(reader.GetString()!);
	public override void Write(Utf8JsonWriter writer, TelephoneNumber value, JsonSerializerOptions options) => writer.WriteStringValue(value.FullNumber);
}
