using System;
using System.Reflection;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;
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


//string text = "92kakaskas544asdlasdls1212";

//Regex regex = new Regex("^9\\d\\S"); // başlamsını istediğimiz ifade nesne ürettikten sonra buraya yazılır
////Regex regex = new Regex(@"^9\d\S"); // İkinci seçenek
//Match match = regex.Match(text);

//Console.WriteLine(match.Success); // doğru ise true dönecektir.

#endregion
#region Ders 348 + Operatörü

// Belirtien gruptaki karakterlerden bir ya da daha fazlasının olmasını istiyorsak kullanırız

//9 ile başlayan arada  herhangi bir sayısal değerleri olan ve son karakteri de boşluk olmayan bir düzenli ifade oluşturalım 

// ^9\d+\S

//string text = "98745263d";

//Regex regex = new Regex(@"^9\d+\S");
//Match match = regex.Match(text);

//Console.WriteLine(match.Success);


#endregion
#region | Operatörü
//Birden fazla karakter grubundan bir ya da birkacinin ilgili yerde olabilecegini belirtmek istiyorsak mantiksal
//veya operatérii kullanilir.


// Bas harfi a ya da b ya da c olan metinsel ifadeyi girelim.
// a|b|c

//string text = "Ahmet";
//Regex regex = new Regex(@"a|b|c");// büyük küçük harf duyarlıdır.
//Match match = regex.Match(text);

//Console.WriteLine(match.Success);


#endregion
#region {n} Operatörü

//Sabit sayida karakterin olmasa isteniyorsa {adet} seklinde belirtilmeli.

//5@7-7514592
//\d\d\d-\d\d\d\d\d\d
// \d{3}-\d{6}

//string text = "507-751459";
//Regex regex = new Regex(@"\d{3}-\d{6}");
//Match match = regex.Match(text);

//Console.WriteLine(match.Success);

#endregion
#region ? Operatörü

// Bu karakterin önüne gelen karakter en efazla bir, en az sıfır defa olmalıdır.

//\d{3}B?A -----> 213BA, 123A

//string text = "123A";
//Regex regex = new Regex(@"\d{3}B?A");
//Match match = regex.Match(text);

//Console.WriteLine(match.Success);

#endregion
#region . Operatörü

//\n = Kullanildigi yerde \n karakteri disinda herhangi bir karakter bulunabilir.


//string text = "123\hA";
//Regex regex = new Regex(@"\d{3}.A");
//Match match = regex.Match(text);

//Console.WriteLine(match.Success);

#endregion











