using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arnis_hospital
{
    public partial class frm_ana : Form
    {
        public frm_ana()
        {
            InitializeComponent();
        }

        private void kullanıcıİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_kullanicilar kullanicilar = new frm_kullanicilar();
            kullanicilar.ShowDialog();
        }

        private void doktorTanımlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_doktor_kayit doktorkayit = new frm_doktor_kayit();
            doktorkayit.ShowDialog();
        }

        private void kullanıcıDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_giris frmgiris = new frm_giris();
            frmgiris.Show();
            this.Hide();
        }

        private void çıkışToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frm_ana_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void hastaKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_hasta_kayit frmhastakayit = new frm_hasta_kayit();
            frmhastakayit.ShowDialog();
        }

        private void randevuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_randevu frmrandevu = new frm_randevu();
            frmrandevu.ShowDialog();
        }

        private void doktorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_doktor_giris frmdoktorgiris = new frm_doktor_giris();
            frmdoktorgiris.ShowDialog();
        }

        private void raporlarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hakkımdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_hakkimda hakkimda = new frm_hakkimda();
            hakkimda.Show();
        }
    }
}
