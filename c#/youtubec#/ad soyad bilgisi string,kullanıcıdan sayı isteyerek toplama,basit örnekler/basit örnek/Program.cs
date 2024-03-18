//ad-soyad bilgisini string değişenlerini alarak ekrana yazdırmak.

string ad, soyad;
Console.WriteLine("adınız:");
ad = Console.ReadLine();

Console.WriteLine("soyadınız:");
soyad = Console.ReadLine();

Console.WriteLine("Merhaba {0} {1}", ad, soyad);

//kullanıcıdan iki sayı istiyerek toplamı ekrana yazdırmak.

int sayi1, sayi2, toplam;


Console.WriteLine("sayi1:");
sayi1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("sayi2");
sayi2 = Convert.ToInt32(Console.ReadLine());

toplam = sayi1 + sayi2;

Console.WriteLine("{0} ve {1} Sayısının Toplamı : {2}", sayi1, sayi2, toplam);
