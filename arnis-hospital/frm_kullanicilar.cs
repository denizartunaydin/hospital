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
    public partial class frm_kullanicilar : Form
    {
        public frm_kullanicilar()
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
                veri.da = new MySqlDataAdapter("Select id AS ID,isim AS İsim,kullanici_adi AS 'Kullanıcı Adı',sifre AS 'Kullanıcı Şifre',gorevi AS Rutbe from kullanicilar", veri.baglanti);
                veri.dt = new DataTable();
                veri.da.Fill(veri.dt);
                kullanici_grid.DataSource = veri.dt;
                veri.baglanti.Close();
            }
        }

        private void frm_kullanicilar_Load(object sender, EventArgs e)
        {
            showdata();
        }

        private void btn_kullanici_kayit_Click(object sender, EventArgs e)
        {
            try
            {
                veri.baglanti.Open();
                veri.cmd.Connection = veri.baglanti;
                veri.cmd.CommandText = "INSERT INTO kullanicilar(isim,kullanici_adi,sifre,gorevi)VALUES('" + txt_isim.Text + "','" + txt_kadi.Text + "','" + txt_ksifre.Text + "','" + cmb_gorev.SelectedIndex.ToString() + "')";
                i = veri.cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    veri.baglanti.Close();
                    showdata();
                }
                else
                {
                    MessageBox.Show("Kayıt İşlemi Sırasında Bir Hata Oluştu!!!");
                    veri.baglanti.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Kayıt İşlemi Sırasında Bir Hata Oluştu!!!");
                veri.baglanti.Close();
            }
        }

        private void btn_kullanici_sil_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("Kullanıcıyı Silmek İsteğinizden Emin Misiniz ?", "Uyarı Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (secenek == DialogResult.Yes)
            {
                try
                {
                    veri.baglanti.Open();
                    veri.cmd.Connection = veri.baglanti;
                    veri.cmd.CommandText = "DELETE FROM kullanicilar WHERE id=" + kullanici_grid.SelectedRows[0].Cells[0].Value;
                    i = veri.cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        veri.baglanti.Close();
                        showdata();
                    }

                }
                catch (Exception ex)
                {
                    veri.baglanti.Close();
                    MessageBox.Show("Silme İşlemi Sırasında Bir Hata Oluştu!!!");
                }
            }
        }

        private void btn_kullanici_duzenle_Click(object sender, EventArgs e)
        {
            try
            {
                veri.baglanti.Open();
                veri.cmd.Connection = veri.baglanti;//isim,kullanici_adi,sifre,gorevi
                veri.cmd.CommandText = "UPDATE kullanicilar SET isim = '" + txt_isim.Text + "', kullanici_adi = '" + txt_kadi.Text + "',sifre = '" + txt_ksifre.Text + "', gorevi = '" + cmb_gorev.SelectedIndex.ToString() + "' WHERE id= '" + kullanici_grid.SelectedRows[0].Cells[0].Value + "'";
                i = veri.cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    veri.baglanti.Close();
                    showdata();
                }
            }
            catch (Exception ex)
            {
                veri.baglanti.Close();
                MessageBox.Show("Güncelleme İşlemi Sırasında Bir Hata Oluştu!!!");
            }
        }

        private void txt_kullanici_ara_TextChanged(object sender, EventArgs e)
        {
            veri.da = new MySqlDataAdapter("Select id AS ID,isim AS İsim,kullanici_adi AS 'Kullanıcı Adı',sifre AS 'Kullanıcı Şifre',gorevi AS Rutbe from kullanicilar where kullanici_adi like'%" + txt_kullanici_ara.Text + "%' or isim like'%" + txt_kullanici_ara.Text + "%'", veri.baglanti);
            veri.dt = new DataTable();
            veri.da.Fill(veri.dt);
            kullanici_grid.DataSource = veri.dt;
        }

        private void kullanici_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_isim.Text = kullanici_grid.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_kadi.Text = kullanici_grid.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_ksifre.Text = kullanici_grid.Rows[e.RowIndex].Cells[3].Value.ToString();
            cmb_gorev.SelectedIndex = Convert.ToInt16(kullanici_grid.Rows[e.RowIndex].Cells[4].Value);
        }
    }
}
