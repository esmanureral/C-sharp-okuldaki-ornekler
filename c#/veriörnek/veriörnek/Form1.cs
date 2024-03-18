using System.Diagnostics.Eventing.Reader;

namespace veriörnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*Kullanıcının girmiş olduğu değerler arasında yine kullanıcının girmiş olduğu değer kadar 
rastgele tekrarsız tek sayılardan oluşan bir dizinin en küçük elemanını bulan programın 
kodlarını yazınız?*/

        public int fnkek(int[] dizi)
        {
            int enk = dizi[0];
            for(int i = 1;i< dizi.Length; i++)
            {
                if (dizi[i] < enk)
                {
                    enk = dizi[i];
                }
            }
            return enk;
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (txt1.Text != "" && txt2.Text != "" && txt3.Text != "")
            {
                int sayi1 = Convert.ToInt32(txt1.Text);
                int sayi2 = Convert.ToInt32(txt2.Text);
                int boyut = Convert.ToInt32(txt3.Text);

                int[] dizi = new int[boyut];
                Random rnd = new Random();
                int sayi_b = 0;
                int sayi_k = 0;

                if (sayi1 < sayi2)
                {
                    sayi_k = sayi1;
                    sayi_b = sayi2;
                }
                else
                {
                    sayi_k = sayi2;
                    sayi_b = sayi1;
                }

                int varmi = 0;
                listBox1.Items.Clear();
                for (int i = 0; i < boyut; i++)
                {
                    int rasgele_sayi = rnd.Next((sayi_k + 1), sayi_b);
                    if (rasgele_sayi % 2 != 0)
                    {
                        dizi[i] = rasgele_sayi;
                    }
                    for (int j = 0; j < i; j++)//linear search
                    {
                        if (dizi[j] == rasgele_sayi)
                        {
                            varmi = 1;
                        }
                    }

                    if (varmi == 0)
                    {
                        dizi[i] = rasgele_sayi;
                        listBox1.Items.Add(dizi[i]);
                    }
                    else
                    {
                        i = i - 1;
                        varmi = 0;
                    }

                }
               txt4.Text=Convert.ToString( fnkek(dizi));
               

            }
            else
            {
                MessageBox.Show("Eksik bilgi girildi");
            }
        }
    }
}