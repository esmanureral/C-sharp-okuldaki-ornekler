namespace döngüler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void o1_Click(object sender, EventArgs e)
        {
            int toplam = 0;

            for (int i = 0; i <= 10; i++)
            {
                toplam = toplam + i;

            }
            MessageBox.Show("sonuc:" + toplam);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_02.Text != "")
            {
                int sayi = Convert.ToInt32(txt_02.Text);
                int toplam = 0;
                for (int i = 0; i < sayi; i++)
                {
                    toplam = toplam + i;
                }
                MessageBox.Show("" + toplam);
            }
            else
            {
                MessageBox.Show("değer gir");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((sayi_1.Text != "") && (sayi_2.Text != "");
            {
                
            }
            else
            {
                MessageBox.Show("değer girin");

            }
            
        }
    }
}


    /*1-başlangıç
     * 2-toplam=0 sayaç=0
     * 3-toplam=toplam+sayaç
     * 3-sayaç=sayaç+1
     * 4-eğer sayac<11 ise 3.adıma dön
     * 5-toplamı yazdır
     * 6-bitir
    */
