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
    public partial class KasaGiris : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-RM8PVLK\\SQLEXPRESS02; initial catalog=Proje; Integrated Security=TRUE");
        public KasaGiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand komut = new SqlCommand("insert into Kasiyer_Giris(Kasiyer_Adi,Kasiyer_Soyadi,ikiyuztl,yuztl,ellitl,yirmitl,ontl,bestl,birtl,ellikrs,yirmibeskrs,onkrs,beskrs,birkrs) values('" + PersonalLogin.Ad.ToString() + "','" + PersonalLogin.Soyad.ToString() + "','" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + textBox4.Text.ToString() + "','" + textBox5.Text.ToString() + "','" + textBox6.Text.ToString() + "','" + textBox7.Text.ToString() + "','" + textBox8.Text.ToString() + "','" + textBox9.Text.ToString() + "','" + textBox10.Text.ToString() + "','" + textBox11.Text.ToString() + "','" + textBox12.Text.ToString() + "')", con);
            komut.ExecuteNonQuery();
            con.Close();
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox6.Text = "0";
            textBox7.Text = "0";
            textBox8.Text = "0";
            textBox9.Text = "0";
            textBox10.Text = "0";
            textBox11.Text = "0";
            textBox12.Text = "0";
        }
    }
}
