namespace Otobüsrojesi
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button_kayıt = new System.Windows.Forms.Button();
            this.textBox_sifretekrar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_sifre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_kadi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_tc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_soyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_ad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.Brown;
            this.label8.Location = new System.Drawing.Point(-2, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(602, 23);
            this.label8.TabIndex = 21;
            this.label8.Text = "_________________________________________________________________________________" +
    "_____________________________________________________";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Brown;
            this.label7.Location = new System.Drawing.Point(172, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(236, 26);
            this.label7.TabIndex = 20;
            this.label7.Text = "KULLANICI KAYIT";
            // 
            // button_kayıt
            // 
            this.button_kayıt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_kayıt.ForeColor = System.Drawing.Color.Brown;
            this.button_kayıt.Location = new System.Drawing.Point(131, 292);
            this.button_kayıt.Name = "button_kayıt";
            this.button_kayıt.Size = new System.Drawing.Size(90, 31);
            this.button_kayıt.TabIndex = 19;
            this.button_kayıt.Text = "Kayıt Ol";
            this.button_kayıt.UseVisualStyleBackColor = false;
            this.button_kayıt.Click += new System.EventHandler(this.button_kayıt_Click);
            // 
            // textBox_sifretekrar
            // 
            this.textBox_sifretekrar.ForeColor = System.Drawing.Color.Brown;
            this.textBox_sifretekrar.Location = new System.Drawing.Point(282, 248);
            this.textBox_sifretekrar.Name = "textBox_sifretekrar";
            this.textBox_sifretekrar.PasswordChar = '*';
            this.textBox_sifretekrar.Size = new System.Drawing.Size(160, 20);
            this.textBox_sifretekrar.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Brown;
            this.label6.Location = new System.Drawing.Point(137, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Şifre Tekrar:";
            // 
            // textBox_sifre
            // 
            this.textBox_sifre.ForeColor = System.Drawing.Color.Brown;
            this.textBox_sifre.Location = new System.Drawing.Point(282, 222);
            this.textBox_sifre.Name = "textBox_sifre";
            this.textBox_sifre.PasswordChar = '*';
            this.textBox_sifre.Size = new System.Drawing.Size(160, 20);
            this.textBox_sifre.TabIndex = 16;
            this.textBox_sifre.TextChanged += new System.EventHandler(this.textBox_sifre_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Brown;
            this.label5.Location = new System.Drawing.Point(137, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Şifre:";
            // 
            // textBox_kadi
            // 
            this.textBox_kadi.ForeColor = System.Drawing.Color.Brown;
            this.textBox_kadi.Location = new System.Drawing.Point(282, 196);
            this.textBox_kadi.Name = "textBox_kadi";
            this.textBox_kadi.Size = new System.Drawing.Size(160, 20);
            this.textBox_kadi.TabIndex = 15;
            this.textBox_kadi.Tag = "";
            this.textBox_kadi.Text = "Kullanıcı Adı Oluşturun";
            this.textBox_kadi.Enter += new System.EventHandler(this.textBox_kadi_Enter);
            this.textBox_kadi.Leave += new System.EventHandler(this.textBox_kadi_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Brown;
            this.label4.Location = new System.Drawing.Point(137, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Kullanıcı Adı:";
            // 
            // textBox_tc
            // 
            this.textBox_tc.ForeColor = System.Drawing.Color.Brown;
            this.textBox_tc.Location = new System.Drawing.Point(282, 170);
            this.textBox_tc.Name = "textBox_tc";
            this.textBox_tc.Size = new System.Drawing.Size(160, 20);
            this.textBox_tc.TabIndex = 14;
            this.textBox_tc.Text = "Kimlik Numaranızı Giriniz";
            this.textBox_tc.Enter += new System.EventHandler(this.textBox_tc_Enter);
            this.textBox_tc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_tc_KeyPress);
            this.textBox_tc.Leave += new System.EventHandler(this.textBox_tc_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(137, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "TC:";
            // 
            // textBox_soyad
            // 
            this.textBox_soyad.ForeColor = System.Drawing.Color.Brown;
            this.textBox_soyad.Location = new System.Drawing.Point(282, 144);
            this.textBox_soyad.Name = "textBox_soyad";
            this.textBox_soyad.Size = new System.Drawing.Size(160, 20);
            this.textBox_soyad.TabIndex = 13;
            this.textBox_soyad.Text = "Soyadınızı Giriniz";
            this.textBox_soyad.Enter += new System.EventHandler(this.textBox_soyad_Enter);
            this.textBox_soyad.Leave += new System.EventHandler(this.textBox_soyad_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(137, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Soyad:";
            // 
            // textBox_ad
            // 
            this.textBox_ad.ForeColor = System.Drawing.Color.Brown;
            this.textBox_ad.Location = new System.Drawing.Point(282, 118);
            this.textBox_ad.Name = "textBox_ad";
            this.textBox_ad.Size = new System.Drawing.Size(160, 20);
            this.textBox_ad.TabIndex = 18;
            this.textBox_ad.Text = "Adınızı Giriniz";
            this.textBox_ad.TextChanged += new System.EventHandler(this.textBox_ad_TextChanged);
            this.textBox_ad.Enter += new System.EventHandler(this.textBox_ad_Enter);
            this.textBox_ad.Leave += new System.EventHandler(this.textBox_ad_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(137, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ad:";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.PeachPuff;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Brown;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 46);
            this.button1.TabIndex = 22;
            this.button1.Text = "ANASAYFA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(525, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Brown;
            this.label11.Location = new System.Drawing.Point(460, 205);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 13);
            this.label11.TabIndex = 26;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.Brown;
            this.button2.Location = new System.Drawing.Point(238, 292);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 31);
            this.button2.TabIndex = 27;
            this.button2.Text = "Göster";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.Brown;
            this.button3.Location = new System.Drawing.Point(352, 292);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 31);
            this.button3.TabIndex = 28;
            this.button3.Text = "Temizle";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Brown;
            this.label12.Location = new System.Drawing.Point(57, 339);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(444, 22);
            this.label12.TabIndex = 29;
            this.label12.Text = "--------KAMİL KOÇ TURİZM\'E HOŞGELDİNİZ--------";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(572, 370);
            this.ControlBox = false;
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button_kayıt);
            this.Controls.Add(this.textBox_sifretekrar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_sifre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_kadi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_tc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_soyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_ad);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_kayıt;
        private System.Windows.Forms.TextBox textBox_sifretekrar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_sifre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_kadi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_tc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_soyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_ad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label12;
    }
}