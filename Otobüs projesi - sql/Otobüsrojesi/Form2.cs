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
using System.Text.RegularExpressions; //şifre güvenliğini sağlamak için
using System.IO; // tckimlik numaramızla kaydetmek için

namespace Otobüsrojesi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-3A9FN5PF\\SS17;Initial Catalog=otobüsdata;Integrated Security=True");
        // sql bağlantımızı burada ayarlıyoruz.
        int zaman = 100;
        //froma bir zaman ayarlıyoruz.
        private void button_kayıt_Click(object sender, EventArgs e)
        {
            

            if (textBox_ad.Text == "" || textBox_soyad.Text == "" || textBox_tc.Text == "" || textBox_kadi.Text == "" || textBox_sifre.Text == "" || textBox_sifretekrar.Text == "")
            {
                MessageBox.Show("Boş geçemezsiniz!");
                //eğer textboxların içi boş kalır ise kayıt yapmayacak uyarı verecek
            }
            else if (textBox_sifretekrar.Text == "" || textBox_sifre.Text != textBox_sifretekrar.Text)
            {
                MessageBox.Show("şifreler aynı değil!");
                //eğer oluşturulan şifrenin doğrulamasında şifreler aynı değil ise uyarı verilecek.
            }
            else if (textBox_tc.TextLength > 11 || textBox_tc.Text == "")
            {
                MessageBox.Show("TC 11 karakter olmalı!");
                //eğer tc 11 karakterden fazla ise ve boş ise uyarı verecek.
            }
            else
            {
                // bilet tablosuna ad,soyad,kadi,sifre,tcno ekleme
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into bilet_tablosu(Ad,Soyad,K_adi,Sifre,Tc_No) values('" + textBox_ad.Text + "','" + textBox_soyad.Text + "','" + textBox_kadi.Text + "','" + textBox_sifre.Text + "','" + textBox_tc.Text + "')", baglanti);
                //hangi tabloda nerelere ne eklenecek ise onu burada ayarlıyoruz
                komut.ExecuteNonQuery();
                MessageBox.Show("Kayıt Eklendi!");
                baglanti.Close();
                Form1 anasayf = new Form1();
                anasayf.Show();
                this.Hide();
                timer1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 anasayfa = new Form1();
            anasayfa.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            //label12.Text = "KAMİL KOÇ TURİZM'E HOŞGELDİNİZ";
            
            timer1.Enabled = true;
            textBox_tc.MaxLength = 11;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label9.Text = zaman.ToString();
            zaman = zaman - 1;
            //timer aktif edilince zamandan düşürüyoruz.
            if (zaman == 0)
            {
                
                //eğer zaman sıfırlanırsa anasayfaya yönlendiriyoruz.
                //Form1 anasayf = new Form1();
                //Form1 anasayf = new Form1();
                //anasayf.Show();
                
                this.Hide();
                timer1.Enabled = false;
            }
        }

        private void textBox_sifre_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox_sifre.PasswordChar.ToString() == "*")
            {
                textBox_sifre.PasswordChar = char.Parse("\0");
                button2.Text = "Gizle";
            }
            else
            {
                textBox_sifre.PasswordChar = char.Parse("*");
                button2.Text = "Göster";
            }

            if (textBox_sifretekrar.PasswordChar.ToString() == "*")
            {
                textBox_sifretekrar.PasswordChar = char.Parse("\0");
                button2.Text = "Gizle";
            }
            else
            {
                textBox_sifretekrar.PasswordChar = char.Parse("*");
                button2.Text = "Göster";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox_ad.Clear();
            textBox_soyad.Clear();
            textBox_tc.Clear();
            textBox_kadi.Clear();
            textBox_sifre.Clear();
            textBox_sifretekrar.Clear();
            //textboxları temizliyoruz
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void textBox_ad_Enter(object sender, EventArgs e)
        {
            if (textBox_ad.Text == "Adınızı Giriniz") {
                textBox_ad.Text = "";
                textBox_ad.ForeColor = Color.Black;
                //textbox aktiflendiği zaman;
             }
        }

        private void textBox_ad_Leave(object sender, EventArgs e)
        {
            if (textBox_ad.Text == "")
            {
                textBox_ad.Text = "Adınızı Giriniz";
                textBox_ad.ForeColor = Color.Silver;
            }
        }

        private void textBox_soyad_Enter(object sender, EventArgs e)
        {
            if (textBox_soyad.Text == "Soyadınızı Giriniz")
            {
                textBox_soyad.Text = "";
                textBox_soyad.ForeColor = Color.Black;
            }
        }

        private void textBox_soyad_Leave(object sender, EventArgs e)
        {
            if (textBox_soyad.Text == "")
            {
                textBox_soyad.Text = "Soyadınızı Giriniz";
                textBox_soyad.ForeColor = Color.Silver;
            }
        }

        private void textBox_kadi_Enter(object sender, EventArgs e)
        {
            if (textBox_kadi.Text == "Kullanıcı Adı Oluşturun")
            {
                textBox_kadi.Text = "";
                textBox_kadi.ForeColor = Color.Black;
            }
        }

        private void textBox_kadi_Leave(object sender, EventArgs e)
        {
            if (textBox_kadi.Text == "")
            {
                textBox_kadi.Text = "Kullanıcı Adı Oluşturun";
                textBox_kadi.ForeColor = Color.Silver;
            }
        }

        private void textBox_tc_Enter(object sender, EventArgs e)
        {
            if (textBox_tc.Text == "Kimlik Numaranızı Giriniz")
            {
                textBox_tc.Text = "";
                textBox_tc.ForeColor = Color.Black;
            }
        }

        private void textBox_tc_Leave(object sender, EventArgs e)
        {
            if (textBox_tc.Text == "")
            {
                textBox_tc.Text = "Kimlik Numaranızı Giriniz";
                textBox_tc.ForeColor = Color.Silver;
            }
        }

        private void textBox_ad_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label12.Text = label12.Text.Substring(1) + label12.Text.Substring(0, 1);
        }

        private void textBox_tc_KeyPress(object sender, KeyPressEventArgs e)
        {//tc kimlik textine harf girilmesini engelledik.
            e.Handled = ! char .IsDigit(e.KeyChar) && ! char.IsControl(e.KeyChar);
        }
    }
}
