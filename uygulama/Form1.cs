namespace uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void kodOlustur()
        {
            Random random = new Random();
            int sayi = random.Next(1000, 10000);
            tbKod.Text = sayi.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kodOlustur();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            StreamReader oku = new StreamReader("C:\\Users\\asude\\OneDrive\\Masa�st�\\Kullan�c� Bilgileri.txt");

            while (oku.EndOfStream == false)
            {
                string[] satir = oku.ReadLine().Split('-');

                if (satir[1] == tbTC.Text)
                {
                    if (satir[2] == tbSifre.Text)
                    {
                        if (tbGirilenKod.Text == tbKod.Text)
                        {
                            Form2 form2 = new Form2();
                            form2.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Yanl�� TC Kimlik NO veya �ifre giriniz!", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        }

        private void btnYonetici_Click(object sender, EventArgs e)
        {
            StreamReader oku = new StreamReader("C:\\Users\\asude\\OneDrive\\Masa�st�\\Y�netici Bilgisi.txt");

            while (oku.EndOfStream == false)
            {
                string[] satir = oku.ReadLine().Split('-');

                if (satir[1] == tbTC.Text)
                {
                    if (satir[2] == tbSifre.Text)
                    {
                        if (tbGirilenKod.Text == tbKod.Text)
                        {
                            Form3 form3 = new Form3();
                            form3.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Yanl�� TC Kimlik NO veya �ifre giriniz!", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        }

        private void linkKayitOlustur_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }
    }
}
