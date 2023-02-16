#region Ders 243 Dizi-Array
// Diziler REFERANS türlü değerlerdir. !!!
// Nesnel yapılardır. Özlerinde Class'tırlar
#endregion

#region Ders 252 Dizi tanımlamaları

//int[] ages = new int[5];

//string[] names = { "Kadir", "Ali", "Mehmet" };

//string[] names2 = new string[] { "Kadir", "Ali", "Mehmet" };

//int[] digit = new[] { 2, 3, 4, 5 };

//var sayi = new[] { 1, 2, 3, 4, 5, };

#endregion

#region Array Sınıfı

// Array sınıfı bir referans türdür.

//Array yaslar = new int[3];
// Dizi olarak tanımlanan değikenler Array sınıfından türetilmektedir.

#region Array türünden Diziye değer atama

#region 1.Yöntem

//int[] dizi =new int[3];
//dizi[0] = 5;
//dizi[1] = 15;
//dizi[2] = 25;
//dizi[3] = 25;
//Array dizi2 = dizi;


#endregion
#endregion
#region 2.Yöntem
//Array dizi = new int[] { 1, 2, 3, 4 }; 
//Array dizi2 = new int[4] { 1, 2, 3, 4 }; 
//Array dizi3 = new[] { 1, 2, 3, 4 };
// Array dizi4 = { 1, 2, 3, 4 }; KULLANILAMAZ..!!!


#endregion

#region 3.Yöntem
//Array dizi = new int[3];
//dizi.SetValue(30, 0);
//dizi.SetValue(40, 1);
//dizi.SetValue(50, 2);

//object value = dizi.GetValue(1);
//Console.WriteLine(value);

#endregion

#region Clear
// Clear => Dizinin türüne uygun default değerler atar yani int = 0, string = null

Array isimler = new[] { "Kadir", "Mehmet" };
//Array.Clear(isimler, 0, isimler.Length); // 0'dan başla dizi sonuna kadar git

//for (int i = 0; i < isimler.Length; i++)
//{
//    Console.WriteLine(isimler.GetValue(i));
//}





#endregion


#endregion