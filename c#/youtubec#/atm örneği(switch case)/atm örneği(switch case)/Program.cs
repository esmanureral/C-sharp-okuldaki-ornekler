//atm örneği

using System.ComponentModel.Design;

int bakiye = 1000;

Console.WriteLine("yapmak istediğiniz işlemi seçiniz:");
Console.WriteLine("1-bakiye sorgulama");
Console.WriteLine("2-para çekme");
Console.WriteLine("3-para yatırma");
Console.WriteLine("4-çıkış");

string seçim=Console.ReadLine();

switch (seçim)
{
    case "1":
        Console.WriteLine("bakiyeniz:" + bakiye); break;

    case "2":
        Console.WriteLine("çekmek istediğiniz tutarı giriniz:");
        int çekilecektutar = Convert.ToInt32(Console.ReadLine());
        if (çekilecektutar > bakiye)
        {
            Console.WriteLine("bakiyenizden fazla para çekemezsiniz");
        }
        else
        {
            Console.WriteLine("kalan bakiyeniz:" + (bakiye - çekilecektutar));
        }
        break;
    case "3":
        Console.WriteLine("yatırmak istediğiniz tutar:");
        int yatırılacaktutar = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("bakiyeniz:" + (bakiye + yatırılacaktutar));
        break;

    case "4":
        Console.WriteLine("çıkış yapılıyor");
        break;

    default:
        Console.WriteLine("hatalı giriş");
        break;

}
     