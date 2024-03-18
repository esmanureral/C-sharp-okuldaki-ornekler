//türü int olan a yı byte türüne dönüştürdük.

int a = 5;
byte b =(byte)a;
Console.WriteLine(b.GetType());
Console.WriteLine(b);


// byte (0-255) arasını kapsadığı için değer kaybı oldu.500-256=244

int c = 500;
byte d = (byte)c;
Console.WriteLine(c.GetType());
Console.WriteLine(d);


// int.parse (stringten int a dönüştürme yöntemi)
// not: int.parse() yerine convert.ToInt32() kullanılabilir

string sayi1 = "1";
string sayi2 = "2";

int e=int.Parse(sayi1);
int f=int.Parse(sayi2);
Console.WriteLine(e+f);

// int ı stringe dönüştürme **ToString**

int x = 5;
int y = 10;

string n=x.ToString();
string m=y.ToString();

Console.WriteLine(n+m);
