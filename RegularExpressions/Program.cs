using System.Text.RegularExpressions;
#region Ders 346 ^ Operatörü

// ^ Operatörü : Satır başının istenen ifade ile başlamsını sağlar.


//string text = "9kakaskas544asdlasdls1212";

//Regex regex = new Regex("^9"); // başlamsını istediğimiz ifade nesne ürettikten sonra buraya yazılır
//Match match = regex.Match(text);

//Console.WriteLine(match.Success); // doğru ise true dönecektir.

#endregion

#region Ders 347 \ Operatörü

// \ : belirli karakter gruplarını içermek istiyorsak kullanırız. Tek başına kullanılmaz aşağıda tanımladığı gibi kullanılır

// \D : Metinsel değerin ilgili yerinde rakam olmayan tek bir karakterin bulunması gerektiğini belirtir
// \d : Metinsel değerin ilgili yerinde 0 - 9 arasında tek bir sayı olacağı ifade edilir

// \W : Metinsel değerin ilgili yerinde alfanumerik olmayan karakterin olması gerektiği belirtilir. Alfanumerik karakterler: a-z A-Z 0-9
// \w : Metinsel değerin ilgili yerinde alfanumerik olan karakterin olacağo ifade edilir.

// \S : Metinsel değerin ilgili yerinde boşluk karakterileri (tab/space) dışında herhangi bir karakterin olacağı belirtilir.
// \s : Metinsel değerin ilgili yerinde sadece boşluk karakterinin olacağı ifade edilir.


// Örn 

// 9 ile başlayan ikinci karakteri herhangi bir sayı olan ve son karakteri de boşluk olmayan bir düzenli ifade oluşturalım 

// ^9\d\S


string text = "92kakaskas544asdlasdls1212";

Regex regex = new Regex("^9\\d\\S"); // başlamsını istediğimiz ifade nesne ürettikten sonra buraya yazılır
//Regex regex = new Regex(@"^9\d\S"); // İkinci seçenek
Match match = regex.Match(text);

Console.WriteLine(match.Success); // doğru ise true dönecektir.

#endregion


