using System.ComponentModel;

namespace uygulama1
{

    public partial class Form1 : Form
    {
        int sayi;


        public Form1()
        {
            InitializeComponent();
        }
        /* �RNEK1 - Kullan�c�n�n girmi� oldu�u de�erin tek mi �ift mi oldu�unu bulunuz.*/
        private void button1_Click(object sender, EventArgs e)
        {
            if (txt1.Text != "")
            {
                int sayi1 = Convert.ToInt32(txt1.Text);
                if (sayi1 % 2 == 0)
                {
                    MessageBox.Show("Girilen say� �ift");

                }
                else
                {
                    MessageBox.Show("girilen say� tektir");
                }

            }
            else
            {
                MessageBox.Show("eksik de�er girdiniz:");
            }
        }

        /*�RNEK 2 - 0 ile kullan�c�n�n girmi� oldu�u de�er aras�ndaki say�lar�n toplam�n� bul ve yazd�r.*/


        private void button2_Click(object sender, EventArgs e)
        {
            if (txt2.Text != "")
            {
                int sayi = Convert.ToInt32(txt2.Text);
                int tpl = 0;

                for (int i = 0; i < sayi; i++)
                {
                    tpl = tpl + i;
                }
                MessageBox.Show("sonuc:" + tpl);

            }
            else
            {
                MessageBox.Show("eksik bilgi girildi");
            }

        }
        /*�RNEK 3 - Kullan�c�n�n girmi� oldu�u iki de�er aras�ndaki toplam*/
        private void button3_Click(object sender, EventArgs e)
        {
            if (txt3.Text != "" && txt4.Text != "")
            {
                int sayi1 = Convert.ToInt32(txt3.Text);
                int sayi2 = Convert.ToInt32(txt4.Text);
                int ksayi = 0;
                int bsayi = 0;
                int tpl = 0;

                if (sayi1 < sayi2)
                {
                    sayi1 = ksayi;
                    sayi2 = bsayi;

                }
                else
                {
                    sayi2 = ksayi;
                    sayi1 = bsayi;

                }


                for (int i = (ksayi + 1); i < bsayi; i++)
                {
                    tpl = tpl + i;
                }
                MessageBox.Show("sonuc:" + tpl);

            }
            else
            {
                MessageBox.Show("Eksik bilgi girdiniz");
            }

        }
        /*�RNEK 4 - Kullan�c�n�n girmi� oldu�u de�erler aras�nda ka� tane �ift say� oldu�unu bul ve
         * textbox a yazd�r*/


        private void button4_Click(object sender, EventArgs e)
        {
            if (txt5.Text != "" && txt6.Text != "")
            {
                int sayi1 = Convert.ToInt32(txt5.Text);
                int sayi2 = Convert.ToInt32(txt6.Text);
                int ksayi = 0;
                int bsayi = 0;
                int sayac = 0;
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
                for (int i = (ksayi + 1); i < bsayi; i++)
                {
                    if (i % 2 == 0)
                    {
                        sayac = sayac + 1;
                    }
                }
                txt7.Text = Convert.ToString(sayac);
            }
            else
            {
                MessageBox.Show("eksik de�er girdiniz!");
            }
        }

        /* �RNEK 5-  /*Say� Tahmin Oyunu
     Kullan�c� program�n tutmu� oldu�u say�y� tahmin etmeye �al��acak  program kullan�c�y� daha y�ksek bir
    say� girin veya daha k���k bir say� girin �eklinde y�netecek. Kullan�c� say�y� dogru tahmin
    etti�inde tebrikler kazand�n�z diyecek (0-100 aras�nda)
     */
        private void Form1_Load(object sender, EventArgs e)
        {

            Random r2 = new Random();
            sayi = r2.Next(100);
        }
        private void button5_Click(object sender, EventArgs e)
        {



            if (txt8.Text != "")
            {

                int tahmin = Convert.ToInt32(txt8.Text);

                if (sayi < tahmin)
                {
                    MessageBox.Show("k���k girin");
                }
                else if (sayi > tahmin)
                {
                    MessageBox.Show("b�y�k girin");

                }
                else
                {
                    MessageBox.Show("bildiniz!");

                }

            }
            else
            {
                MessageBox.Show("eksik bilgi girildi.");
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {


        }
        private void txt9_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt12_TextChanged(object sender, EventArgs e)
        {

        }

        /*�RNEK 6 - /*Kullan�c�n�n girmi� oldu�u 2 deger aras�nda 5' e b�l�nen say�lar�n ortalamas�n� bulan program�
        while d�ng�s� ile hesaplay�n�z ve mesaj olarak veriniz?*/

        private void button6_Click_1(object sender, EventArgs e)

        {
            if (txt10.Text != "" && txt11.Text != "")
            {
                int sayi1 = Convert.ToInt32(txt10.Text);
                int sayi2 = Convert.ToInt32(txt11.Text);
                int sayac = 0;
                int tpl = 0;
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
                ksayi = ksayi + 1;
                while (ksayi < bsayi)
                {
                    if (ksayi % 5 == 0)
                    {

                        tpl = tpl + ksayi;
                        sayac = sayac + 1;

                    }
                    ksayi++;
                }
                double ortalama = tpl / sayac;
                MessageBox.Show("ortalama:" + ortalama);



            }
            else
            {
                MessageBox.Show("eksik bilgi girildi");
            }
        }
        /*�RNEK 7- 1 ile 100 aras� rastgele elemanlardan olu�an 5 elemanl� bir dizi olu�turun
         * dizi elemanlar�n� mesaj olarak yazd�r�n?*/

        private void button7_Click(object sender, EventArgs e)
        {
            int[] dizi = new int[5];
            Random rnd = new Random();

            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rnd.Next(0, 5);
            }
            for (int j = 0; j < dizi.Length; j++)
            {

                txt13.Text = Convert.ToString(dizi[j]);
            }

        }
        /*�RNEK8-kullan�c�n�n girmi� oldugu degerler aras�nda 
            yine kullan�c�n�n girmi� oldugu deger kadar
            rastgele elemanlardan olu�an bir dizi olu�turun?*/

        private void bas_Click(object sender, EventArgs e)
        {
            if (txt14.Text != "" && txt15.Text != "" && txt16.Text != "")
            {
                int sayi1 = Convert.ToInt32(txt14.Text);
                int sayi2 = Convert.ToInt32(txt15.Text);
                int boyut = Convert.ToInt32(txt16.Text);

                int ksayi = 0;
                int bsayi = 0;

                int[] dizi = new int[boyut];
                Random rnd = new Random();

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
                dizibox.Items.Clear();

                for (int i = 0; i < boyut; i++)
                {
                    dizi[i] = rnd.Next((ksayi + 1), bsayi);
                    dizibox.Items.Add(dizi[i]);
                }

            }
            else
            {
                MessageBox.Show("EKS�K");
            }
        }
        /*�RNEK 9 - Kullan�c�n�n girmi� oldugu degerler aras�nda yine kullan�c�n�n girmi� oldugu deger kadar
          rastgele �ift elemanlardan olu�an dizinin ortalamas�n� bulan program� yaz�n�z? dizi elemanlar� listbox'da 
          listelenecek. Sonu� bir textbox' a yazd�r�lacak*/


        private void button8_Click(object sender, EventArgs e)
        {
            if (txt17.Text != "" && txt18.Text != "" && txt19.Text != "")
            {
                int sayi1 = Convert.ToInt32(txt17.Text);
                int sayi2 = Convert.ToInt32(txt18.Text);
                int boyut = Convert.ToInt32(txt19.Text);
                int ksayi = 0;
                int bsayi = 0;
                int[] dizi = new int[boyut];

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
                double toplam = 0;
                Random rnd = new Random();
                listBox1.Items.Clear();

                for (int i = 0; i < boyut; i++)
                {

                    int rsayi = rnd.Next((ksayi + 1), bsayi);
                    if (rsayi % 2 == 0)
                    {
                        dizi[i] = rsayi;
                        toplam = toplam + dizi[i];
                        listBox1.Items.Add(dizi[i]);
                    }
                    else
                    {
                        i = i - 1;
                    }
                }

                double ortalama = toplam / boyut;
                txt20.Text = Convert.ToString(ortalama);


            }
            else
            {
                MessageBox.Show("eksik de�er girildi.");

            }
        }
        /*�RNEK 10 -Kullan�c�n�n girmi� oldugu degerler aras�nda yine kullan�c�n�n girmi� oldugu deger kadar
 rastgele �ift elemanlardan olu�an dizinin ortalamas�n� bulan program� yaz�n�z? dizi elemanlar� listbox'da 
listelenecek. Sonu� bir textbox' a yazd�r�lacak*/

        private void button9_Click(object sender, EventArgs e)
        {
            if (txt21.Text != "" && txt22.Text != "" && txt23.Text != "")
            {
                int sayi1 = Convert.ToInt32(txt21.Text);
                int sayi2 = Convert.ToInt32(txt22.Text);
                int boyut = Convert.ToInt32(txt23.Text);

                int[] dizi = new int[boyut];
                Random rnd = new Random();

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

                int varmi = 0;
                listBox2.Items.Clear();
                double toplam = 0;

                for (int i = 0; i < boyut; i++)
                {
                    int rastgelesayi = rnd.Next((ksayi + 1), bsayi);
                    for (int j = 0; j < i; j++)
                    {
                        if (dizi[j] == rastgelesayi)
                        {
                            varmi = 1;
                        }

                    }
                    if (varmi == 0)
                    {
                        dizi[i] = rastgelesayi;
                        listBox2.Items.Add(dizi[i]);
                        toplam = toplam + dizi[i];
                    }
                    else
                    {
                        i = i - 1;
                        varmi = 0;
                    }
                }
                double ortalama = toplam / boyut;
                txt24.Text = Convert.ToString(ortalama);


            }
            else
            {
                MessageBox.Show("Eksik bilgi girildi");
            }



        }
        /*�RNEK 11- (2*x+3*y)/(z mod t)*/

        private void button10_Click(object sender, EventArgs e)
        {
            if (txtx.Text != "" && txty.Text != "" && txtz.Text != "" && txtt.Text != "")
            {
                double z = Convert.ToDouble(txtz.Text);
                double t = Convert.ToDouble(txtt.Text);

                double payda = z % t;
                if (payda == 0)
                {
                    MessageBox.Show("de�erler payday� s�f�r yapt� hata");
                }
                else
                {
                    double x = Convert.ToDouble(txtx.Text);
                    double y = Convert.ToDouble(txty.Text);

                    double pay = (2 * x) + (3 * y);

                    double sonuc = pay / payda;
                    txtsnc.Text = Convert.ToString(sonuc);
                }

            }
            else
            {
                MessageBox.Show("Eksik veri giri�i");
            }
        }
        /*�RNEK- 12 - Kullan�c�n�n girdi�i say�n�n fakt�riyelini alma for ile)*/

        private void button11_Click(object sender, EventArgs e)
        {
            if (txtfact.Text != "")
            {
                int sayi = Convert.ToInt32(txtfact.Text);
                int fact = 1;

                if (sayi < 0)
                {
                    MessageBox.Show("fakt�riyel negatif say�larda hesaplanamaz.");
                }
                else
                {
                    for (int i = 1; i < sayi; i++)
                    {
                        fact = fact * i;

                    }
                    MessageBox.Show("say�n�n fakt�riyeli:" + fact);
                }

            }
            else
            {
                MessageBox.Show("eksik bilgi giri�i");
            }
        }
        /*�RNEK- 13 - Kullan�c�n�n girdi�i say�n�n fakt�riyelini alma while ile)*/

        private void button12_Click(object sender, EventArgs e)
        {
            if (txtfact2.Text != "")
            {
                int sayi = Convert.ToInt32(txtfact2.Text);
                int fact = 1;
                while (sayi > 0)
                {
                    fact = fact * sayi;
                    sayi = sayi - 1;
                }

                MessageBox.Show("fakt�riyeli:" + fact);

            }
            else
            {
                MessageBox.Show("eksik bilgi giri�i");
            }

























        }
        /*�RNEK- 14 - Kullan�c�n�n girdi�i iki de�er aras�ndaki say�lar�n
         *harmonik ortalamas�n� bulan program� yaz�n�z.*/


        private void button13_Click(object sender, EventArgs e)
        {

        }

        //parametre olrak alm�� oldugu 2 degeri toplayan ve sonucu geri g�nedren bir fonk.

        public int fnk_toplam(int a, int b)
        {
            int toplam = a + b;
            return toplam;
        }
    }
}

        /*�RNEK 15- parametre olarak alm�� oldu�u bir de�erin fakt�riyelini hesaplay�n ve sonucu
         * geri g�nderen bir fonksiyon yaz�n�z ve kullan�n�z.

        public int fnk_faktoriyel(int a)
        {
            int fk = 1;
            for (int i = 1; i <= a; i++)
            {
                fk = fk * i;
            }
            return fk;
        }

        private void fakt_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(txt_fk.Text);
            int sonuc = fnk_faktoriyel(sayi);
            MessageBox.Show("fakt�riyel:" + sonuc);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txts1.Text);
            int sayi2 = Convert.ToInt32(txts2.Text);

            int sonuc=fnk_ort_5(sayi1,sayi2);
            MessageBox.Show("sonuc:" + sonuc);



        }
    }
    /* Parametre olarak alm�� oldu�u degerler aras�ndaki
        * 5'e b�l�nen say�lar�n ortalamas�n� bulan bir fonk. yaz�n�z
        ve kullan�n�z

    public void fnk_ort_5(int a, int b)
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
    }
    */

