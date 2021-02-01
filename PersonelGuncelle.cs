using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magazacilik_Otomasyonu
{
    public partial class PersonelGuncelle : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-RM8PVLK\\SQLEXPRESS02; initial catalog=Proje; Integrated Security=TRUE");
        public PersonelGuncelle()
        {
            InitializeComponent();
        }

        private void PersonelGuncelle_Load(object sender, EventArgs e)
        {
            this.kullanici_ListesiTableAdapter1.Fill(this.projeDataSet2.Kullanici_Listesi);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * From Kullanici_Listesi where Sicil='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'", con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            cmd.Dispose();
            if (reader.Read())
            {
                cmd = new SqlCommand("Update Kullanici_Listesi set Sicil='" + textBox1.Text.ToString() + "',Sifre='"+textBox2.Text.ToString()+ "',Ad='" + textBox3.Text.ToString() + "',Soyad='" + textBox4.Text.ToString() + "',Telefon_No='" + textBox5.Text.ToString() + "',Mail='" + textBox6.Text.ToString() + "' where Sicil='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'", con);
                reader.Close();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Personel Kaydı Başarıyla Güncellendi!");
                cmd.Dispose();

            }
            con.Close();
            dataGridView1.ClearSelection();
            this.kullanici_ListesiTableAdapter1.Fill(this.projeDataSet2.Kullanici_Listesi);
        }
    }
}
