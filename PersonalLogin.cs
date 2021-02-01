using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Magazacilik_Otomasyonu
{
    public partial class PersonalLogin : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-RM8PVLK\\SQLEXPRESS02; initial catalog=Proje; Integrated Security=TRUE");
        public static string Sicil, Ad, Soyad,Sifre;
        public PersonalLogin()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string Kullanici_Adi = textBox1.Text;
            string Sifre = textBox2.Text;
            bool kayitlimi = false;
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Kullanici_Listesi", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (Kullanici_Adi == dr["Sicil"].ToString() && Sifre == dr["Sifre"].ToString())
                {
                    kayitlimi = true;
                    Ad = dr["Ad"].ToString();
                    Soyad = dr["Soyad"].ToString();
                    Sicil = dr["Sicil"].ToString();
                    Sifre = dr["Sifre"].ToString();
                    break;
                }
            }
            con.Close();
            if (kayitlimi == true)
            {
                PersonelLogin main = new PersonelLogin();
                main.Show();
                this.Hide();
            }
            else MessageBox.Show("Kullanıcı Adı veya Şifre Hatalıdır!");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yöneticinizle İletişime Geçiniz!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminMain a = new AdminMain();
            a.Show();
            this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            AdminMain a = new AdminMain();
            a.Show();
            this.Hide();
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            LoginMain frm = new LoginMain();
            frm.Show();
            this.Hide();
        }
    }
}