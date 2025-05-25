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
                string oda=secilen.Split("-")[0].Trim();

                string query = "UPDATE ogrenciler SET oda =@oda WHERE id = @id";
                using (MySqlCommand cmd = new MySqlCommand(query, Form1.conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@oda",oda);
                    cmd.ExecuteNonQuery();
                }
            }

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
                    checkedList.Items.Add(id+"-"+oda);
                }
            }
        }
        private void yonetici_ana_menu_Load(object sender, EventArgs e)
        {

        }
    }
}
