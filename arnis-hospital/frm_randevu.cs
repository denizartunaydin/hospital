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
    public partial class frm_randevu : Form
    {
        public frm_randevu()
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
                veri.da = new MySqlDataAdapter("SELECT randevular.id AS 'Randevu ID',tc_kimlik AS 'TC Kimlik',adi AS 'Adı',soyadi AS 'Soyadı',klinik_adi AS 'Poliklinik',doktor_adi AS 'Doktor İsmi',tarih AS 'Tarih',saat AS 'Saat',mua_tur AS 'Muayene Türü' FROM hastalar,randevular WHERE hastalar.tc_kimlik = randevular.tc and islem = 0", veri.baglanti);
                veri.dt = new DataTable();
                veri.da.Fill(veri.dt);
                randevu_grid.DataSource = veri.dt;
                veri.baglanti.Close();
                veri.baglanti.Dispose();
            }
        }
        void klinik_getir()
        {
            if (veri.baglanti_kontrol() == false)
            {
                MessageBox.Show("Bağlantı Hatası Oluştu Lüften Tekrardan Deneyiniz", "Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();
            }
            else
            {
                veri.cmd = new MySqlCommand("Select klinik_isim from klinikler", veri.baglanti);
                veri.dr = veri.cmd.ExecuteReader();
                while (veri.dr.Read())
                {
                    cmb_klinik.Items.Add(veri.dr["klinik_isim"]);
                }
                veri.baglanti.Close();
                veri.baglanti.Dispose();
            }
        }
        void doktor_getir()
        {
            if (veri.baglanti_kontrol() == false)
            {
                MessageBox.Show("Bağlantı Hatası Oluştu Lüften Tekrardan Deneyiniz", "Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();
            }
            else
            {
                veri.cmd = new MySqlCommand("SELECT CONCAT(adi,' ',soyadi) AS Doktor FROM doktorlar Where uzmanlik = '" + cmb_klinik.SelectedItem + "'", veri.baglanti);
                veri.dr = veri.cmd.ExecuteReader();
                while (veri.dr.Read())
                {
                    cmb_doktor.Items.Add(veri.dr["Doktor"]);
                }
                veri.baglanti.Close();
                veri.baglanti.Dispose();
            }
        }
        void hasta_getir()
        {
            if (veri.baglanti_kontrol() == false)
            {
                MessageBox.Show("Bağlantı Hatası Oluştu Lüften Tekrardan Deneyiniz", "Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();
            }
            else
            {
                veri.cmd = new MySqlCommand("SELECT tc_kimlik FROM hastalar", veri.baglanti);
                veri.dr = veri.cmd.ExecuteReader();
                while (veri.dr.Read())
                {
                    cmb_tc.Items.Add(veri.dr["tc_kimlik"]);
                }
                veri.baglanti.Close();
                veri.baglanti.Dispose();
            }
        }

        private void frm_randevu_Load(object sender, EventArgs e)
        {
            showdata();
            klinik_getir();
            hasta_getir();
        }

        private void cmb_klinik_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_doktor.Items.Clear();
            doktor_getir();
        }

        private void btn_randevu_kayit_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_tc.SelectedItem == "" || cmb_doktor.SelectedItem == "" || cmb_klinik.SelectedItem == "" || cmb_mua_tur.SelectedItem == "" || cmb_saat.SelectedItem == "")
                {
                    MessageBox.Show("Gerekli Yerleri Doldurunuz!!!", "Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    veri.baglanti.Open();
                    veri.cmd.Connection = veri.baglanti;
                    veri.cmd.CommandText = "INSERT INTO randevular(tc,klinik_adi,doktor_adi,tarih,saat,mua_tur)VALUES('" + cmb_tc.SelectedItem + "','" + cmb_klinik.SelectedItem + "','" + cmb_doktor.SelectedItem + "','" + tarih.Value.Date.ToString("yyyy-MM-dd") + "','" + cmb_saat.SelectedItem + "','" + cmb_mua_tur.SelectedItem + "')";
                    i = veri.cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Randevu Başarıyla Kaydedildi");
                        cmb_doktor.Text = "";
                        cmb_klinik.Text = "";
                        cmb_saat.Text = "";
                        veri.baglanti.Close();
                        veri.baglanti.Dispose();
                        showdata();
                    }
                    else
                    {
                        MessageBox.Show("Kayıt İşlemi Sırasında Bir Hata Oluştu!!!");
                        veri.baglanti.Close();
                        veri.baglanti.Dispose();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Kayıt İşlemi Sırasında Bir Hata Oluştu!!!");
                veri.baglanti.Close();
                veri.baglanti.Dispose();
            }
        }

        private void btn_randevu_sil_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("Randevuyu Silmek İsteğinizden Emin Misiniz ?", "Uyarı Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (secenek == DialogResult.Yes)
            {
                try
                {
                    veri.baglanti.Open();
                    veri.cmd.Connection = veri.baglanti;
                    veri.cmd.CommandText = "DELETE FROM randevular WHERE id=" + randevu_grid.SelectedRows[0].Cells[0].Value;
                    i = veri.cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        veri.baglanti.Close();
                        veri.baglanti.Dispose();
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

        private void randevu_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cmb_tc.SelectedItem = randevu_grid.Rows[e.RowIndex].Cells[1].Value.ToString();
            cmb_klinik.SelectedItem = randevu_grid.Rows[e.RowIndex].Cells[4].Value.ToString();
            cmb_doktor.Text = randevu_grid.Rows[e.RowIndex].Cells[5].Value.ToString();
            tarih.Text = randevu_grid.Rows[e.RowIndex].Cells[6].Value.ToString();
            cmb_saat.Text = randevu_grid.Rows[e.RowIndex].Cells[7].Value.ToString();
            cmb_mua_tur.SelectedItem = randevu_grid.Rows[e.RowIndex].Cells[8].Value.ToString();
        }

        private void btn_randevu_guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                veri.baglanti.Open();
                veri.cmd.Connection = veri.baglanti;
                veri.cmd.CommandText = "UPDATE randevular SET tc = '" + cmb_tc.SelectedItem + "',klinik_adi= '" + cmb_klinik.SelectedItem + "',doktor_adi = '" + cmb_doktor.SelectedItem + "',tarih = '" + tarih.Value.Date.ToString("yyyy-MM-dd") + "',saat = '" + cmb_saat.SelectedItem + "',mua_tur = '" + cmb_mua_tur.SelectedItem + "' WHERE id= '" + randevu_grid.SelectedRows[0].Cells[0].Value + "'";
                i = veri.cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    veri.baglanti.Close();
                    showdata();
                    veri.baglanti.Dispose();
                }
            }
            catch (Exception ex)
            {
                veri.baglanti.Close();
                veri.baglanti.Dispose();
                MessageBox.Show("Güncelleme İşlemi Sırasında Bir Hata Oluştu!!!", "Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            string sql = "SELECT randevular.id AS 'Randevu ID',tc_kimlik AS 'TC Kimlik',adi AS 'Adı',soyadi AS 'Soyadı',klinik_adi AS 'Poliklinik',doktor_adi AS 'Doktor İsmi',tarih AS 'Tarih',saat AS 'Saat',mua_tur AS 'Muayene Türü' FROM hastalar,randevular WHERE hastalar.tc_kimlik = randevular.tc and tarih BETWEEN '" + xtarih1.Value.Date.ToString("yyyy-MM-dd") + "' AND '" + xtarih2.Value.Date.ToString("yyyy-MM-dd") + "'";

            if (checkBox1.Checked == false)
            {
                sql = sql + "and islem = 0";
            }
            veri.da = new MySqlDataAdapter(sql, veri.baglanti);
            veri.dt = new DataTable();
            veri.dt.Clear();
            veri.da.Fill(veri.dt);
            randevu_grid.DataSource = veri.dt;
            veri.baglanti.Close();
            veri.baglanti.Dispose();
        }

        private void txt_tc_ara_TextChanged(object sender, EventArgs e)
        {
            veri.da = new MySqlDataAdapter("Select SELECT randevular.id AS 'Randevu ID',tc_kimlik AS 'TC Kimlik',adi AS 'Adı',soyadi AS 'Soyadı',klinik_adi AS 'Poliklinik',doktor_adi AS 'Doktor İsmi',tarih AS 'Tarih',saat AS 'Saat',mua_tur AS 'Muayene Türü'  from randevular,hastalar where tc like'%" + txt_tc_ara.Text + "%'", veri.baglanti);
            veri.dt = new DataTable();
            veri.da.Fill(veri.dt);
            randevu_grid.DataSource = veri.dt;
        }

        private void cmb_doktor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
