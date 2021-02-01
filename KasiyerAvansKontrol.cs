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
    public partial class KasiyerAvansKontrol : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-RM8PVLK\\SQLEXPRESS02; initial catalog=Proje; Integrated Security=TRUE");
        public KasiyerAvansKontrol()
        {
            InitializeComponent();
        }
        public void AvansGoruntule()
        {
            con.Open();
            SqlCommand komut = new SqlCommand("Select * From Kasiyer_Avans", con);
            SqlDataReader oku = komut.ExecuteReader();
            while(oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Kasiyer_Adi"].ToString();
                ekle.SubItems.Add(oku["ikiyuztl"].ToString());
                ekle.SubItems.Add(oku["yuztl"].ToString());
                ekle.SubItems.Add(oku["ellitl"].ToString());
                ekle.SubItems.Add(oku["yirmitl"].ToString());
                ekle.SubItems.Add(oku["ontl"].ToString());
                ekle.SubItems.Add(oku["bestl"].ToString());
                ekle.SubItems.Add(oku["birtl"].ToString());
                ekle.SubItems.Add(oku["ellikrs"].ToString());
                ekle.SubItems.Add(oku["yirmibeskrs"].ToString());
                ekle.SubItems.Add(oku["onkrs"].ToString());
                ekle.SubItems.Add(oku["beskrs"].ToString());
                ekle.SubItems.Add(oku["birkrs"].ToString());
                listView1.Items.Add(ekle);
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AvansGoruntule();
        }
    }
}
