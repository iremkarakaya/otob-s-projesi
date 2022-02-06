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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        int id;
        static public int sira;
        static public string tarih, nereye;
        SqlConnection baglantı = new SqlConnection("Data Source=LAPTOP-3A9FN5PF\\SS17;Initial Catalog=otobüsdata;Integrated Security=True");

        public void verilerigoster()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from bilet_tablosu ", baglantı);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        public void temizle()
        {

            textBox_isim.Clear();
            textBox_soyisim.Clear();
            textBox_tc.Clear();
            textBox_tel.Clear();
            comboBox_adet.Text = "";
            comboBox_cinsiyet.Text = "";
            comboBox_nereden.Text = "";
            comboBox_nereye.Text = "";
            comboBox_saat.Text = "";
            comboBox_yas.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (textBox_sil.Text == "")
            {
                //id belirtilmemişse uyarı verdiriyoruz.
                MessageBox.Show("LÜTFEN SİLMEK İSTEDİĞİNİZ İD SİNİ GİRİNİZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult secenek;
                secenek = MessageBox.Show("SİLMEK İSTEDİĞİNİZDEN EMİN MİSİNİZ ?", "SORU", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //seçenek oluşturuyoruz ona göre silme işlemini devam ettiriyoruz.
                if (secenek == DialogResult.Yes)
                    //eğer seçenekte evet seçiliyse
                {
                    baglantı.Open();
                    SqlCommand komut = new SqlCommand("delete from bilet_tablosu where ID =" + textBox_sil.Text + "", baglantı);
                    //bağlantımızı açıyoruz ve sql de tablomuza bağlanıyoruz. silinecek yeri seçtiriyoruz.
                    komut.ExecuteNonQuery();
                    baglantı.Close();
                    MessageBox.Show("kayıt Silindi");
                    verilerigoster();
                    temizle();
                    textBox_sil.Text = "";

                }
            }
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("select * from bilet_tablosu where ID like'" + textBox_ara.Text + "%'", baglantı);
            //bağlantımızı açıyoruz. sql e bağlanıyoruz tablomuzdan aradığımız id yi getirtiyoruz ve seçiyoruz.
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            //gridviewda seçili hale getiriyoruz.
            baglantı.Close();
            temizle();
            textBox_ara.Text = "";
        }

        private void button_sil_Click(object sender, EventArgs e)
        {
            //butonları aktif ediyoruz.
            label_sil.Visible = true;
            textBox_sil.Visible = true;
            button2.Visible = true;
        }

        private void button_ara_Click(object sender, EventArgs e)
        {
            //butonları aktif ediyoruz.
            label_ara.Visible = true;
            textBox_ara.Visible = true;
            button3.Visible = true;
        }

        private void button_temizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void button_guncelle_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("update bilet_tablosu set Tc_No='" + textBox_tc.Text + "',Ad='" + textBox_isim.Text + "',Soyad='" + textBox_soyisim.Text + "',YAŞ='" + comboBox_yas.Text.ToString() + "',TELEFON='" + textBox_tel.Text + "',CİNSİYET='" + comboBox_cinsiyet.Text.ToString() + "',NEREDEN='" + comboBox_nereden.Text.ToString() + "',NEREYE='" + comboBox_nereye.Text.ToString() + "',SAAT='" + comboBox_saat.Text.ToString() + "',ADET='" + comboBox_adet.Text.ToString() + "',TARİH='" + dateTimePicker_tarih.Text.ToString() + "' where ID=" + Convert.ToInt32(label_id.Text) + "", baglantı);
            //sqlde veritabanımızdaki tablodan bilgileri çağırıyoruz ve güncelletiyoruz.
            komut.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("KAYIT GUNCELLENDİ");
            verilerigoster();
            //önceden tanımladığımız fonksiyonu burada çağırıyoruz.
            temizle();
            //önceden tanımladığımız fonksiyonu burada çağırıyoruz.
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //textler view de hangi konuma geleceğini ayarlıyoruz.
            label_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox_tc.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox_isim.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox_soyisim.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            comboBox_yas.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox_tel.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            comboBox_cinsiyet.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            comboBox_nereden.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            comboBox_nereye.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            comboBox_saat.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            comboBox_adet.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 ansyf = new Form1();
            ansyf.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form11 glnmsj = new Form11();
            glnmsj.Show();
            this.Hide();
        }

        private void textBox_tel_Enter(object sender, EventArgs e)
        
            {
                if (textBox_tel.Text == "0 Koymayın")
                {
                    textBox_tel.Text = "";
                    textBox_tel.ForeColor = Color.Black;
                }
            }
        

        private void textBox_tel_Leave(object sender, EventArgs e)
        {
            if (textBox_tel.Text == "")
            {
                textBox_tel.Text = "0 Koymayın";
                textBox_tel.ForeColor = Color.Silver;
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            //tanımladığımız fonskiyonu ve textleri sıfırlıyoruz başlangıçta.
            verilerigoster();
            label_sil.Visible = false;
            button2.Visible = false;
            textBox_sil.Visible = false;
            label_ara.Visible = false;
            textBox_ara.Visible = false;
            button3.Visible = false;
            label_id.Visible = false;
            
        }
    }
}
