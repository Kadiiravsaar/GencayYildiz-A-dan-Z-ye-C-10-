#region Ders 173 Çalışma zamanı hatası
// --
//Console.WriteLine("Lütfen birinci sayiyi giriniz: ");
//int sayi1 = int.Parse(Console.ReadLine());
//Console.WriteLine("Lütfen ikinci sayiyi giriniz: ");
//int sayi2 = int.Parse(Console.ReadLine());

//Console.WriteLine("Toplam: "+(sayi1+sayi2));

// kullanıcı int'e parse edilemeyen değer girdiğinde patlayacak !!!
#endregion

#region Ders 174 try-catch
//try
//{
//    Console.WriteLine("Lütfen birinci sayiyi giriniz: ");
//    int sayiBir = int.Parse(Console.ReadLine());
//    Console.WriteLine("Lütfen ikinci sayiyi giriniz: ");
//    int sayiIki = int.Parse(Console.ReadLine());

//    Console.WriteLine("Toplam: " + (sayiBir + sayiIki));


//}
//catch (Exception)
//{

//    Console.WriteLine("Lütfen bir SAYI giriniz.");
//}
#endregion

#region Ders 181 try-catch-finally
// finally bloğu bu yapıda hata alınsada alınmasada çalıştırılması gereken kodların yazıldığı yer.
//try
//{
//	// hata verebilecek kodlar
//}
//catch (Exception)
//{
//	// hata alındıktan sonra yapılacak işlemler
//}
//finally
//{
//	// her iki durumda da çalışmasını istediğimiz durumlar.
//}

#endregion
// faktoriyel bulma 
Console.Write("Bir sayı gir faktöriyel bulalım: ");
int sayi = int.Parse(Console.ReadLine());
int fak = 1;
string sayac = "";

for (int i = 1; i <= sayi; i++)
{
    fak *= i;
     sayac += i +  (i == sayi ? " = " : " X ");


}
Console.WriteLine("faktoriyel: " + sayac + fak);
