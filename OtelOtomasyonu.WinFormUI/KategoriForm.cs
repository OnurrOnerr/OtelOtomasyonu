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
    public partial class KategoriForm : Form
    {
        public KategoriForm()
        {
            InitializeComponent();
        }

        KategoriORM orm = new KategoriORM();


        private void button1_Click(object sender, EventArgs e)
        {
            Kategoriler k = new Kategoriler();
            k.Adi = textBox1.Text;
            bool sonuc = orm.Insert(k);
            if (sonuc)
            {
                MessageBox.Show("Kayıt Eklenmiştir");
                dataGridView1.DataSource = orm.Select();
            }
            else
                MessageBox.Show("Hata Oluştu");

        }

        private void KategoriForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = orm.Select();
        }
    }
}
