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
    public partial class YoneticiGuncelle : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-RM8PVLK\\SQLEXPRESS02; initial catalog=Proje; Integrated Security=TRUE");
        public YoneticiGuncelle()
        {
            InitializeComponent();
        }

        private void YoneticiGuncelle_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'projeDataSet5.Yonetici_Listesi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.yonetici_ListesiTableAdapter.Fill(this.projeDataSet5.Yonetici_Listesi);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            comboBox1.SelectedItem= dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * From Yonetici_Listesi where Sicil='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'", con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            cmd.Dispose();
            if (reader.Read())
            {
                cmd = new SqlCommand("Update Yonetici_Listesi set Sicil='" + textBox1.Text.ToString() + "',Sifre='" + textBox2.Text.ToString() + "',Ad='" + textBox3.Text.ToString() + "',Soyad='" + textBox4.Text.ToString() + "',Telefon_No='" + textBox5.Text.ToString() + "',Mail='" + textBox6.Text.ToString() + "',Pozisyon='" + comboBox1.SelectedItem.ToString() +"' where Sicil='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'", con);
                reader.Close();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Yönetici Kaydı Başarıyla Güncellendi!");
                cmd.Dispose();

            }
            con.Close();
            dataGridView1.ClearSelection();
            this.yonetici_ListesiTableAdapter.Fill(this.projeDataSet5.Yonetici_Listesi);
        }
    }
}
