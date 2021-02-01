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
    public partial class AdminMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public AdminMain()
        {
            InitializeComponent();
        }

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void AdminMain_Load(object sender, EventArgs e)
        {
            label1.Text = "Hoşgeldin " + AdminLogin.Ad.ToString() + " " + AdminLogin.Soyad.ToString();
            Anasayfa frm = new Anasayfa();
            frm.MdiParent = this;
            frm.Show();

        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            KasiyerAvansGiris frm = new KasiyerAvansGiris();
            frm.MdiParent = this;
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginMain frm = new LoginMain();
            frm.Show();
            this.Hide();
        }

        private void barButtonItem18_ItemClick(object sender, ItemClickEventArgs e)
        {
            KasiyerAvansKontrol frm = new KasiyerAvansKontrol();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            KasiyerGirisKontrol frm = new KasiyerGirisKontrol();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
        {
            UrunGoruntule frm = new UrunGoruntule();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            UrunGiris frm = new UrunGiris();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            UrunStokGuncelle frm = new UrunStokGuncelle();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            UrunFiyatGuncelle frm = new UrunFiyatGuncelle();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            PersonelGoruntule frm = new PersonelGoruntule();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            PersonelEkle frm = new PersonelEkle();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            PersonelGuncelle frm = new PersonelGuncelle();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            PersonelSil frm = new PersonelSil();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem16_ItemClick(object sender, ItemClickEventArgs e)
        {
            YoneticiGoruntule frm = new YoneticiGoruntule();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem15_ItemClick(object sender, ItemClickEventArgs e)
        {
            YoneticiEkle frm = new YoneticiEkle();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem14_ItemClick(object sender, ItemClickEventArgs e)
        {
            YoneticiGuncelle frm = new YoneticiGuncelle();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}