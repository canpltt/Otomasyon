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
    public partial class YoneticiGoruntule : Form
    {
        public YoneticiGoruntule()
        {
            InitializeComponent();
        }

        private void YoneticiGoruntule_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'projeDataSet5.Yonetici_Listesi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.yonetici_ListesiTableAdapter2.Fill(this.projeDataSet5.Yonetici_Listesi);
            dataGridView1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            this.yonetici_ListesiTableAdapter2.Fill(this.projeDataSet5.Yonetici_Listesi);
        }
    }
}
