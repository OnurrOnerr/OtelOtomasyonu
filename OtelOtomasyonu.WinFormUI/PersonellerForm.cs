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
    public partial class PersonellerForm : Form
    {
        public PersonellerForm()
        {
            InitializeComponent();
        }
        PersonellerORM orm = new PersonellerORM();

        private void PersonellerForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = orm.Select();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Personeller p = new Personeller();
            p.Adi = txtAdi.Text;
            p.Soyadi = txtSoyadi.Text;
            p.Tckn = mskdTckn.Text;
            p.TelNo = mskdTelNo.Text;
            p.Adres = txtAdres.Text;
            p.DogumTarihi = dtpDogumTarihi.Value;
            p.IseGirisTarihi = dtpIseGiris.Value;
            p.Maas = nudMaas.Value;
            p.KullaniciAdi = txtKullaniciAdi.Text;
            p.Parola = txtParola.Text;

            bool sonuc = orm.Insert(p);
            if (sonuc)
            {
                MessageBox.Show("Persoenel Eklenmiştir");
                dataGridView1.DataSource = orm.Select();
            }
            else
                MessageBox.Show("Personel Ekleme Sırasında Hata");


        }
    }
}
