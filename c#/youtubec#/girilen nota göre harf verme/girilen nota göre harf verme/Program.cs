int birincinot, ikincinot,ortalama;
Console.WriteLine("birinci notunuzu giriniz:");
birincinot=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ikinci notunuzu giriniz:");
ikincinot=Convert.ToInt32(Console.ReadLine());

ortalama = (birincinot + ikincinot) / 2;

if(ortalama<=100 && ortalama>=80)
{
    Console.WriteLine("A+");
}
else if(ortalama>=60 && ortalama<80)
{
    Console.WriteLine("B+");
}

