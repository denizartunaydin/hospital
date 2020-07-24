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
    public partial class frm_doktor_kayit : Form
    {
        public frm_doktor_kayit()
        {
            InitializeComponent();
        }

        private void frm_doktor_kayit_Load(object sender, EventArgs e)
        {

        }

        private void btn_doktor_sil_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("Doktoru Silmek İsteğinizden Emin Misiniz ?", "Uyarı Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (secenek == DialogResult.Yes)
            {
                //Hasta Silme İşlemleri Yapılcak
            }
        }
    }
}
