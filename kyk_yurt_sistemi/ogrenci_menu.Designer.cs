﻿namespace kyk_yurt_sistemi
{
    partial class ogrenci_menu
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
            lbl_izin = new Label();
            label3 = new Label();
            btn_izin = new Button();
            label2 = new Label();
            label1 = new Label();
            monthCalendar2 = new MonthCalendar();
            monthCalendar1 = new MonthCalendar();
            tabPage2 = new TabPage();
            btn_yemek = new Button();
            dataGridView1 = new DataGridView();
            tabPage3 = new TabPage();
            panel2 = new Panel();
            btn_basvur = new Button();
            cmb_blog = new ComboBox();
            label6 = new Label();
            cmb_kat = new ComboBox();
            label5 = new Label();
            cmb_oda = new ComboBox();
            label4 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 426);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(btn_izin);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(monthCalendar2);
            tabPage1.Controls.Add(monthCalendar1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(768, 393);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "izin alma";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.IndianRed;
            panel1.Controls.Add(lbl_izin);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(6, 29);
            panel1.Name = "panel1";
            panel1.Size = new Size(209, 235);
            panel1.TabIndex = 5;
            // 
            // lbl_izin
            // 
            lbl_izin.AutoSize = true;
            lbl_izin.Font = new Font("Segoe UI", 23F);
            lbl_izin.Location = new Point(89, 97);
            lbl_izin.Name = "lbl_izin";
            lbl_izin.Size = new Size(0, 52);
            lbl_izin.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F);
            label3.Location = new Point(12, 18);
            label3.Name = "label3";
            label3.Size = new Size(184, 30);
            label3.TabIndex = 3;
            label3.Text = "kalan izin hakkınız";
            // 
            // btn_izin
            // 
            btn_izin.Location = new Point(407, 295);
            btn_izin.Name = "btn_izin";
            btn_izin.Size = new Size(163, 63);
            btn_izin.TabIndex = 4;
            btn_izin.Text = "izin al";
            btn_izin.UseVisualStyleBackColor = true;
            btn_izin.Click += btn_izin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(563, 11);
            label2.Name = "label2";
            label2.Size = new Size(135, 37);
            label2.TabIndex = 3;
            label2.Text = "bitiş günü";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(261, 11);
            label1.Name = "label1";
            label1.Size = new Size(197, 37);
            label1.TabIndex = 2;
            label1.Text = "başlangıç günü";
            // 
            // monthCalendar2
            // 
            monthCalendar2.Location = new Point(497, 57);
            monthCalendar2.Name = "monthCalendar2";
            monthCalendar2.TabIndex = 1;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(227, 57);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btn_yemek);
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(768, 393);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "yemek listesi";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_yemek
            // 
            btn_yemek.Location = new Point(296, 339);
            btn_yemek.Name = "btn_yemek";
            btn_yemek.Size = new Size(124, 48);
            btn_yemek.TabIndex = 1;
            btn_yemek.Text = "yenile";
            btn_yemek.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(756, 316);
            dataGridView1.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.Silver;
            tabPage3.Controls.Add(panel2);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(768, 393);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "oda değişikliği";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 192, 255);
            panel2.Controls.Add(btn_basvur);
            panel2.Controls.Add(cmb_blog);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(cmb_kat);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(cmb_oda);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(226, 27);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 333);
            panel2.TabIndex = 7;
            // 
            // btn_basvur
            // 
            btn_basvur.Location = new Point(49, 270);
            btn_basvur.Name = "btn_basvur";
            btn_basvur.Size = new Size(120, 51);
            btn_basvur.TabIndex = 6;
            btn_basvur.Text = "başvur";
            btn_basvur.UseVisualStyleBackColor = true;
            btn_basvur.Click += btn_basvur_Click;
            // 
            // cmb_blog
            // 
            cmb_blog.FormattingEnabled = true;
            cmb_blog.Items.AddRange(new object[] { "A", "B", "C", "D" });
            cmb_blog.Location = new Point(26, 55);
            cmb_blog.Name = "cmb_blog";
            cmb_blog.Size = new Size(173, 28);
            cmb_blog.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 192);
            label6.Name = "label6";
            label6.Size = new Size(216, 20);
            label6.TabIndex = 5;
            label6.Text = "gitmek istediğiniz odayı seçiniz";
            // 
            // cmb_kat
            // 
            cmb_kat.FormattingEnabled = true;
            cmb_kat.Items.AddRange(new object[] { "1", "2", "3", "4" });
            cmb_kat.Location = new Point(26, 147);
            cmb_kat.Name = "cmb_kat";
            cmb_kat.Size = new Size(173, 28);
            cmb_kat.TabIndex = 1;
            cmb_kat.SelectedIndexChanged += cmb_kat_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 109);
            label5.Name = "label5";
            label5.Size = new Size(203, 20);
            label5.TabIndex = 4;
            label5.Text = "gitmek istediğiniz katı seçiniz";
            // 
            // cmb_oda
            // 
            cmb_oda.FormattingEnabled = true;
            cmb_oda.Location = new Point(26, 225);
            cmb_oda.Name = "cmb_oda";
            cmb_oda.Size = new Size(173, 28);
            cmb_oda.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 13);
            label4.Name = "label4";
            label4.Size = new Size(207, 20);
            label4.TabIndex = 3;
            label4.Text = "gitmek istediğiniz blogu seçin";
            // 
            // ogrenci_menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "ogrenci_menu";
            Text = "ogrenci_menu";
            Load += ogrenci_menu_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private MonthCalendar monthCalendar1;
        private Button btn_izin;
        private Label label2;
        private Label label1;
        private MonthCalendar monthCalendar2;
        private Panel panel1;
        private Label lbl_izin;
        private Label label3;
        private Button btn_yemek;
        private DataGridView dataGridView1;
        private Label label4;
        private ComboBox cmb_oda;
        private ComboBox cmb_kat;
        private ComboBox cmb_blog;
        private Panel panel2;
        private Button btn_basvur;
        private Label label6;
        private Label label5;
    }
}