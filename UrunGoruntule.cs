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
    public partial class UrunGoruntule : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-RM8PVLK\\SQLEXPRESS02; initial catalog=Proje; Integrated Security=TRUE");
        public UrunGoruntule()
        {
            InitializeComponent();
        }

        private void UrunGoruntule_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'projeDataSet10.Urun_Listesi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.urun_ListesiTableAdapter.Fill(this.projeDataSet10.Urun_Listesi);

        }
    }
}
