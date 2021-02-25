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
    public partial class MusteriForm : Form
    {
        public MusteriForm()
        {
            InitializeComponent();
        }

        MusteriORM orm = new MusteriORM();
        private void MusteriForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = orm.Select();
            cmbMedeniDurum.DataSource = Enum.GetNames(typeof(MedeniDurumTip) );
            cmbCinsiyet.DataSource = Enum.GetNames(typeof(Cinsiyet));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Musteriler m = new Musteriler();
            m.Adi = txtAdi.Text;
            m.Soyadi = txtSoyadi.Text;
            m.SirketAdi = txtSirketAdi.Text;
            m.Tckn = mskdTckn.Text;
            m.TelNo = mskdTelefon.Text;
            m.DogumTarihi = dtpdogumTarihi.Value;

            m.MedeniDurumu = (MedeniDurumTip)Enum.Parse(typeof(MedeniDurumTip), cmbMedeniDurum.SelectedItem.ToString());

            m.Cinsiyeti = (Cinsiyet)Enum.Parse(typeof(Cinsiyet), cmbCinsiyet.SelectedItem.ToString());

            bool sonuc = orm.Insert(m);
            if (sonuc)
            {
                dataGridView1.DataSource = orm.Select();
                MessageBox.Show("Müşteri eklenmiştir");
            }
            else
                MessageBox.Show("Müşteri ekleme sırasında hata oluştu");
        }
    }
}
