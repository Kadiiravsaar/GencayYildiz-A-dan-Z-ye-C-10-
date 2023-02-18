#region Ders 314

string metin = "Laylaylom galiba sana göre sevmeler...";


#region Contains
// Bu metot string olarak verilen cümle içerisinde var mı ? yok mu ? check eden metotdur. Geriye bool olarak döner. 
// C# büyük küçük harf duyarlı bir dildir.

//bool sonuc = metin.Contains("sana");
//Console.WriteLine(sonuc);

#endregion

#region StartsWth
// ilgili metinin verilen değer ile başlayıp başlamadığını kontrol eder.

//Console.WriteLine(metin.StartsWith("Laylay"));

#endregion

#region EndsWith

//Console.WriteLine(metin.EndsWith(".."));

#endregion

#region Equals
// Elimizde ki metinsel ifadenin gherhangi bir ifadenin değersel olarak eşitmi ona bakar

//Console.WriteLine(metin.Equals("Mehmet")); false
//Console.WriteLine(metin.Equals("Laylaylom galiba sana göre sevmeler...")); // true

#endregion

#region Compare
// metinsel değerleri kendi arasında karşılaştırır ve sonuç INT döner.
// 0 : Her iki değer birbirine eşittir.
// 1 : Soldaki, sağdakinden alfanmerik olarak büyük
// 1 : Soldaki, sağdakinden alfanmerik olarak küçük

//Console.WriteLine(string.Compare(metin, "Z")); // metin "L" ile başlar fakat "Z" büyüktür. -1 döndürecek

#endregion

#region CompareTo

// Compare ile aynı amaca hizmet eder

#endregion

#region IndexOf

// Verilen değerin str ifade içerisinde olup olmamasını gerine int olarak döndüren fonksiyondur.
// Gerine int olarak indexNo'yu döndürür. Aranan kelime bir kelime ise kelimenin ilk harfini döndürür.

//Console.WriteLine(metin.IndexOf("La"));
//Console.WriteLine(metin.IndexOf("Lay"));
//Console.WriteLine(metin.IndexOf("la"));
//Console.WriteLine(metin.IndexOf("sana"));

#endregion

#region Insert

// Elimizde ki metinsel ifadeye değer eklememizi sağlar.
//string eklenmisMetin = metin.Insert(17, "Merhaba ");
//Console.WriteLine(metin);
//Console.WriteLine(eklenmisMetin);

#endregion

#region Remove

//Console.WriteLine(metin.Remove(5,5)); // 5. indexten başlar 5 adet siler

#endregion

#region Replace

//Console.WriteLine(metin.Replace('a','b')); // a karakterlerini b ile değiştirir.

#endregion

#region Split

// Metinsel ifadeyi verilen değeri ayraç olarak kullanıp parçalayan ve sonucu string dizisi olarak döndüren fonksiyondur

//string[] dizi = metin.Split(' ');

//string[] dizi =  metin.Split(' ', 'a'); // hem a gçrdüğü yerde hem de boşluk gördüğü yerde parçalamaktadır.

#endregion

#region Substring

// Metinsel ifadenin belirli bir aralığını elde edip çalışmamızı sağlar

//Console.WriteLine(metin.Substring(5)); // 5. indexten sonuna kadar tüm değerleri getirir.
//Console.WriteLine(metin.Substring(5, 10)); // 5. indexten başlar 10 karakter getirir.


#endregion


#endregion