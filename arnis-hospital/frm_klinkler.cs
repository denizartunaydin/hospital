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
    public partial class frm_klinkler : Form
    {
        public frm_klinkler()
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
                veri.da = new MySqlDataAdapter("Select id AS 'Klinik ID',klinik_isim AS 'Klinik İsim' from klinikler", veri.baglanti);
                veri.dt = new DataTable();
                veri.da.Fill(veri.dt);
                klinik_grid.DataSource = veri.dt;
                veri.baglanti.Close();
            }
        }

        private void frm_klinkler_Load(object sender, EventArgs e)
        {
            showdata();
        }

        private void btn_klinik_kayit_Click(object sender, EventArgs e)
        {
            try
            {
                veri.baglanti.Open();
                veri.cmd.Connection = veri.baglanti;
                veri.cmd.CommandText = "INSERT INTO klinikler(klinik_isim)VALUES('" + txt_klinik.Text + "')";
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

        private void btn_klinik_duzenle_Click(object sender, EventArgs e)
        {
            try
            {
                veri.baglanti.Open();
                veri.cmd.Connection = veri.baglanti;
                veri.cmd.CommandText = "UPDATE klinikler SET klinik_isim = '" + txt_klinik.Text + "' WHERE id= " + Convert.ToDouble(klinik_grid.SelectedRows[0].Cells[0].Value) + "";
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

        private void btn_klinik_sil_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("Kliniği Silmek İsteğinizden Emin Misiniz ?", "Uyarı Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (secenek == DialogResult.Yes)
            {
                try
                {
                    veri.baglanti.Open();
                    veri.cmd.Connection = veri.baglanti;
                    veri.cmd.CommandText = "DELETE FROM klinikler WHERE id=" + klinik_grid.SelectedRows[0].Cells[0].Value;
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

        private void txt_klinik_ara_TextChanged(object sender, EventArgs e)
        {
            veri.da = new MySqlDataAdapter("Select id AS 'Klinik ID',klinik_isim AS 'Klinik İsim' from klinikler where klinik_isim like'%" + txt_klinik_ara.Text + "%'", veri.baglanti);
            veri.dt = new DataTable();
            veri.da.Fill(veri.dt);
            klinik_grid.DataSource = veri.dt;
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            txt_klinik.Text = "";
            txt_klinik_ara.Text = "";
        }

        private void klinik_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_klinik.Text = klinik_grid.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
