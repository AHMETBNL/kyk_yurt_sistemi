using System;
using System.Runtime.CompilerServices;
using MySql.Data.MySqlClient;
namespace kyk_yurt_sistemi
{
    public partial class Form1 : Form
    {
        public static MySqlConnection conn=new MySqlConnection("server=localhost;user=root;database=kyk_sistem;password=12345;");
        public static int yonetici_id;
        public static int ogrenci_id;
        public Form1()
        {
            InitializeComponent();
        }
        static  void giris(MaskedTextBox txt_sifre,MaskedTextBox txt_tc,string query,RadioButton rd_yonetici,RadioButton rd_ogrenci)
        {
            conn.Open();
            
            MySqlCommand cmd = new MySqlCommand(query, conn);


            cmd.Parameters.AddWithValue("@tc", txt_tc.Text);
            cmd.Parameters.AddWithValue("@sifre", txt_sifre.Text);

            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                int kullaniciID = reader.GetInt32("id");
                MessageBox.Show("Giriþ baþarýlý!");
                if(rd_yonetici.Checked==true)
                {
                    yonetici_ana_menu yonetici_Ana_Menu = new yonetici_ana_menu();
                    yonetici_Ana_Menu.Show();
                    yonetici_id = kullaniciID;
                }
                else if(rd_ogrenci.Checked==true)
                {
                    ogrenci_id= kullaniciID;
                    ogrenci_menu ogrenci_=new ogrenci_menu();
                    ogrenci_.Show();
                }                
                
            }
            else
            {
                MessageBox.Show("Kullanýcý adý veya þifre yanlýþ!");
            }

            reader.Close();
            conn.Close();
        }
        private void btn_giris_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked==true)
            {
                string query = "SELECT id FROM yoneticiler WHERE tc=@tc AND sifre=@sifre";
                giris(txt_sifre,txt_tc,query,radioButton1,radioButton2);
            }
            else if(radioButton2.Checked==true)
            {
                string query = "SELECT id FROM ogrenciler WHERE tc=@tc AND sifre=@sifre";
                giris(txt_sifre, txt_tc, query, radioButton1, radioButton2);
            }
        }
    }
}
