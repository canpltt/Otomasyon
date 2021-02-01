using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magazacilik_Otomasyonu
{
    public partial class PersonelGoruntule : Form
    {
        public PersonelGoruntule()
        {
            InitializeComponent();
        }

        private void PersonelGoruntule_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'projeDataSet2.Kullanici_Listesi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kullanici_ListesiTableAdapter1.Fill(this.projeDataSet2.Kullanici_Listesi);
            dataGridView1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            this.kullanici_ListesiTableAdapter.Fill(this.projeDataSet1.Kullanici_Listesi);
        }
    }
}
