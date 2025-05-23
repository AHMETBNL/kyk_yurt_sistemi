namespace kyk_yurt_sistemi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            btn_giris = new Button();
            pictureBox1 = new PictureBox();
            txt_tc = new MaskedTextBox();
            txt_sifre = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(268, 183);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 1;
            label1.Text = "t.c";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(268, 261);
            label2.Name = "label2";
            label2.Size = new Size(37, 20);
            label2.TabIndex = 3;
            label2.Text = "şifre";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(244, 145);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(118, 24);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "yönetici girişi";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(389, 145);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(116, 24);
            radioButton2.TabIndex = 5;
            radioButton2.TabStop = true;
            radioButton2.Text = "öğrenci girişi";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // btn_giris
            // 
            btn_giris.Location = new Point(294, 351);
            btn_giris.Name = "btn_giris";
            btn_giris.Size = new Size(149, 58);
            btn_giris.TabIndex = 6;
            btn_giris.Text = "giriş";
            btn_giris.UseVisualStyleBackColor = true;
            btn_giris.Click += btn_giris_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.gsb;
            pictureBox1.Location = new Point(244, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(261, 112);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // txt_tc
            // 
            txt_tc.Location = new Point(268, 231);
            txt_tc.Mask = "00000000000";
            txt_tc.Name = "txt_tc";
            txt_tc.Size = new Size(210, 27);
            txt_tc.TabIndex = 8;
            // 
            // txt_sifre
            // 
            txt_sifre.Location = new Point(268, 294);
            txt_sifre.Name = "txt_sifre";
            txt_sifre.Size = new Size(210, 27);
            txt_sifre.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_sifre);
            Controls.Add(txt_tc);
            Controls.Add(pictureBox1);
            Controls.Add(btn_giris);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Button btn_giris;
        private PictureBox pictureBox1;
        private MaskedTextBox txt_tc;
        private MaskedTextBox txt_sifre;
    }
}
