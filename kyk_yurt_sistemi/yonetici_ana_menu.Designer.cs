namespace kyk_yurt_sistemi
{
    partial class yonetici_ana_menu
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            panel1 = new Panel();
            label5 = new Label();
            lbl_yetki_yemek = new Label();
            dateTimePicker1 = new DateTimePicker();
            btn_yemek = new Button();
            label1 = new Label();
            label4 = new Label();
            txt_çorba = new TextBox();
            txt_tatlı = new TextBox();
            txt_ana_yemek = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txt_ara_sıcak = new TextBox();
            tabPage2 = new TabPage();
            btn_ogrenci_kaydet = new Button();
            label10 = new Label();
            txt_oda_no = new TextBox();
            label9 = new Label();
            txt_soyisim = new TextBox();
            label8 = new Label();
            txt_şifre = new TextBox();
            label7 = new Label();
            txt_tc = new TextBox();
            label6 = new Label();
            txt_isim = new TextBox();
            tabPage3 = new TabPage();
            comboBox_rutbe = new ComboBox();
            btn_yonetici_kayıt = new Button();
            label15 = new Label();
            label11 = new Label();
            txt_yönetici_isim = new TextBox();
            txt_yönetici_tc = new TextBox();
            label12 = new Label();
            label14 = new Label();
            txt_yönetici_soyisim = new TextBox();
            txt_yönetici_sifre = new TextBox();
            label13 = new Label();
            tabPage4 = new TabPage();
            btn_red_oda = new Button();
            btn_onayla_oda = new Button();
            checkedListBox1 = new CheckedListBox();
            tabPage5 = new TabPage();
            btn_reddet_izin = new Button();
            checkedListBox2 = new CheckedListBox();
            btn_onayla_izin = new Button();
            tabPage6 = new TabPage();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            tabPage5.SuspendLayout();
            tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(739, 426);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(731, 393);
            tabPage1.TabIndex = 0;
            tabPage1.Text = " yemek listesi ekleme";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Controls.Add(lbl_yetki_yemek);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(btn_yemek);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txt_çorba);
            panel1.Controls.Add(txt_tatlı);
            panel1.Controls.Add(txt_ana_yemek);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txt_ara_sıcak);
            panel1.Location = new Point(6, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(599, 381);
            panel1.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(263, 23);
            label5.Name = "label5";
            label5.Size = new Size(151, 20);
            label5.TabIndex = 10;
            label5.Text = "lütfen bir tarih seçiniz";
            label5.Visible = false;
            // 
            // lbl_yetki_yemek
            // 
            lbl_yetki_yemek.AutoSize = true;
            lbl_yetki_yemek.ForeColor = Color.Red;
            lbl_yetki_yemek.Location = new Point(306, 140);
            lbl_yetki_yemek.Name = "lbl_yetki_yemek";
            lbl_yetki_yemek.Size = new Size(224, 20);
            lbl_yetki_yemek.TabIndex = 9;
            lbl_yetki_yemek.Text = "bu modüle erişim yetkiniz yoktur";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(263, 55);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 9;
            dateTimePicker1.Visible = false;
            // 
            // btn_yemek
            // 
            btn_yemek.Location = new Point(63, 322);
            btn_yemek.Name = "btn_yemek";
            btn_yemek.Size = new Size(118, 45);
            btn_yemek.TabIndex = 8;
            btn_yemek.Text = "yemekleri ekle";
            btn_yemek.UseVisualStyleBackColor = true;
            btn_yemek.Visible = false;
            btn_yemek.Click += btn_yemek_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 23);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 1;
            label1.Text = "çorba";
            label1.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 248);
            label4.Name = "label4";
            label4.Size = new Size(35, 20);
            label4.TabIndex = 7;
            label4.Text = "tatlı";
            label4.Visible = false;
            // 
            // txt_çorba
            // 
            txt_çorba.Location = new Point(49, 55);
            txt_çorba.Name = "txt_çorba";
            txt_çorba.Size = new Size(160, 27);
            txt_çorba.TabIndex = 0;
            txt_çorba.Visible = false;
            // 
            // txt_tatlı
            // 
            txt_tatlı.Location = new Point(49, 280);
            txt_tatlı.Name = "txt_tatlı";
            txt_tatlı.Size = new Size(160, 27);
            txt_tatlı.TabIndex = 6;
            txt_tatlı.Visible = false;
            // 
            // txt_ana_yemek
            // 
            txt_ana_yemek.Location = new Point(49, 133);
            txt_ana_yemek.Name = "txt_ana_yemek";
            txt_ana_yemek.Size = new Size(160, 27);
            txt_ana_yemek.TabIndex = 2;
            txt_ana_yemek.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 176);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 5;
            label3.Text = "ara sıcak";
            label3.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 101);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 3;
            label2.Text = "ana yemek";
            label2.Visible = false;
            // 
            // txt_ara_sıcak
            // 
            txt_ara_sıcak.Location = new Point(49, 208);
            txt_ara_sıcak.Name = "txt_ara_sıcak";
            txt_ara_sıcak.Size = new Size(160, 27);
            txt_ara_sıcak.TabIndex = 4;
            txt_ara_sıcak.Visible = false;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btn_ogrenci_kaydet);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(txt_oda_no);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(txt_soyisim);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(txt_şifre);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(txt_tc);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(txt_isim);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(731, 393);
            tabPage2.TabIndex = 1;
            tabPage2.Text = " öğrenci ekleme";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_ogrenci_kaydet
            // 
            btn_ogrenci_kaydet.Location = new Point(320, 217);
            btn_ogrenci_kaydet.Name = "btn_ogrenci_kaydet";
            btn_ogrenci_kaydet.Size = new Size(173, 62);
            btn_ogrenci_kaydet.TabIndex = 10;
            btn_ogrenci_kaydet.Text = "kaydet";
            btn_ogrenci_kaydet.UseVisualStyleBackColor = true;
            btn_ogrenci_kaydet.Click += btn_ogrenci_kaydet_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(320, 131);
            label10.Name = "label10";
            label10.Size = new Size(173, 20);
            label10.TabIndex = 9;
            label10.Text = "öğrencinin oda numarası";
            // 
            // txt_oda_no
            // 
            txt_oda_no.Location = new Point(320, 166);
            txt_oda_no.Name = "txt_oda_no";
            txt_oda_no.Size = new Size(166, 27);
            txt_oda_no.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(320, 39);
            label9.Name = "label9";
            label9.Size = new Size(138, 20);
            label9.TabIndex = 7;
            label9.Text = "öğrencinin soy_ismi";
            // 
            // txt_soyisim
            // 
            txt_soyisim.Location = new Point(320, 74);
            txt_soyisim.Name = "txt_soyisim";
            txt_soyisim.Size = new Size(166, 27);
            txt_soyisim.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(106, 217);
            label8.Name = "label8";
            label8.Size = new Size(121, 20);
            label8.TabIndex = 5;
            label8.Text = "öğrencinin şifresi";
            // 
            // txt_şifre
            // 
            txt_şifre.Location = new Point(106, 252);
            txt_şifre.Name = "txt_şifre";
            txt_şifre.Size = new Size(166, 27);
            txt_şifre.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(106, 131);
            label7.Name = "label7";
            label7.Size = new Size(103, 20);
            label7.TabIndex = 3;
            label7.Text = "öğrencinin T.C";
            // 
            // txt_tc
            // 
            txt_tc.Location = new Point(106, 166);
            txt_tc.Name = "txt_tc";
            txt_tc.Size = new Size(166, 27);
            txt_tc.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(106, 39);
            label6.Name = "label6";
            label6.Size = new Size(110, 20);
            label6.TabIndex = 1;
            label6.Text = "öğrencinin ismi";
            // 
            // txt_isim
            // 
            txt_isim.Location = new Point(106, 74);
            txt_isim.Name = "txt_isim";
            txt_isim.Size = new Size(166, 27);
            txt_isim.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(comboBox_rutbe);
            tabPage3.Controls.Add(btn_yonetici_kayıt);
            tabPage3.Controls.Add(label15);
            tabPage3.Controls.Add(label11);
            tabPage3.Controls.Add(txt_yönetici_isim);
            tabPage3.Controls.Add(txt_yönetici_tc);
            tabPage3.Controls.Add(label12);
            tabPage3.Controls.Add(label14);
            tabPage3.Controls.Add(txt_yönetici_soyisim);
            tabPage3.Controls.Add(txt_yönetici_sifre);
            tabPage3.Controls.Add(label13);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(731, 393);
            tabPage3.TabIndex = 2;
            tabPage3.Text = " yönetici ekleme";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // comboBox_rutbe
            // 
            comboBox_rutbe.FormattingEnabled = true;
            comboBox_rutbe.Items.AddRange(new object[] { "1-aşçı\t", "2-idari personel\t", "3-yurt müdürü" });
            comboBox_rutbe.Location = new Point(327, 191);
            comboBox_rutbe.Name = "comboBox_rutbe";
            comboBox_rutbe.Size = new Size(166, 28);
            comboBox_rutbe.TabIndex = 22;
            // 
            // btn_yonetici_kayıt
            // 
            btn_yonetici_kayıt.Location = new Point(327, 242);
            btn_yonetici_kayıt.Name = "btn_yonetici_kayıt";
            btn_yonetici_kayıt.Size = new Size(173, 62);
            btn_yonetici_kayıt.TabIndex = 21;
            btn_yonetici_kayıt.Text = "kaydet";
            btn_yonetici_kayıt.UseVisualStyleBackColor = true;
            btn_yonetici_kayıt.Click += btn_yonetici_kayıt_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(113, 64);
            label15.Name = "label15";
            label15.Size = new Size(112, 20);
            label15.TabIndex = 12;
            label15.Text = "yöneticinin ismi";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(327, 156);
            label11.Name = "label11";
            label11.Size = new Size(130, 20);
            label11.TabIndex = 20;
            label11.Text = "yöneticinin rütbesi";
            // 
            // txt_yönetici_isim
            // 
            txt_yönetici_isim.Location = new Point(113, 99);
            txt_yönetici_isim.Name = "txt_yönetici_isim";
            txt_yönetici_isim.Size = new Size(166, 27);
            txt_yönetici_isim.TabIndex = 11;
            // 
            // txt_yönetici_tc
            // 
            txt_yönetici_tc.Location = new Point(113, 191);
            txt_yönetici_tc.Name = "txt_yönetici_tc";
            txt_yönetici_tc.Size = new Size(166, 27);
            txt_yönetici_tc.TabIndex = 13;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(327, 64);
            label12.Name = "label12";
            label12.Size = new Size(140, 20);
            label12.TabIndex = 18;
            label12.Text = "yöneticinin soy_ismi";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(113, 156);
            label14.Name = "label14";
            label14.Size = new Size(105, 20);
            label14.TabIndex = 14;
            label14.Text = "yöneticinin T.C";
            // 
            // txt_yönetici_soyisim
            // 
            txt_yönetici_soyisim.Location = new Point(327, 99);
            txt_yönetici_soyisim.Name = "txt_yönetici_soyisim";
            txt_yönetici_soyisim.Size = new Size(166, 27);
            txt_yönetici_soyisim.TabIndex = 17;
            // 
            // txt_yönetici_sifre
            // 
            txt_yönetici_sifre.Location = new Point(113, 277);
            txt_yönetici_sifre.Name = "txt_yönetici_sifre";
            txt_yönetici_sifre.Size = new Size(166, 27);
            txt_yönetici_sifre.TabIndex = 15;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(113, 242);
            label13.Name = "label13";
            label13.Size = new Size(123, 20);
            label13.TabIndex = 16;
            label13.Text = "yöneticinin şifresi";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(btn_red_oda);
            tabPage4.Controls.Add(btn_onayla_oda);
            tabPage4.Controls.Add(checkedListBox1);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(731, 393);
            tabPage4.TabIndex = 3;
            tabPage4.Text = " oda değişikliği onayla";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // btn_red_oda
            // 
            btn_red_oda.Location = new Point(373, 234);
            btn_red_oda.Name = "btn_red_oda";
            btn_red_oda.Size = new Size(233, 60);
            btn_red_oda.TabIndex = 2;
            btn_red_oda.Text = "seçilenleri reddet";
            btn_red_oda.UseVisualStyleBackColor = true;
            btn_red_oda.Click += btn_red_oda_Click;
            // 
            // btn_onayla_oda
            // 
            btn_onayla_oda.Location = new Point(373, 87);
            btn_onayla_oda.Name = "btn_onayla_oda";
            btn_onayla_oda.Size = new Size(233, 60);
            btn_onayla_oda.TabIndex = 1;
            btn_onayla_oda.Text = "seçilenleri onayla";
            btn_onayla_oda.UseVisualStyleBackColor = true;
            btn_onayla_oda.Click += btn_onayla_oda_Click;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(3, 3);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(328, 356);
            checkedListBox1.TabIndex = 0;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(btn_reddet_izin);
            tabPage5.Controls.Add(checkedListBox2);
            tabPage5.Controls.Add(btn_onayla_izin);
            tabPage5.Location = new Point(4, 29);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(731, 393);
            tabPage5.TabIndex = 4;
            tabPage5.Text = " izin onayla ";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // btn_reddet_izin
            // 
            btn_reddet_izin.Location = new Point(383, 245);
            btn_reddet_izin.Name = "btn_reddet_izin";
            btn_reddet_izin.Size = new Size(233, 60);
            btn_reddet_izin.TabIndex = 5;
            btn_reddet_izin.Text = "seçilenleri reddet";
            btn_reddet_izin.UseVisualStyleBackColor = true;
            // 
            // checkedListBox2
            // 
            checkedListBox2.FormattingEnabled = true;
            checkedListBox2.Location = new Point(13, 14);
            checkedListBox2.Name = "checkedListBox2";
            checkedListBox2.Size = new Size(328, 356);
            checkedListBox2.TabIndex = 3;
            // 
            // btn_onayla_izin
            // 
            btn_onayla_izin.Location = new Point(383, 98);
            btn_onayla_izin.Name = "btn_onayla_izin";
            btn_onayla_izin.Size = new Size(233, 60);
            btn_onayla_izin.TabIndex = 4;
            btn_onayla_izin.Text = "seçilenleri onayla";
            btn_onayla_izin.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(button1);
            tabPage6.Controls.Add(dataGridView1);
            tabPage6.Location = new Point(4, 29);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(731, 393);
            tabPage6.TabIndex = 5;
            tabPage6.Text = " kayıt silme ";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(728, 295);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button1.Location = new Point(315, 318);
            button1.Name = "button1";
            button1.Size = new Size(84, 39);
            button1.TabIndex = 2;
            button1.Text = "sil";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // yonetici_ana_menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 529);
            Controls.Add(tabControl1);
            Name = "yonetici_ana_menu";
            Text = "yonetici_ana_menu";
            Load += yonetici_ana_menu_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage5.ResumeLayout(false);
            tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private Panel panel1;
        private Button btn_yemek;
        private Label label1;
        private Label label4;
        private TextBox txt_çorba;
        private TextBox txt_tatlı;
        private TextBox txt_ana_yemek;
        private Label label3;
        private Label label2;
        private TextBox txt_ara_sıcak;
        private Label label5;
        private Label lbl_yetki_yemek;
        private DateTimePicker dateTimePicker1;
        private Label label6;
        private TextBox txt_isim;
        private Button btn_ogrenci_kaydet;
        private Label label10;
        private TextBox txt_oda_no;
        private Label label9;
        private TextBox txt_soyisim;
        private Label label8;
        private TextBox txt_şifre;
        private Label label7;
        private TextBox txt_tc;
        private ComboBox comboBox_rutbe;
        private Button btn_yonetici_kayıt;
        private Label label15;
        private Label label11;
        private TextBox txt_yönetici_isim;
        private TextBox txt_yönetici_tc;
        private Label label12;
        private Label label14;
        private TextBox txt_yönetici_soyisim;
        private TextBox txt_yönetici_sifre;
        private Label label13;
        private Button btn_red_oda;
        private Button btn_onayla_oda;
        private CheckedListBox checkedListBox1;
        private Button btn_reddet_izin;
        private CheckedListBox checkedListBox2;
        private Button btn_onayla_izin;
        private TabPage tabPage6;
        private DataGridView dataGridView1;
        private Button button1;
    }
}