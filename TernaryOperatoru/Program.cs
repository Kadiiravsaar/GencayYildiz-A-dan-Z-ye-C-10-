#region ders 108 Ternary Operatörü
// Not:
// Bir değişkene/metoda/property'e değer atarken eğer ki bu şarta göre fark edecekse satır bazlı ya da
// tek satırda bu şart kontrolü yaparak duruma göre değer döndürmeyi sağlar

//Ternary Opr ?:

//                          Eger sart true ise buraya       Eger sart false ise buraya girecek 
// mesaj = ....Sart/durum.......?.................................:-----------------------------------

// ** Dönecek değerler aynı türde olmalıdır. **

//bool medeniHal = true;
//string mesaj = medeniHal == true ? "Evlilere kapmanya..." : "Bekarlara kampanya...";

//Console.WriteLine(mesaj);
#endregion

#region ders 109
//int yas = 23;
//// Soru : Yaşı 23'den küçük olanlara "23'den küçük", 23 olanlara "23" ve 23'den büyük olanlara "23'den büyük" değerini Ternary ile yazın

//string sonuc = yas < 23 ? "Yaş 23'den küçük" : (yas == 23 ? "Yaş 23'e eşit" : "Yaş 23'den büyük");
//Console.WriteLine(sonuc);
#endregion

#region ders 110
//Kullanici tarafindan girilen sayinin asagidaki önergelere göre hesabini gerceklestiren kodu gelistiriniz.
// sayi < 3                       => sayi * S

// sayi > 3 && sayi < 9           => sayi * 3

// sayi >= 9 8& sayi % 2 == 0     => sayi * 10

// sayi % 2 == 1                  => sayi

// hiç biri değilse               => -1


//Console.Write("Lütfen bir sayi giriniz: ");
//int sayi = int.Parse(Console.ReadLine());

//int sonuc = sayi < 3 ? sayi * 5 :
//    (sayi > 3 && sayi < 9 ? sayi * 3 :
//    (sayi >= 9 && sayi % 2 == 0 ? sayi * 10 :
//    (sayi % 2 == 1 ? sayi : -1 )));
//Console.WriteLine("Sonuc: " + sonuc);
#endregion
