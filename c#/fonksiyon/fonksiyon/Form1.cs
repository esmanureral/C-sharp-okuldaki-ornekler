using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace fonksiyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*ÖRNEK 1-parametre olarak almýþ oldugu bir degerin faktörüyelini hesaplayan
         ve sonucu geri gönderen bir fonksiyon yazýnýz ve kullanýnýz*/

        public int fnk_faktoriyel(int a)
        {
            int fact = 1;
            for (int i = 1; i <= a; i++)
            {
                fact = fact * i;
            }
            return fact;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(txt_1.Text);
            int sonuc = fnk_faktoriyel(sayi);
            MessageBox.Show("sayýnýn faktöriyeli:" + sonuc);
        }


        /*ÖRNEK2-Parametre olarak almýþ olduðu degerler arasýndaki
         * 5'e bölünen sayýlarýn ortalamasýný bulan bir fonk. yazýnýz
         ve kullanýnýz*/
        public double fnk_ort_5(int a, int b)
        {
            int sayi_k = 0;
            int sayi_b = 0;

            if (a < b)
            {
                sayi_k = a;
                sayi_b = b;
            }
            else
            {
                sayi_k = b;
                sayi_b = a;
            }

            double toplam = 0;
            double sayac = 0;

            for (int i = (sayi_k + 1); i < sayi_b; i++)
            {
                if (i % 5 == 0)
                {
                    toplam = toplam + i;
                    sayac = sayac + 1;
                }
            }

            double ortalama = toplam / sayac;
            return ortalama;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txt_2.Text);
            int sayi2 = Convert.ToInt32(txt_3.Text);
            double sonuc = fnk_ort_5(sayi1, sayi2);
            MessageBox.Show(Convert.ToString(sonuc));

        }


        /*ÖRNEK3-Parametre olarak almýþ oldugu bir dizinin en küçük 
         degerini bulan ve bu degeri geri gönderen bir fonk. yazýnýz
        kullanýnýz?

        parametre olarak gönderilecek dizi elemanlarý
        kullanýcdan alýnan 2 deger arasýnda rastgele olarak yine
        kullanýcýnýn girmiþ oldugu deger kadardýr

        dizi elemanlarýný bir listbox a yazdýrýn
         */

        public int fnk_dizi_ek(int[] dizi)
        {
            int enkucukdeðer = dizi[0];
            for (int i = 0; i < dizi.Length; i++)
            {
                if (enkucukdeðer > dizi[i])
                {
                    enkucukdeðer = dizi[i];
                }

            }
            return enkucukdeðer;

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (t1.Text != "" && t2.Text != "" && t3.Text != "")
            {
                int sayi1 = Convert.ToInt32(t1.Text);
                int sayi2 = Convert.ToInt32(t2.Text);
                int boyut = Convert.ToInt32(t3.Text);

                int kucuksayi = 0;
                int buyuksayi = 0;

                if (sayi1 < sayi2)
                {
                    kucuksayi = sayi1;
                    buyuksayi = sayi2;
                }
                else
                {
                    kucuksayi = sayi2;
                    buyuksayi = sayi1;
                }
                int[] dizi = new int[boyut];
                Random rnd = new Random();
                lb1.Items.Clear();
                for (int i = 0; i < boyut; i++)
                {
                    dizi[i] = rnd.Next((kucuksayi + 1), buyuksayi);
                    lb1.Items.Add(dizi[i]);
                }
                int enk = fnk_dizi_ek(dizi);
                t4.Text = Convert.ToString(enk);

            }
            else
            {
                MessageBox.Show("eksik deðer girildi.");
            }
        }
        /*Örnek4-((2x)!+3y)/(zmod t) fonksiyon seklinde yaz*/

        public bool fnk_kontrol(string a)
        {
            bool sonuc = false;
            if (a != "")
            {
                sonuc = true;
            }
            return sonuc;

        }

        public double fnk_toplam(double a, double b)
        {
            return a * b;
        }
        public double fnk_faktoriyel(double a)
        {
            double fact = 1;
            for (double i = 1; i <= a; i++)
            {
                fact *= i;

            }
            return fact;
        }

        public double fnk_carp(double a, double b)
        {
            return a * b;
        }
        public double fnk_mod(double a, double b)
        {
            return a % b;
        }
        public double fnk_bol(double a, double b)
        {
            return a / b;

        }
        public void fnk_mesaj_parametreli(string a)
        {
            MessageBox.Show(a);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (fnk_kontrol(xtxt.Text) && fnk_kontrol(ytxt.Text) && fnk_kontrol(ztxt.Text) && fnk_kontrol(ttxt.Text))
            {
                double x = Convert.ToDouble(xtxt.Text);
                double y = Convert.ToDouble(ytxt.Text);
                double z = Convert.ToDouble(ztxt.Text);
                double t = Convert.ToDouble(ttxt.Text);

                double pay = fnk_toplam(fnk_faktoriyel(fnk_carp(2, x)), fnk_carp(3, y));
                double payda = fnk_mod(z, t);
                double sonuc = fnk_bol(pay, payda);
                fnk_mesaj_parametreli("sonuc:" + sonuc);
            }
            else
            {
                fnk_mesaj_parametreli("eksik deðer");
            }
        }
        /*Örnek5-Parametre olarak almýþ oldugu sayýnýn tek mi çift mi oldugunu
      bulan ve sonucu geri gönderen bir fonk. yazýnýz ve kullanýnýz?*/

        public string fnk_cifttek(int a)
        {
            if (fnk_mod(a, 2) == 0)
            {
                return "çift";
            }
            else
            {
                return "tek";
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {

            int deger = Convert.ToInt32(txtct.Text);
            string sonuc = fnk_cifttek(deger);
            fnk_mesaj_parametreli(sonuc);

        }
        /*Örnek6 -Kullanýcnýn girmiþ oldugu 2 deger arasýnda rastgele sayýlardan oluþan 10 elemanlý 
 bir dizi oluþturun e dizi elemanlarýný toplayýn*/
        private void button6_Click(object sender, EventArgs e)
        {
            if (fnk_kontrol(tb1.Text) && fnk_kontrol(tb2.Text))
            {
                Random rnd = new Random();
                int[] dizi = new int[10];
                int tpl = 0;
                for (int i = 0; i < dizi.Length; i++)
                {
                    int rastgelesayi = rnd.Next((Convert.ToInt32(tb1.Text)), Convert.ToInt32(tb2.Text));
                    dizi[i] = rastgelesayi;
                    tpl = tpl + dizi[i];
                    lb3.Items.Add(dizi[i]);
                }
                MessageBox.Show("toplamý:" + tpl);

            }
            else
            {
                fnk_mesaj_parametreli("eksik");
            }
        }

        /*ÖRNEK7-Kullanýcýnýn girmiþ oldugu 2 deger arasýnda çift elemanlardan oluþan bir dizi oluþturun
        elemanlarýný gösterin? eleman sayýsýný yine kullanýcýdan alalým */

        private void button7_Click(object sender, EventArgs e)
        {
            if (txto1.Text != "" && txto2.Text != "" && txto3.Text != "")
            {
                int sayi1 = Convert.ToInt32(txto1.Text);
                int sayi2 = Convert.ToInt32(txto2.Text);
                int boyut = Convert.ToInt32(txto3.Text);
                int ksayi = 0;
                int bsayi = 0;

                if (sayi1 < sayi2)
                {
                    ksayi = sayi1;
                    bsayi = sayi2;
                }
                else
                {
                    bsayi = sayi1;
                    ksayi = sayi2;
                }

                int[] dizi = new int[boyut];
                Random rnd = new Random();
                for (int i = 0; i < dizi.Length; i++)
                {
                    int sayi = rnd.Next((ksayi + 1), bsayi);
                    if (sayi % 2 == 0)
                    {
                        dizi[i] = sayi;
                        lbo1.Items.Add(dizi[i]);

                    }
                    else
                    {
                        i--;
                    }
                }

            }
            else
            {
                MessageBox.Show("eksik deðer giriniz");
            }

        }
        /*ÖRNEK8-Kullanýcýnýn girmiþ olduðu 2 degerler arasýnda rastgele yine kullanýcýnýn girmiþ oldugu deger
        kadar çift sayýlardan oluþan dizinin en küçük degerini bulan programý yazýnýz dizi elemanlarýný gösteriniz?*/


        private void button8_Click(object sender, EventArgs e)
        {
            if (txto4.Text != "" && txto5.Text != "" && txto6.Text != "")
            {
                int sayi1 = Convert.ToInt32(txto4.Text);
                int sayi2 = Convert.ToInt32(txto5.Text);
                int boyut = Convert.ToInt32(txto6.Text);

                int ksayi = 0;
                int bsayi = 0;
                if (sayi1 < sayi2)
                {
                    ksayi = sayi1;
                    bsayi = sayi2;
                }
                else
                {
                    ksayi = sayi2;
                    bsayi = sayi1;
                }

                int[] dizi = new int[boyut];
                Random rnd = new Random();
                lbo8.Items.Clear();
                for (int i = 0; i < dizi.Length; i++)
                {
                    int dizisayi = rnd.Next((ksayi + 1), bsayi);
                    if (dizisayi % 2 == 0)
                    {
                        dizi[i] = dizisayi;
                        lbo8.Items.Add(dizi[i]);
                    }
                    else
                    {
                        i--;
                    }

                }
                int enkucukdizisayisi = dizi[0];
                for (int j = 0; j < dizi.Length; j++)
                {
                    if (enkucukdizisayisi > dizi[j])
                    {
                        enkucukdizisayisi = dizi[j];
                    }

                }
                MessageBox.Show("dizinin en kucuk elemaný:" + enkucukdizisayisi);


            }
            else
            {
                MessageBox.Show("ekisk");
            }

        }

        /* ÖRNEK9-Kullanýcýnýn girmiþ olduðu 2 degerler arasýnda rastgele yine 
         kullanýcýnýn girmiþ oldugu deger kadar  tek sayýlardan oluþan dizinin
         elemanlarýnýn ortalamasýný bulan program?*/


        private void button9_Click(object sender, EventArgs e)
        {
            if (txto7.Text != "" && txto8.Text != "" && txto9.Text != "")
            {
                int sayi1 = Convert.ToInt32(txto7.Text);
                int sayi2 = Convert.ToInt32(txto8.Text);
                int boyut = Convert.ToInt32(txto9.Text);

                int ksayi = 0;
                int bsayi = 0;

                if (sayi1 > sayi2)
                {
                    bsayi = sayi1;
                    ksayi = sayi2;
                }
                else
                {
                    bsayi = sayi2;
                    ksayi = sayi1;
                }
                double sayac = 0;
                double tpl = 0;
                int[] dizi = new int[boyut];
                Random rnd = new Random();

                for (int i = 0; i < dizi.Length; i++)
                {
                    int rsayi = rnd.Next((ksayi + 1), bsayi);
                    if (rsayi % 2 == 1)
                    {
                        dizi[i] = rsayi;
                        tpl = tpl + dizi[i];
                        lbo3.Items.Add(dizi[i]);

                    }
                    else
                    {
                        i = i - 1;
                    }

                }
                double ortalama = tpl / Convert.ToDouble(dizi.Length);
                txto10.Text = Convert.ToString(ortalama);

            }
            else
            {
                MessageBox.Show("eksik deðer girdiniz");
            }

        }

        /*ÖRNEK10-Kullanýcýnýn girmiþ olduðu 2 degerler arasýnda rastgele yine 
           * kullanýcýnýn girmiþ oldugu deger kadar tekrarlamayan tek sayýlardan oluþan 
           * bir dizi oluþturun ve elemanlarýný gösteriniz*/

        private void button10_Click(object sender, EventArgs e)
        {
            if (txto11.Text != "" && txto12.Text != "" && txto13.Text != "")
            {
                int sayi1 = Convert.ToInt32(txto11.Text);
                int sayi2 = Convert.ToInt32(txto12.Text);
                int boyut = Convert.ToInt32(txto13.Text);

                int ksayi = 0;
                int bsayi = 0;

                if (sayi1 < sayi2)
                {
                    ksayi = sayi1;
                    bsayi = sayi2;
                }
                else
                {
                    ksayi = sayi2;
                    bsayi = sayi1;
                }

                int[] dizi = new int[boyut];
                Random rnd = new Random();
                int kontrol = 0;
                lbo5.Items.Clear();
                for (int i = 0; i < dizi.Length; i++)
                {
                    int dizisayisi = rnd.Next((ksayi + 1), bsayi);
                    if (dizisayisi % 2 == 1)
                    {
                        for (int j = 0; j < i; j++)
                        {
                            if (dizi[j] == dizisayisi)
                            {
                                kontrol = 1;
                            }
                        }
                        if (kontrol == 1)
                        {
                            i = i - 1;
                            kontrol = 0;
                        }
                        else
                        {
                            dizi[i] = dizisayisi;
                            lbo5.Items.Add(dizi[i]);
                        }

                    }
                    else
                    {
                        i = i - 1;
                    }
                }

            }
            else
            {
                MessageBox.Show("eksik deðer girdiniz");
            }

        }
        /*ÖRNEK11-parametre olarak alýnan bir dizi içerisinde
            parametre olarak alýnan bir degerin olup olmadýðýný
            linear search algoritmasý ile bulan ve sonucu geri gönderen bir fonksiyon yazýnýz?
            {1,3,5,6,8} aranacak deger->6 */

        public bool linear_search(int[] a, int aranacak_deger)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (aranacak_deger == a[i])
                {
                    return true;
                }
            }
            return false;
        }
        private void button11_Click(object sender, EventArgs e)
        {
            int[] dizimiz = { 2, 5, 8, 9, 10, 11, 12, 13, 14, };
            bool sonuc = linear_search(dizimiz, 2);
            MessageBox.Show(sonuc.ToString());


        }
        /* ÖRNEK 12-parametre olarak almýþ olduðu iki diziden elemanlarýndan en büyük deðeri bulan ve 
         * deðeri geri gönderen fonk yazýnýz ve kullanýnýz.*/

        public int fnk_dizi_eb(int[] dizi1, int[] dizi2)
        {
            int enbuyukdeðer = dizi1[0];
            for (int i = 0; i < dizi1.Length; i++)
            {
                if (enbuyukdeðer < dizi1[i])
                {
                    enbuyukdeðer = dizi1[i];
                }

            }
            return enbuyukdeðer;

            for (int j = 0; j < dizi2.Length; j++)
            {
                if (dizi2[j] > enbuyukdeðer)
                {
                    enbuyukdeðer = dizi2[j];
                }
            }
            return enbuyukdeðer;


        }
        private void button12_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txto14.Text);
            int sayi2 = Convert.ToInt32(txto15.Text);
            int boyut = Convert.ToInt32(txto16.Text);

            int[] dizi1 = new int[boyut];
            int[] dizi2 = new int[boyut];
            Random rnd = new Random();

            for (int i = 0; i < dizi1.Length; i++)
            {
                dizi1[i] = rnd.Next(sayi1, sayi2);
                lbo8.Items.Add(dizi1[i]);

                dizi2[i] = rnd.Next(sayi1, sayi2);
                lbo9.Items.Add(dizi2[i]);
            }
            int sonuc = fnk_dizi_eb(dizi1, dizi2);
            txto17.Text = (sonuc.ToString());
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        /* ÖRNEK 13-Parametre olarak almýþ olduðu bir diziyi küçükten büyüðe sýralayýn. 
       * yürütme zamaný fonksiyonunu hesaplayýnýz.*/

        public int[] fnk_sirala(int[] dizi)
        {
            int min;
            int temp;
            for (int i = 0; i < dizi.Length; i++)
            {
                min = i;
                for (int j = i; j < dizi.Length; j++)
                {
                    if (dizi[min] > dizi[j])
                    {
                        min = j;
                    }
                }
                temp = dizi[i];
                dizi[i] = dizi[min];
                dizi[min] = temp;
            }
            return dizi;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txto18.Text);
            int sayi2 = Convert.ToInt32(txto19.Text);
            int boyut = Convert.ToInt32(txto20.Text);

            int[] dizi = new int[boyut];
            Random rnd = new Random();

            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rnd.Next((sayi1 + 1), sayi2);
                lbo10.Items.Add(dizi[i]);
            }

            int[] dizisirali = new int[boyut];
            dizisirali = fnk_sirala(dizi);

            for (int j = 0; j < boyut; j++)
            {
                lb11.Items.Add(dizisirali[j]);
            }


        }
        /*ÖRNEK14-Parametre olarak almýþ olduðu iki dizi elemanlarýnda en büyük deðeri bulan 
* ve deðeri geri gönderen bir fonk. yazýnýz ve kullanýnýz.*/

        public int fnk_dizi_ebbul(int[] dizi1, int[] dizi2)
        {
            int enbuyuk = dizi1[0];
            for (int i = 0; i < dizi1.Length; i++)
            {
                if (dizi1[i] > enbuyuk)
                {
                    enbuyuk = dizi1[i];
                }


            }
            for (int j = 0; j < dizi2.Length; j++)
            {
                if (dizi2[j] > enbuyuk)
                {
                    enbuyuk = dizi2[j];
                }
            }
            return enbuyuk;

        }
        private void button14_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txto21.Text);
            int sayi2 = Convert.ToInt32(txto22.Text);
            int boyut = Convert.ToInt32(txto23.Text);

            int[] dizia = new int[boyut];
            int[] dizib = new int[boyut];

            Random rnd = new Random();

            lb12.Items.Clear();
            lb13.Items.Clear();

            for (int i = 0; i < boyut; i++)
            {
                dizia[i] = rnd.Next((sayi1 + 1), sayi2);
                lb12.Items.Add(dizia[i]);

                dizib[i] = rnd.Next((sayi1 + 1), sayi2);
                lb13.Items.Add(dizib[i]);
            }
            int sonuc = fnk_dizi_ebbul(dizia, dizib);
            txto24.Text = Convert.ToString(sonuc);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                MessageBox.Show("iþaretlendi");
            }
            else
            {
                MessageBox.Show("iþaret kaldýrýldý");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                MessageBox.Show("týklandý");
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (txto25.Text != "")
            {
                if (rd2.Checked == true || rd3.Checked == true)
                {
                    double sayi = Convert.ToDouble(txto25.Text);
                    double sonuc;
                    if (rd2.Checked == true)

                    {
                        sonuc = sayi * 0.18;
                    }
                    else
                    {
                        sonuc = sayi * 0.25;
                    }
                    MessageBox.Show("Sonuç:" + sonuc);
                }
                else
                {
                    MessageBox.Show("Lütfen Bir Seçim Yapýnýz");
                }
            }
            else
            {
                MessageBox.Show("Lütfen Bir Sayý Giriniz");
            }
        }
    }
}







   /* Örnek4-lineer arama yapan bir fonksiyon yazýnýz true/false 

public bool fnk_lineer_search(int[] dizi, int a)
{
    bool arama = false;

    for (int i = 0; i < dizi.Length; i++)
    {
        if (dizi[i] == a)
        {
            arama = true;
        }
    }
    return arama;
}
*/


