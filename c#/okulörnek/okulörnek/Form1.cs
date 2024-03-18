namespace okulörnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(txt_o1.Text);
            double sayi2 = Convert.ToDouble(txt_o2.Text);
            double toplam = sayi1 + sayi2;
            txt_o3.Text = Convert.ToString(toplam);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double sayi1=Convert.ToDouble(txt_o1.Text);
            double sayi2=Convert.ToDouble(txt_o2.Text);
            double sonuç=sayi1 - sayi2;
            txt_o3.Text=Convert.ToString(sonuç);
        }
    }
}
