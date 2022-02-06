using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Otobüsrojesi
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        //diger formlardan ulasmak ıcın tanımlandı
        static public int id;
        int zaman = 30;
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-3A9FN5PF\\SS17;Initial Catalog=otobüsdata;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            bool kullanıcıvarmi = false;

            // giriş yapma
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from bilet_tablosu where K_adi='" + textBox1.Text + "' and Sifre='" + textBox2.Text + "'", baglanti);
            //veritabanımızdan tablomuzu çağırıyoruz bazı bilgileri alıyoruz.
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                kullanıcıvarmi = true;
                id = Convert.ToInt32(oku["ID"]);
            }
            baglanti.Close();
            if (kullanıcıvarmi)
            {
                MessageBox.Show("Giriş Başarılı");

                Form4 kullanıcı = new Form4();
                kullanıcı.Show();
                this.Hide();
                timer1.Enabled = false;
            }
            else
            {
                MessageBox.Show("Giriş Başarısız");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 ansyf = new Form1();
            ansyf.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar.ToString() == "*")
            {
                textBox2.PasswordChar = char.Parse("\0");
                button4.Text = "Gizle";
            }
            else
            {
                textBox2.PasswordChar = char.Parse("*");
                button4.Text = "Göster";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = zaman.ToString();
            zaman = zaman - 1;
            //timer aktif edilince zamandan düşürüyoruz.
            if (zaman == 0)
            {
                //eğer zaman sıfırlanırsa anasayfaya yönlendiriyoruz.
                //Form1 anasayf = new Form1();
                //anasayf.Show();
                this.Hide();
                timer1.Enabled = false;
            }
        }
    }
}
