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
    public partial class PersonelSil : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-RM8PVLK\\SQLEXPRESS02; initial catalog=Proje; Integrated Security=TRUE");
        public PersonelSil()
        {
            InitializeComponent();
        }

        private void PersonelSil_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'projeDataSet2.Kullanici_Listesi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kullanici_ListesiTableAdapter.Fill(this.projeDataSet2.Kullanici_Listesi);

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
            con.Open();
            SqlCommand komut = new SqlCommand("delete from Kullanici_Listesi where Sicil='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'", con);
            komut.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Kayıt Başarıyla Silindi!");
            dataGridView1.ClearSelection();
            this.kullanici_ListesiTableAdapter.Fill(this.projeDataSet2.Kullanici_Listesi);
        }
    }
}
