using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace kyk_yurt_sistemi
{
    public partial class ogrenci_menu : Form
    {
        public ogrenci_menu()
        {
            InitializeComponent();
        }

        private void btn_izin_Click(object sender, EventArgs e)
        {

            Form1.conn.Open();

            string query = "INSERT INTO izinler (ogrenci_id, baslangic_tarihi, bitis_tarihi) VALUES (@ogrenci_id, @baslangic, @bitis)";

            using (MySqlCommand cmd = new MySqlCommand(query, Form1.conn))
            {
                cmd.Parameters.AddWithValue("@ogrenci_id", Form1.ogrenci_id);
                cmd.Parameters.AddWithValue("@baslangic", monthCalendar1.SelectionStart.Date);
                cmd.Parameters.AddWithValue("@bitis", monthCalendar2.SelectionEnd.Date);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("İzin talebiniz gönderildi.");
            IzinHakkiGoster();
            Form1.conn.Close();


        }
        private void IzinHakkiGoster()
        {
            int toplamIzinHakki = 30; // sabit varsayalım
            int kullanilanGun = 0;

           
                Form1.conn.Open();

                string query = "SELECT SUM(DATEDIFF(bitis_tarihi, baslangic_tarihi) + 1) AS kullanilan_gun FROM izinler WHERE ogrenci_id = @ogrenci_id";

                using (MySqlCommand cmd = new MySqlCommand(query, Form1.conn))
                {
                    cmd.Parameters.AddWithValue("@ogrenci_id", Form1.ogrenci_id);
                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                        kullanilanGun = Convert.ToInt32(result);
                
                }
            

            int kalanGun = toplamIzinHakki - kullanilanGun;
            if (kalanGun < 0) kalanGun = 0;

            // Etikete yaz
            lbl_izin.Text = $"kalan izin hakkınız\n{kalanGun} gün";
            Form1.conn.Close();
        }

        private void ogrenci_menu_Load(object sender, EventArgs e)
        {
            IzinHakkiGoster();
        }

        private void btn_basvur_Click(object sender, EventArgs e)
        {
            Form1.conn.Open();  
            string sql = "INSERT INTO oda_basvuru(ogrenci_id,oda) VALUES(@id,@oda)";
            MySqlCommand cmd= new MySqlCommand(sql, Form1.conn);
            cmd.Parameters.AddWithValue("@id",Form1.ogrenci_id);
            cmd.Parameters.AddWithValue("@oda",cmb_oda.SelectedItem?.ToString());
            cmd.ExecuteNonQuery();
            MessageBox.Show("başarı ile başvuru yapıldı");
            Form1.conn.Close();

        }

        private void cmb_kat_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilenBlog = cmb_blog.SelectedItem?.ToString();
            string secilenKat = cmb_kat.SelectedItem?.ToString();
            for(int i = 1;i<16;i++)
            {
                if(i<10)
                {
                    cmb_kat.Items.Add(secilenKat +"0"+ i + "-" + secilenBlog);
                }
                else
                {
                    cmb_kat.Items.Add(secilenKat + i + "-" + secilenBlog);
                }
                
            }
            
        }
    }
}
