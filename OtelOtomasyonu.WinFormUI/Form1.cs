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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void birimTipleriToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        BirimTipForm bt = new BirimTipForm();
        private void birimTipleriToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (bt.IsDisposed)
                bt = new BirimTipForm();
            bt.MdiParent = this;
            bt.Show();
        }
        KasaForm kf = new KasaForm();
        private void kasaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (kf.IsDisposed)
                kf = new KasaForm();
            kf.MdiParent = this;
            kf.Show();
        }

        KategoriForm ktg = new KategoriForm();
        private void kategorilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ktg.IsDisposed)
                ktg = new KategoriForm();
            ktg.MdiParent = this;
            ktg.Show();

        }
        OdalarForm of = new OdalarForm();
        private void odalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (of.IsDisposed)
            {
                of = new OdalarForm();
            }
            of.MdiParent = this;
            of.Show();

        }
        OdaOzellikForm ozellikForm = new OdaOzellikForm();

        private void odaÖzellikleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ozellikForm.IsDisposed)
                ozellikForm = new OdaOzellikForm();
            ozellikForm.MdiParent = this;
            ozellikForm.Show();
        }

        OzelliklerForm ozell = new OzelliklerForm();
        private void özellikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ozell.IsDisposed)
                ozell = new OzelliklerForm();
            ozell.MdiParent = this;
            ozell.Show();

            
        }

        OdaTurleriForm oTur = new OdaTurleriForm();
        private void odaTüeleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (oTur.IsDisposed)
                oTur = new OdaTurleriForm();
            oTur.MdiParent = this;
            oTur.Show();
        }
        MusteriForm mf = new MusteriForm();

        private void müşterilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mf.IsDisposed)
                mf = new MusteriForm();
            mf.MdiParent = this;
            mf.Show();
        }

        PersonellerForm pf = new PersonellerForm();
        private void personellerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pf.IsDisposed)
                pf = new PersonellerForm();
            pf.MdiParent = this;
            pf.Show();
        }
        SatisForm sf = new SatisForm();
        private void satışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sf.IsDisposed)
                sf = new SatisForm();
            sf.MdiParent = this;
            sf.Show();
        }
        UrunForm uf = new UrunForm();
        private void urunlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (uf.IsDisposed)
                uf = new UrunForm();
            uf.MdiParent = this;
            uf.Show();
        }
    }
}
