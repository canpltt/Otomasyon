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
    public partial class PersonelSifreDegistir : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-RM8PVLK\\SQLEXPRESS02; initial catalog=Proje; Integrated Security=TRUE");
        public PersonelSifreDegistir()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Kullanici_Listesi where Sicil='"+PersonalLogin.Sicil.ToString()+"'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            cmd.Dispose();
            while (dr.Read())
            {
                if (textBox1.Text == dr["Sifre"].ToString())
                {
                    if (textBox2.Text == textBox3.Text)
                    {
                        dr.Close();
                        cmd = new SqlCommand("Update Kullanici_Listesi set Sifre='" + textBox2.Text.ToString() + "'", con);
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        MessageBox.Show("Şifre Başarıyla Güncellendi!");
                        con.Close();
                        break;
                    }
                    else MessageBox.Show("Şifreler Uyuşmuyor!");
                    con.Close();
                    break;
                }
                else MessageBox.Show("Girilen Şifre Eski Şifreyle Uyuşmuyor!");
                con.Close();
                break;
            }
        }
    }
}
