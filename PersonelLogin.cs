using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace Magazacilik_Otomasyonu
{
    public partial class PersonelLogin : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public PersonelLogin()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            KasaGiris frm = new KasaGiris();
            frm.MdiParent = this;
            frm.Show();
        }

        private void PersonelLogin_Load(object sender, EventArgs e)
        {
            label1.Text = "Hoşgeldin " + PersonalLogin.Ad.ToString() + " " + PersonalLogin.Soyad.ToString();
            Anasayfa frm = new Anasayfa();
            frm.MdiParent = this;
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginMain frm = new LoginMain();
            frm.Show();
            this.Hide();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            PersonelAvansKontrol frm = new PersonelAvansKontrol();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            PersonelGirisKontrol frm = new PersonelGirisKontrol();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            UrunGoruntule frm = new UrunGoruntule();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            PersonelSifreDegistir frm = new PersonelSifreDegistir();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}