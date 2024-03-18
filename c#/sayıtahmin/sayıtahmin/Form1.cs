namespace sayıtahmin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Sayı Tahmin Oyunu yapmanızı istiyorum
            /*
             Kullanıcı programın tutmuş olduğu sayıyı tahmin etmeye çalışacak
            program kullanıcıyı daha yüksek bir sayı girin veya daha küçük 
            bir sayı girin şeklinde yönetecek. Kullanıcı sayıyı dogru tahmin
            ettiğinde tebrikler kazandınız diyecek (0-100 arasında)
             */

            Random rnd = new Random();

            int sayi = rnd.Next(0, 100);

            if (txt_o10.Text != "")
            {

                int tahmin = Convert.ToInt32(txt_o10.Text);

                if (sayi < tahmin)
                {
                    MessageBox.Show("Lütfen küçük bir sayı girin");
                }
                else if (sayi > tahmin)
                {
                    MessageBox.Show("Lütfen büyük bir sayı girin");
                }
                else
                {
                    MessageBox.Show("Tebrikler");
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir sayı giriniz");
            }
            
        }
    }
    }

