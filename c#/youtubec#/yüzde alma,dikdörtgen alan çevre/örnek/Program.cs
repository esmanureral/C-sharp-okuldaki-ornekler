// girilen sayının %18 ini bulma

double sayi, sonuc;
Console.WriteLine("sayı giriniz:");
sayi=Convert.ToDouble(Console.ReadLine());
sonuc = sayi * 18 / 100;
Console.WriteLine("sayının %18'i: {0}", sonuc);

// dikdörtgenin alan çevre hesabı

int kisa, uzun, alan, çevre;
Console.WriteLine("kısa kenarı giriniz:");
kisa=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("uzun kenarı giriniz:");
uzun=Convert.ToInt32(Console.ReadLine());
alan = kisa * uzun;
çevre = 2 * (kisa + uzun);
Console.WriteLine("alanı:" + alan);
Console.WriteLine("çevre:" +çevre);