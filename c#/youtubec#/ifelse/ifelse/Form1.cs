namespace ifelse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(txt_o1.Text);
            double sayi2 = Convert.ToDouble(txt_o2.Text);
            if (sayi1 < sayi2)
            {
                MessageBox.Show(+sayi2);
            }
    }
}
}
