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
    public partial class frm_hasta_kayit : Form
    {
        public frm_hasta_kayit()
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
                veri.da = new MySqlDataAdapter("Select * from hastalar", veri.baglanti);
                veri.dt = new DataTable();
                veri.da.Fill(veri.dt);
                hasta_grid.DataSource = veri.dt;
                veri.baglanti.Close();
            }
        }

        private void frm_hasta_kayit_Load(object sender, EventArgs e)
        {
            showdata();
        }

        private void btn_hasta_kayit_Click(object sender, EventArgs e)
        {
            if (txt_tc.TextLength == 11)
            {
                if (txt_tc.Text == "" || txt_adi.Text == "" || txt_soyadi.Text == "" || txt_dogum_tarih.Text == "" || txt_dogum_yeri.Text == "" || txt_tel.Text == "" || txt_adres.Text == "" || cmb_cinsiyet.SelectedItem == "" || cmb_il.SelectedItem == "")
                {
                    MessageBox.Show("Gerekli Yerleri Doldurunuz!!!", "Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    try
                    {
                        veri.baglanti.Open();
                        veri.cmd.Connection = veri.baglanti;
                        veri.cmd.CommandText = "INSERT INTO hastalar(tc_kimlik,seri,no,adi,soyadi,baba_adi,anne_adi,dogum_yeri,dogum_tarihi,medeni_durum,dini,kan_grubu,ot_il,ot_ilce,mahalle,cilt_no,aile_sira_no,sira_no,cinsiyet,tel,adres)VALUES('" + txt_tc.Text + "','" + txt_seri.Text + "','" + txt_no.Text + "','" + txt_adi.Text + "','" + txt_soyadi.Text + "','" + txt_baba_adi.Text + "','" + txt_anne_adi.Text + "','" + txt_dogum_yeri.Text + "','" + txt_dogum_tarih.Text + "','" + txt_medeni_hali.Text + "','" + txt_dini.Text + "','" + txt_kan_grubu.Text + "','" + cmb_il.SelectedItem + "','" + txt_ilce.Text + "','" + txt_mahalle.Text + "','" + txt_cilt_no.Text + "','" + txt_aile_sıra.Text + "','" + txt_sıra_no.Text + "','" + cmb_cinsiyet.SelectedItem + "','" + txt_tel.Text + "','" + txt_adres.Text + "')";
                        i = veri.cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            veri.baglanti.Close();
                            showdata();
                        }
                        else
                        {
                            MessageBox.Show("Kayıt İşlemi Sırasında Bir Hata Oluştu!!!", "Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            veri.baglanti.Close();
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Kayıt İşlemi Sırasında Bir Hata Oluştu!!!", "Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        veri.baglanti.Close();
                    }
                }
            }
        }

        private void btn_hasta_guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                veri.baglanti.Open();
                veri.cmd.Connection = veri.baglanti;
                veri.cmd.CommandText = "UPDATE hastalar SET tc_kimlik = '" + txt_tc.Text + "',seri = '" + txt_seri.Text + "',no = '" + txt_no.Text + "',adi = '" + txt_adi.Text + "',soyadi = '" + txt_soyadi.Text + "',baba_adi = '" + txt_baba_adi.Text + "',anne_adi = '" + txt_anne_adi.Text + "',dogum_yeri = '" + txt_dogum_yeri.Text + "',dogum_tarihi = '" + txt_dogum_tarih.Text + "',medeni_durum = '" + txt_medeni_hali.Text + "',dini = '" + txt_dini.Text + "',kan_grubu = '" + txt_kan_grubu.Text + "',ot_il = '" + cmb_il.SelectedItem + "',ot_ilce = '" + txt_ilce.Text + "',mahalle = '" + txt_mahalle.Text + "',cilt_no = '" + txt_cilt_no.Text + "',aile_sira_no = '" + txt_aile_sıra.Text + "',sira_no = '" + txt_sıra_no.Text + "',cinsiyet = '" + cmb_cinsiyet.SelectedItem + "',tel = '" + txt_tel.Text + "',adres = '" + txt_adres.Text + "' WHERE id= '" + hasta_grid.SelectedRows[0].Cells[0].Value + "'";
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
                MessageBox.Show("Güncelleme İşlemi Sırasında Bir Hata Oluştu!!!", "Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_hasta_sil_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("Hastayı Silmek İsteğinizden Emin Misiniz ?", "Uyarı Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (secenek == DialogResult.Yes)
            {
                try
                {
                    veri.baglanti.Open();
                    veri.cmd.Connection = veri.baglanti;
                    veri.cmd.CommandText = "DELETE FROM hastalar WHERE id=" + hasta_grid.SelectedRows[0].Cells[0].Value;
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

        private void btn_tc_sorgula_Click(object sender, EventArgs e)
        {
            if (txt_tc_sorgu.TextLength != 11)
            {
                MessageBox.Show("TC Kimlik 11 Karakter Olmalıdır!!!", "Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txt_hasta_ara_TextChanged(object sender, EventArgs e)
        {
            veri.da = new MySqlDataAdapter("Select * from hastalar where tc_kimlik like'%" + txt_hasta_ara.Text + "%' or adi like'%" + txt_hasta_ara.Text + "%' or soyadi like'%" + txt_hasta_ara.Text + "%'", veri.baglanti);
            veri.dt = new DataTable();
            veri.da.Fill(veri.dt);
            hasta_grid.DataSource = veri.dt;
        }

        private void hasta_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_tc.Text = hasta_grid.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_seri.Text = hasta_grid.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_no.Text = hasta_grid.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_adi.Text = hasta_grid.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_soyadi.Text = hasta_grid.Rows[e.RowIndex].Cells[5].Value.ToString();
            txt_baba_adi.Text = hasta_grid.Rows[e.RowIndex].Cells[6].Value.ToString();
            txt_anne_adi.Text = hasta_grid.Rows[e.RowIndex].Cells[7].Value.ToString();
            txt_dogum_yeri.Text = hasta_grid.Rows[e.RowIndex].Cells[8].Value.ToString();
            txt_dogum_tarih.Text = hasta_grid.Rows[e.RowIndex].Cells[9].Value.ToString();
            txt_medeni_hali.Text = hasta_grid.Rows[e.RowIndex].Cells[10].Value.ToString();
            txt_dini.Text = hasta_grid.Rows[e.RowIndex].Cells[11].Value.ToString();
            txt_kan_grubu.Text = hasta_grid.Rows[e.RowIndex].Cells[12].Value.ToString();
            cmb_il.SelectedItem = hasta_grid.Rows[e.RowIndex].Cells[13].Value.ToString();
            txt_ilce.Text = hasta_grid.Rows[e.RowIndex].Cells[14].Value.ToString();
            txt_mahalle.Text = hasta_grid.Rows[e.RowIndex].Cells[15].Value.ToString();
            txt_cilt_no.Text = hasta_grid.Rows[e.RowIndex].Cells[16].Value.ToString();
            txt_aile_sıra.Text = hasta_grid.Rows[e.RowIndex].Cells[17].Value.ToString();
            txt_sıra_no.Text = hasta_grid.Rows[e.RowIndex].Cells[18].Value.ToString();
            cmb_cinsiyet.SelectedItem = hasta_grid.Rows[e.RowIndex].Cells[19].Value.ToString();
            txt_tel.Text = hasta_grid.Rows[e.RowIndex].Cells[20].Value.ToString();
            txt_adres.Text = hasta_grid.Rows[e.RowIndex].Cells[21].Value.ToString();

        }
    }
}
