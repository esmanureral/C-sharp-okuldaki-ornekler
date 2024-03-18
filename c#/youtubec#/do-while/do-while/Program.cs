// 1 den 10 e kadar olan sayıları while ile yazdırma 

int a = 1;
while(a<=10)
{
    Console.WriteLine(a);
    a++;
}

//1 den 100'e kadar olan çift sayıları yazdırma

int b = 100;
while(b>=0)
{
    Console.WriteLine(b); 
    b-=2;
}


// 1 den 100 e kadar olan sayıları do-while ile yazdırma

int c = 1;
do
{
    Console.WriteLine(c);
    c++;
}
while(c<=10);


// 1 den 100 e kadar olan sayıların toplamını do-while ile yazdırma

int d = 1;
int toplam = 0 ;
do
{
    toplam += d;
    d++;
}
while(d<=100);
Console.WriteLine("toplam:"+toplam);