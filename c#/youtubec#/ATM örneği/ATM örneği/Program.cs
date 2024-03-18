//ATM örneği
// 1-bakiye görüntüleme 2-Para çekme 3-para yatırma 4-q çıkış

int bakiye = 1000;
Console.WriteLine("yapmak istediğiniz işlemi giriniz:");
string seçim = Console.ReadLine();

if (seçim=="1")
{ Console.WriteLine("Şuan ki bakiyeniz:"+bakiye); }


else if (seçim=="2")
{ Console.WriteLine("çekmek isteiğiniz tutarı giriniz:");
    int çekilecektutar = Convert.ToInt32(Console.ReadLine());
    if (çekilecektutar <= bakiye)
    { Console.WriteLine("kalan tutar:" + (bakiye - çekilecektutar)); }
    else { Console.WriteLine("bakiyenizden fazla para çekemezsiniz!"); }
}


else if(seçim=="3")
{ Console.WriteLine("yatırmak istediğiniz tutar:");
    int yatırılacaktutar = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("bakiyeniz:"+(bakiye+yatırılacaktutar));

}


else if(seçim =="q")
{ Console.WriteLine("çıkış yaptınız"); }
else { Console.WriteLine("hatalı giriş"); }
