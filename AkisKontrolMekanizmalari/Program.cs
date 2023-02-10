#region Ders 127(Switch-Case) 
// Switch Case yapılanması sadece bir değişkenin değerini sadece eşitlik durumunda kontrol ederken kullanılır.

//string adi = "Ahmet";
//switch (adi)// kontrol edilen değerin türü ne ise case içerisinde de aynı türden çağırılmalı
//{
//    case "Mehmet":
//        Console.WriteLine("Adı Mehmet");
//        break;
//    case "Ayşe":
//        Console.WriteLine("Adı Ayşe");
//        break;
//    case "Ali":
//        Console.WriteLine("Adı Ali");
//        break;
//    case "Ahmet":
//        Console.WriteLine("Adı Ahmet");
//        break;

//    default:
//        Console.WriteLine("Burada bu isimde biri yok.");
//        break;
//}
#endregion


#region ders 128 When
//int satisTutar = 100;
//switch (satisTutar)
//{
//    case 100 when (3 == 5): // when!den sonra yazılan şey şart olandır. eğer 2 eşitse 5e bu satıra girer(when bir nevi "ve" mantığı ile çalışmakta)
//        Console.WriteLine("buraya girmez çünkü 3 5'e eşit değil");
//        break;
//    case 100:
//        Console.WriteLine("100e eşitdir");
//        break;
//    default:
//        break;
//}
#endregion

#region Ders 148 Örnek1
// klavyeden 2 ürünün fiyatı girildiğinde toplam 200 tl'den fazla ise 2. üründe %25 indirim yaparak ödenecek tutarı 
// gösteren uygulamayı yapalım.
#region Benim Çözüm

Console.Write("Lütfen birinci ürün fiyatı giriniz: ");
int fiyatBir = int.Parse(Console.ReadLine());

Console.Write("Lütfen birinci ürün fiyatı giriniz: ");
int fiyatIki = int.Parse(Console.ReadLine());

int toplam = fiyatBir + fiyatIki;
int indirimliFiyat;
if (toplam > 200)
{
    indirimliFiyat = fiyatIki - (fiyatIki * 25) / 100;
    toplam = fiyatBir + indirimliFiyat;
    Console.WriteLine("Toplam fiyat: " + toplam);
}
else
{
    Console.WriteLine(toplam);
}

#endregion

#region Gencay Hocam'ın Çözümü

Console.Write("Lütfen birinci ürün fiyatı giriniz: ");
int birinciUrunFiyat = int.Parse(Console.ReadLine());

Console.Write("Lütfen birinci ürün fiyatı giriniz: ");
int ikinciUrunFiyat = int.Parse(Console.ReadLine());

if (birinciUrunFiyat + ikinciUrunFiyat > 200)
{
    int toplamSonTutar = birinciUrunFiyat + (ikinciUrunFiyat * 75 / 100);
    Console.WriteLine("Toplam Tutar: "+toplamSonTutar);

}
else
{
    Console.WriteLine(birinciUrunFiyat+ikinciUrunFiyat);
}

#endregion


#endregion