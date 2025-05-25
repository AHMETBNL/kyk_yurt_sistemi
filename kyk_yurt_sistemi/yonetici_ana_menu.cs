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
    public partial class yonetici_ana_menu : Form
    {
        public yonetici_ana_menu()
        {
            InitializeComponent();
        }

        private void btn_onayla_oda_Click(object sender, EventArgs e)
        {
            Form1.conn.Open();

            foreach (var item in checkedListBox1.CheckedItems)
            {
                string secilen = item.ToString();
                int id = Convert.ToInt32(secilen.Split('-')[1].Trim());
                string oda = secilen.Split("-")[0].Trim();

                string query = "UPDATE ogrenciler SET oda =@oda WHERE id = @id";
                using (MySqlCommand cmd = new MySqlCommand(query, Form1.conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@oda", oda);
                    cmd.ExecuteNonQuery();
                }
            }
            Form1.conn.Close();
            MessageBox.Show("Seçilen öğrenciler onaylandı.");
        }

        private void btn_red_oda_Click(object sender, EventArgs e)
        {
            Form1.conn.Open();

            foreach (var item in checkedListBox1.CheckedItems)
            {
                string secilen = item.ToString();
                int id = Convert.ToInt32(secilen.Split('-')[1].Trim());

                string query = "UPDATE ogrenciler SET oda_onay = 'reddedildi' WHERE id = @id";
                using (MySqlCommand cmd = new MySqlCommand(query, Form1.conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Seçilen öğrenciler reddedildi.");
            Form1.conn.Close();
        }
        static void oda(CheckedListBox checkedList)
        {
            Form1.conn.Open();

            string query = "SELECT id, ad, soyad FROM ogrenciler WHERE oda_onay = 'beklemede'";

            using (MySqlCommand cmd = new MySqlCommand(query, Form1.conn))
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    int id = reader.GetInt32("ogrenci_id");
                    string oda = reader.GetString("oda");
                    checkedList.Items.Add(id + "-" + oda);
                }
            }
        }
        private void yonetici_ana_menu_Load(object sender, EventArgs e)
        {
            try
            {
                Form1.conn.Open();

                string query = "SELECT id, tc, sifre, isim, soy_isim, oda_no, izin_hakki FROM ogrenciler";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, Form1.conn);

                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView1.DataSource = table;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                Form1.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }


        }

        private void btn_yemek_Click(object sender, EventArgs e)
        {
            Form1.conn.Open();

            string query = "INSERT INTO yemekler(çorba,ana_yemek,ara_sıcak,tatlı,tarih)VALUES(@çorba,@ana_yemek,@ara_sıcak,@tatlı,@tarih)";
            MySqlCommand cmd = new MySqlCommand(query, Form1.conn);

            cmd.Parameters.AddWithValue("@çorba", txt_çorba.Text);
            cmd.Parameters.AddWithValue("@ana_yemek", txt_ana_yemek.Text);
            cmd.Parameters.AddWithValue("@ara_sıcak", txt_ara_sıcak.Text);
            cmd.Parameters.AddWithValue("@tatlı", txt_tatlı.Text);
            cmd.Parameters.AddWithValue("@tarih", dateTimePicker1.Value.Date);
            cmd.ExecuteNonQuery();
            Form1.conn.Close();
            MessageBox.Show("Yemek menüsü kaydedildi.");
        }

        private void btn_ogrenci_kaydet_Click(object sender, EventArgs e)
        {
            Form1.conn.Open();
            string query = "INSERT INTO ogrenciler(tc,sifre,isim,soy_isim,oda_no)VALUES(@tc,@sifre,@isim,@soy_isim,@oda_no)";

            MySqlCommand cmd = new MySqlCommand(query, Form1.conn);

            cmd.Parameters.AddWithValue("@tc", txt_tc.Text);
            cmd.Parameters.AddWithValue("@sifre", txt_şifre.Text);
            cmd.Parameters.AddWithValue("@isim", txt_isim.Text);
            cmd.Parameters.AddWithValue("@soy_isim", txt_soyisim.Text);
            cmd.Parameters.AddWithValue("@oda_no", txt_oda_no.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Öğrenci kaydı başarılı.");

            Form1.conn.Close();
        }

        private void btn_yonetici_kayıt_Click(object sender, EventArgs e)
        {
            Form1.conn.Open();
            string query = "INSERT INTO yoneticiler(tc,isim,soy_isim,rutbe,sifre)VALUES(@tc,@isim,@soy_isim,@rutbe,@sifre)";
            int rutbe = Convert.ToInt32(comboBox_rutbe.Text.Split('-')[0]);
            MySqlCommand cmd = new MySqlCommand(query, Form1.conn);
            cmd.Parameters.AddWithValue("@tc", txt_yönetici_tc.Text);
            cmd.Parameters.AddWithValue("@isim", txt_yönetici_isim.Text);
            cmd.Parameters.AddWithValue("@soy_isim", txt_yönetici_soyisim.Text);
            cmd.Parameters.AddWithValue("@rutbe", rutbe);
            cmd.Parameters.AddWithValue("@sifre", txt_yönetici_sifre.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Yönetici kaydı başarılı.");



            Form1.conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        int id = Convert.ToInt32(row.Cells["id"].Value);
                        string silQuery = "DELETE FROM ogrenciler WHERE id = @id";
                        MySqlCommand cmd = new MySqlCommand(silQuery, Form1.conn);
                        cmd.Parameters.AddWithValue("@id", id);

                        Form1.conn.Open();
                        cmd.ExecuteNonQuery();
                        Form1.conn.Close();

                     
                        dataGridView1.Rows.Remove(row);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz satırı seçin.");
            }
        }
    }
}
