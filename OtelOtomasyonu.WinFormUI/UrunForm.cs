using OtelOtomasyonu.ORM.Entity;
using OtelOtomasyonu.ORM.Facade;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelOtomasyonu.WinFormUI
{
    public partial class UrunForm : Form
    {
        public UrunForm()
        {
            InitializeComponent();
        }

        UrunORM uOrm = new UrunORM();
        KategoriORM kOrm = new KategoriORM();
        BirimTipORM bOrm = new BirimTipORM();

        private void UrunForm_Load(object sender, EventArgs e)
        {
            cmbBirim.DataSource = bOrm.Select();
            cmbBirim.ValueMember = "Id";
            cmbBirim.DisplayMember = "Adi";

            cmbKategori.DataSource = kOrm.Select();
            cmbKategori.ValueMember= "Id";
            cmbKategori.DisplayMember= "Adi";

            dataGridView1.DataSource = uOrm.Select();

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Urunler u = new Urunler();

            u.Adi = txtAdi.Text;
            u.Fiyat = nudFiyat.Value;
            u.Miktar = (double)nudMiktar.Value;

            u.BirimTipID = (int)cmbBirim.SelectedValue;
            u.KategoriID = (int)cmbKategori.SelectedValue;

            bool sonuc = uOrm.Insert(u);
            if (sonuc)
            {
                MessageBox.Show("Kayıt Eklenmiştir");
                dataGridView1.DataSource = uOrm.Select();
            }
            else
                MessageBox.Show("Hata");


        }
    }
}
