using System.Windows.Forms;

namespace _26._12._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {


        }

        public int fnk_diziek(int[] dizi)
        {
            int ek_deger = dizi[0];
            for (int i = 0; i < dizi.Length; i++)
            {
                if (ek_deger > dizi[i])
                {
                    ek_deger = dizi[i];
                }
            }

            return ek_deger;


        }

        private void bas_Click(object sender, EventArgs e)
        {
            if (txt.Text != "" && txt2.Text != "" && txt3.Text != "")
            {

                int sayi1 = Convert.ToInt32(txt.Text);
                int sayi2 = Convert.ToInt32(txt2.Text);
                int deger = Convert.ToInt32(txt3.Text);

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

                int[] dizi = new int[deger];
                Random rnd = new Random();

                list1.Items.Clear();

                for (int i = 0; i < dizi.Length; i++)
                {
                    dizi[i] = rnd.Next((sayik + 1), sayib);
                    list1.Items.Add(dizi[i]);

                }
                int ek = fnk_diziek(dizi);
                snc.Text = Convert.ToString(ek);


            }
            else
            {
                MessageBox.Show("eksik deðer");
            }
        }
    }

    /*lineer arama yapan bir fonk (true/false)*/

    public bool fnk_lineer_search(int[]  dizi,int a)
    {
        bool arama = false;

        for(int i = 0;i < dizi.Length; i++)
        {
            if (dizi[i] == a)
            {
                arama = true;
            }
        }
        return arama;
    }



}
