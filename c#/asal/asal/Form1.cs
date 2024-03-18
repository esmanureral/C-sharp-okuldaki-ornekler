namespace asal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool fnkasal(int sayi)
        {
            if(sayi<2)
            {
                return false;
            }

            for(int i = 2;i<sayi;i++)
            {
                if (sayi % i == 0)
                {
                    return false;
                }
                
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int sayi=Convert.ToInt32(textBox1.Text);
            MessageBox.Show(Convert.ToString(fnkasal(sayi)));

        }
    }
}
