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
    public partial class UrunFiyatGuncelle : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-RM8PVLK\\SQLEXPRESS02; initial catalog=Proje; Integrated Security=TRUE");
        public UrunFiyatGuncelle()
        {
            InitializeComponent();
        }

        private void UrunFiyatGuncelle_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'projeDataSet.Urun_Listesi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.urun_ListesiTableAdapter.Fill(this.projeDataSet.Urun_Listesi);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * From Urun_Listesi where Barkod='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'", con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            cmd.Dispose();
            if (reader.Read())
            {
                cmd = new SqlCommand("Update Urun_Listesi set Urun_Fiyat='" + textBox1.Text.ToString() + "' where Barkod='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'", con);
                reader.Close();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Fiyat Başarıyla Güncellendi!");
                cmd.Dispose();

            }
            con.Close();
            dataGridView1.ClearSelection();
            this.urun_ListesiTableAdapter.Fill(this.projeDataSet.Urun_Listesi);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
