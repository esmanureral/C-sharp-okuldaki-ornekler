// Beden Kitle İndeksi

using System.Security.Authentication.ExtendedProtection;

Console.WriteLine("kilonuzu giriniz:");
int kilo=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("boyunuzu giriniz:");
double boy=Convert.ToDouble(Console.ReadLine());

double bki=boy/(kilo*kilo);

if (bki <= 18)
{
    Console.WriteLine("zayıfsınız");
}
else if (18 < bki && bki <= 25)
{
    Console.WriteLine("normalsiniz");
}
else
{
    Console.WriteLine("obezsiniz");
}