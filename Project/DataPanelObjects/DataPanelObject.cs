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
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Project;
public abstract class DataPanelObject {
	public virtual event PropertyChangedEventHandler? PropertyChanged;

	public T GetProperty<T>(string propertyName) {
		var propertyInfo = this.GetType().GetProperty(propertyName);

		if (propertyInfo is null)
			throw new ArgumentException($"Property '{propertyName}' does not exist.");

		return (T)propertyInfo.GetValue(this)!;
	}

	protected void SetField<T>(ref T field, in T value, [CallerMemberName] string propertyName = "") {
		if (object.Equals(field, value))
			return;

		field = value;
		InvokePropertyChanged(this, propertyName);
	}

	//Can't invoke event handlers from derived classes directly, hence this method.
	protected void InvokePropertyChanged(DataPanelObject sender, string propertyName) => this.PropertyChanged?.Invoke(sender, propertyName);
}

public delegate void PropertyChangedEventHandler(DataPanelObject sender, string propertyName);
