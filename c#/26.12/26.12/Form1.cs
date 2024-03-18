using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace _26._12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //parametre olarak almış olduğu değerler arasında 5 e bölünen sayıların ortalamasını bulan fonk.
        //geri gönder demiyor.

        public void fnk_ort_5(int a,int b)
        {
            int sayi_k = 0;
            int sayi_b = 0;

            if(a<b)
            {
                sayi_b=b; 
                sayi_k = a;
            }
            else
            {
                sayi_b = a;
                sayi_k = b;
            }
            double toplam = 0;
            double sayac = 0;
            
            for(int i=(sayi_k+1);i<sayi_b;i++)
            {
                if(i%5==0)
                {
                    sayac=sayac+1;
                    toplam= toplam+1;

                }
            }

            double ortalama = toplam / sayac;
        }

        public int fnk_diziek(int[] dizi)
        {
            int ek_deger = dizi[0];
            for(int i=0;i<dizi.Length;i++)
            {
                if (ek_deger > dizi[i])
                {
                    ek_deger= dizi[i];
                }
            }

            return ek_deger;
            
            
            
           /*parametre olarak almış olduğu bir dizinin en küçük değerini bulan ve bu değeri geri gönderen
bir fonk yazınız. parametre olarak gönderilecek dizi elemanları kullanıcıdan alınan 2 deger arasında rastgele olarak yine
kullanıcının girmiş oldugu değer kadardır.
listboxa yazdırınız*/


        private void button1_Click(object sender, EventArgs e)
        {
            if(txt1.Text!="" & txt2.Text!="" )
            {
                
                int sayi1 = Convert.ToInt32(txt1.Text);
                int sayi2=Convert.ToInt32(txt2.Text);

                int sayik = 0;
                int sayib = 0;

                if (sayi1 < sayi2)
                {
                    sayik = sayi1;
                    sayib = sayi2;
                }
                else
                {
                    sayib = sayi1;
                    sayik = sayi2;
                }

                    int[] dizi = new int[boyut];
                    Random rnd= new Random();

                    for(int i = 0; i < dizi.Length; i++)
                    {
                        dizi[i] = rnd.Next((sayik+1),sayib);
                        listBox1.Items.Add(dizi[i]);

                    }
                    int ek = fnk_diziek(dizi);
                    txt3.text=Convert.ToString(ek);

            
            }
            else
            {
                MessageBox.Show("eksik değer");
            }

        }
    }
}


