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

        /*�RNEK 1-parametre olarak alm�� oldugu bir degerin fakt�r�yelini hesaplayan
         ve sonucu geri g�nderen bir fonksiyon yaz�n�z ve kullan�n�z*/

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
            MessageBox.Show("say�n�n fakt�riyeli:" + sonuc);
        }


        /*�RNEK2-Parametre olarak alm�� oldu�u degerler aras�ndaki
         * 5'e b�l�nen say�lar�n ortalamas�n� bulan bir fonk. yaz�n�z
         ve kullan�n�z*/
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


        /*�RNEK3-Parametre olarak alm�� oldugu bir dizinin en k���k 
         degerini bulan ve bu degeri geri g�nderen bir fonk. yaz�n�z
        kullan�n�z?

        parametre olarak g�nderilecek dizi elemanlar�
        kullan�cdan al�nan 2 deger aras�nda rastgele olarak yine
        kullan�c�n�n girmi� oldugu deger kadard�r

        dizi elemanlar�n� bir listbox a yazd�r�n
         */

        public int fnk_dizi_ek(int[] dizi)
        {
            int enkucukde�er = dizi[0];
            for (int i = 0; i < dizi.Length; i++)
            {
                if (enkucukde�er > dizi[i])
                {
                    enkucukde�er = dizi[i];
                }

            }
            return enkucukde�er;

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
                MessageBox.Show("eksik de�er girildi.");
            }
        }
        /*�rnek4-((2x)!+3y)/(zmod t) fonksiyon seklinde yaz*/

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
                fnk_mesaj_parametreli("eksik de�er");
            }
        }
        /*�rnek5-Parametre olarak alm�� oldugu say�n�n tek mi �ift mi oldugunu
      bulan ve sonucu geri g�nderen bir fonk. yaz�n�z ve kullan�n�z?*/

        public string fnk_cifttek(int a)
        {
            if (fnk_mod(a, 2) == 0)
            {
                return "�ift";
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
        /*�rnek6 -Kullan�cn�n girmi� oldugu 2 deger aras�nda rastgele say�lardan olu�an 10 elemanl� 
 bir dizi olu�turun e dizi elemanlar�n� toplay�n*/
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
                MessageBox.Show("toplam�:" + tpl);

            }
            else
            {
                fnk_mesaj_parametreli("eksik");
            }
        }

        /*�RNEK7-Kullan�c�n�n girmi� oldugu 2 deger aras�nda �ift elemanlardan olu�an bir dizi olu�turun
        elemanlar�n� g�sterin? eleman say�s�n� yine kullan�c�dan alal�m */

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
                MessageBox.Show("eksik de�er giriniz");
            }

        }
        /*�RNEK8-Kullan�c�n�n girmi� oldu�u 2 degerler aras�nda rastgele yine kullan�c�n�n girmi� oldugu deger
        kadar �ift say�lardan olu�an dizinin en k���k degerini bulan program� yaz�n�z dizi elemanlar�n� g�steriniz?*/


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
                MessageBox.Show("dizinin en kucuk eleman�:" + enkucukdizisayisi);


            }
            else
            {
                MessageBox.Show("ekisk");
            }

        }

        /* �RNEK9-Kullan�c�n�n girmi� oldu�u 2 degerler aras�nda rastgele yine 
         kullan�c�n�n girmi� oldugu deger kadar  tek say�lardan olu�an dizinin
         elemanlar�n�n ortalamas�n� bulan program?*/


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
                MessageBox.Show("eksik de�er girdiniz");
            }

        }

        /*�RNEK10-Kullan�c�n�n girmi� oldu�u 2 degerler aras�nda rastgele yine 
           * kullan�c�n�n girmi� oldugu deger kadar tekrarlamayan tek say�lardan olu�an 
           * bir dizi olu�turun ve elemanlar�n� g�steriniz*/

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
                MessageBox.Show("eksik de�er girdiniz");
            }

        }
        /*�RNEK11-parametre olarak al�nan bir dizi i�erisinde
            parametre olarak al�nan bir degerin olup olmad���n�
            linear search algoritmas� ile bulan ve sonucu geri g�nderen bir fonksiyon yaz�n�z?
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
        /* �RNEK 12-parametre olarak alm�� oldu�u iki diziden elemanlar�ndan en b�y�k de�eri bulan ve 
         * de�eri geri g�nderen fonk yaz�n�z ve kullan�n�z.*/

        public int fnk_dizi_eb(int[] dizi1, int[] dizi2)
        {
            int enbuyukde�er = dizi1[0];
            for (int i = 0; i < dizi1.Length; i++)
            {
                if (enbuyukde�er < dizi1[i])
                {
                    enbuyukde�er = dizi1[i];
                }

            }
            return enbuyukde�er;

            for (int j = 0; j < dizi2.Length; j++)
            {
                if (dizi2[j] > enbuyukde�er)
                {
                    enbuyukde�er = dizi2[j];
                }
            }
            return enbuyukde�er;


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
        /* �RNEK 13-Parametre olarak alm�� oldu�u bir diziyi k���kten b�y��e s�ralay�n. 
       * y�r�tme zaman� fonksiyonunu hesaplay�n�z.*/

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
        /*�RNEK14-Parametre olarak alm�� oldu�u iki dizi elemanlar�nda en b�y�k de�eri bulan 
* ve de�eri geri g�nderen bir fonk. yaz�n�z ve kullan�n�z.*/

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
                MessageBox.Show("i�aretlendi");
            }
            else
            {
                MessageBox.Show("i�aret kald�r�ld�");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                MessageBox.Show("t�kland�");
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
                    MessageBox.Show("Sonu�:" + sonuc);
                }
                else
                {
                    MessageBox.Show("L�tfen Bir Se�im Yap�n�z");
                }
            }
            else
            {
                MessageBox.Show("L�tfen Bir Say� Giriniz");
            }
        }
    }
}







   /* �rnek4-lineer arama yapan bir fonksiyon yaz�n�z true/false 

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


