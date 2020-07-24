using MySql.Data.MySqlClient;
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
    public partial class frm_doktor_giris : Form
    {
        public frm_doktor_giris()
        {
            InitializeComponent();
        }

        db veri = new db();
        int i;

        void showdata()
        {
            if (veri.baglanti_kontrol() == false)
            {
                MessageBox.Show("Bağlantı Hatası Oluştu Lüften Tekrardan Deneyiniz", "Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();
            }
            else
            {
                veri.da = new MySqlDataAdapter("Select isim AS 'İsim',kullanici_adi AS 'Kullanıcı Adı' from kullanicilar Where gorevi = '0'", veri.baglanti);
                veri.dt = new DataTable();
                veri.da.Fill(veri.dt);
                doktor_grid.DataSource = veri.dt;
                veri.baglanti.Close();
            }
        }

        private void frm_doktor_giris_Load(object sender, EventArgs e)
        {
            lbl_doktor_isim.Text = "";
            showdata();
        }

        private void doktor_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbl_doktor_isim.Text = doktor_grid.Rows[e.RowIndex].Cells[0].Value.ToString();
            lbl_user.Text = doktor_grid.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            veri.baglanti.Open();
            try
            {
                veri.cmd = new MySqlCommand("SELECT * FROM `kullanicilar` WHERE kullanici_adi = '" + lbl_user.Text + "' and sifre = '" + txt_sifre.Text + "'", veri.baglanti);
                veri.dr = veri.cmd.ExecuteReader();

                if (veri.dr.Read())
                {
                    this.Hide();
                    veri.baglanti.Close();
                    frm_doktor frmdoktor = new frm_doktor();
                    frmdoktor.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Şifre Yanlış. Lütfen Tekrardan Deneyiniz!!!");
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

        private void btn_geri_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
