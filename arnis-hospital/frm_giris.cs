using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace arnis_hospital
{
    public partial class frm_giris : Form
    {
        public frm_giris()
        {
            InitializeComponent();
        }

        db veri = new db();

        private void frm_giris_Load(object sender, EventArgs e)
        {
            try
            {
                if (veri.baglanti_kontrol() == false)
                {
                    MessageBox.Show("Bağlantı Hatası Oluştu Lüften Tekrardan Deneyiniz", "Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
                else
                {
                    veri.cmd = new MySqlCommand("SELECT kullanici_adi FROM kullanicilar", veri.baglanti);
                    veri.dr = veri.cmd.ExecuteReader();
                    while (veri.dr.Read())
                    {
                        cmb_kullanici.Items.Add(veri.dr["kullanici_adi"]);
                    }
                    veri.baglanti.Close();
                }
            }
            catch (Exception)
            {

            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            veri.baglanti.Open();
            try
            {
                veri.cmd = new MySqlCommand("SELECT * FROM `kullanicilar` WHERE kullanici_adi = '" + cmb_kullanici.SelectedItem + "' and sifre = '" + txt_sifre.Text + "'", veri.baglanti);
                veri.dr = veri.cmd.ExecuteReader();

                if (veri.dr.Read())
                {
                    frm_ana frmana = new frm_ana();

                    switch (veri.dr["gorevi"].ToString())
                    {
                        case "0":
                            frmana.doktorToolStripMenuItem.Visible = true;
                            frmana.raporlarToolStripMenuItem.Visible = false;
                            break;
                        case "1":
                            frmana.ayarlarToolStripMenuItem.Visible = true;
                            frmana.kayıtToolStripMenuItem.Visible = true;
                            frmana.doktorToolStripMenuItem.Visible = true;
                            frmana.raporlarToolStripMenuItem.Visible = false;
                            break;
                        case "3":
                            frmana.kayıtToolStripMenuItem.Visible = true;
                            break;
                        default:
                            MessageBox.Show("Hatası Oluştu Lüften Tekrardan Deneyiniz", "Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;

                    }
                    frmana.kullaniciToolStripMenuItem.Text = "Hoşgeldin  " + veri.dr["isim"].ToString();
                    veri.baglanti.Close();
                    veri.baglanti.Dispose();
                    frmana.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Giriş yapmak için yetkiniz bulunmamaktadır!!!");
                    txt_sifre.Text = "";
                    veri.baglanti.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bir hata oluştu");
                veri.baglanti.Close();
            }
        }
    }
}
