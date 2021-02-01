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
    public partial class PersonelGirisKontrol : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-RM8PVLK\\SQLEXPRESS02; initial catalog=Proje; Integrated Security=TRUE");
        public PersonelGirisKontrol()
        {
            InitializeComponent();
        }

        private void PersonelGirisKontrol_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'projeDataSet9.Kasiyer_Giris' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kasiyer_GirisTableAdapter.Fill(this.projeDataSet9.Kasiyer_Giris);

            con.Open();
            string kayit = "SELECT Kasiyer_Adi, Kasiyer_Soyadi, ikiyuztl, yuztl, ellitl, yirmitl, ontl, bestl, birtl, ellikrs, yirmibeskrs, onkrs, beskrs, birkrs from Kasiyer_Giris where Kasiyer_Adi='" + PersonalLogin.Ad.ToString() + "'";
            SqlCommand komut = new SqlCommand(kayit, con);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }
    }
}
