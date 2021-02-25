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
    public partial class GirisYapForm : Form
    {
        public GirisYapForm()
        {
            InitializeComponent();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            PersonellerORM orm = new PersonellerORM();
            Personeller p = new Personeller();
            p.KullaniciAdi = txtKullaniciAdi.Text;
            p.Parola = txtParola.Text;
            Personeller aktif = orm.GirisYap(p);
            if (aktif==null)
            {
                MessageBox.Show("Kullanıcı Adı Yada Parola yanlış");
            }
            else
            {
                PersonellerORM.AktifKullanici = aktif;
                Form1 f = new Form1();
                this.Hide();
                f.ShowDialog();
            }

        }
    }
}
