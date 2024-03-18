namespace örnekokul2
{
    public partial class Form1 : Form
    {
        int sayi3;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((txt_o1.Text == "") || (txt_o2.Text == ""))
            {
                MessageBox.Show("eksik bilgi girildi");
            }


            else
            {
                int sayi1 = Convert.ToInt32(txt_o1.Text);
                int sayi2 = Convert.ToInt32(txt_o2.Text);

                int sayi_kucuk = 0;
                int sayi_buyuk = 0;

                if (sayi1 < sayi2)
                {
                    sayi_kucuk = sayi1;
                    sayi_buyuk = sayi2;
                }
                else
                {
                    sayi_kucuk = sayi2;
                    sayi_buyuk = sayi1;
                }

                int sayac = 0;
                for (int i = (sayi_kucuk + 1); i < sayi_buyuk; i = i + 1)
                {
                    if (i % 2 == 0)
                    {
                        sayac = sayac + 1;
                    }


                    txt_o3.Text = Convert.ToString(sayac);
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            int rastgele_sayi = rnd.Next(50, 100);//ilki dahil ikincisi dahil değil
            MessageBox.Show(Convert.ToString(rastgele_sayi));
        }

        private void button3_Click(object sender, EventArgs e)
        {


            if (txt_o3.Text != "")
            {

            }
            else
            {
                MessageBox.Show("sayı girin:");
            }
            

           
            int sayi3 = Convert.ToInt32(txt_o3.Text);



            if (rastgele_sayi < sayi3)
                {
                    MessageBox.Show("daha küçük bir sayı giriniz.");
                }
            else if
                {
                    MessageBox.Show("daha büyük bir sayı giriniz:");
                }
            }
        }
    }

//sayı tahmin oyunu 
//kullanıcı programın tutmuş olduğu sayıyı tahmin etsin.
