namespace okulörnekler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);

            int sonuc = fnk_topla(sayi1 + sayi2);
            fnk_mesaj_parametreli(Convert.ToString(sonuc));
        }


        public int fnk_fk(int a)
        {
            int fk = 1;
            for (int i = 1; i <= a; i++)
            {
                fk = fk * i;
            }
            return fk;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int sayi=Convert.ToInt32(textBox4.Text);
            int sonuc=fnk_fk(sayi);
            fnk_mesaj_parametreli(Convert.ToString(sonuc);


        }
        /*parametre olarak <lmış oldugu değeler arasındaki 5 e bölünen sayıların ortalamasını
         * bulan bir fonk.*/



       
    }
}
