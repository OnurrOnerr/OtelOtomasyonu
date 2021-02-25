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
    public partial class OdalarForm : Form
    {
        public OdalarForm()
        {
            InitializeComponent();
        }

        private void OdalarForm_Load(object sender, EventArgs e)
        {
            Listele();

            cmbOdaTuru.DataSource = otOrm.Select();
            cmbOdaTuru.DisplayMember = "Adi";
            cmbOdaTuru.ValueMember = "Id";
        }

        OdalarORM oOrm = new OdalarORM();
        OdaTurleriORM otOrm = new OdaTurleriORM();


        void Listele()
        {
            dataGridView1.DataSource = oOrm.Select();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Odalar o = new Odalar();
            o.Aciklama = txtAciklama.Text;
            o.Adi = txtOdaAdi.Text;
            o.OdaTurID = (int)cmbOdaTuru.SelectedValue;

            bool etk = oOrm.Insert(o);
            if (etk)
            {
                Listele();
                MessageBox.Show("Ok");
            }
            else
                MessageBox.Show("Nok");
            txtAciklama.Clear();
            txtOdaAdi.Clear();
        }
    }
}
