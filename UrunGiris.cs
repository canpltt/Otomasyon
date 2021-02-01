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
    public partial class UrunGiris : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-RM8PVLK\\SQLEXPRESS02; initial catalog=Proje; Integrated Security=TRUE");
        public UrunGiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand komut = new SqlCommand("insert into Urun_Listesi(Barkod,Urun_Adi,Stok,Urun_Fiyat) values('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + textBox4.Text.ToString() + "')", con);
            komut.ExecuteNonQuery();
            con.Close();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

        }
    }
}
