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
    public partial class OdaOzellikForm : Form
    {
        public OdaOzellikForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void OdaOzellikForm_Load(object sender, EventArgs e)
        {
            OdalarORM odaOrm = new OdalarORM();
            cmbOdalar.DataSource = odaOrm.Select();
            cmbOdalar.DisplayMember = "Adi";
            cmbOdalar.ValueMember = "Id";

            OzelliklerORM ozellikOrm = new OzelliklerORM();
            listOzellikler.DataSource = ozellikOrm.Select();
            listOzellikler.DisplayMember = "Adi";
            listOzellikler.ValueMember = "Id";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            OdaOzellikleriORM odaOzelOrm = new OdaOzellikleriORM();

            OdaOzellikleri oz = new OdaOzellikleri();
            oz.OdaID = (int)cmbOdalar.SelectedValue;
            oz.OzellikID = (int)listOzellikler.SelectedValue;
            short deger;
            if (short.TryParse(txtDeger.Text,out deger))
            {
                oz.Deger = deger;
            }
            

            bool sonuc = odaOzelOrm.Insert(oz);
            if (sonuc)
            {
                MessageBox.Show("Odaya Seçilen özellik Eklenmiştir");
            }
            else
                MessageBox.Show("Hata Oluştu");
        }
    }
}
