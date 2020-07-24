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
    public partial class frm_doktor : Form
    {
        public frm_doktor()
        {
            InitializeComponent();
            bekleyen_hasta_grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            bekleyen_hasta_grid.MultiSelect = false;
            bekleyen_hasta_grid.RowPrePaint += new DataGridViewRowPrePaintEventHandler(bekleyen_hasta_grid_RowPrePaint);
        }

        db veri = new db();
        int i;

        void bekleyen_hasta()
        {
            if (veri.baglanti_kontrol() == false)
            {
                MessageBox.Show("Bağlantı Hatası Oluştu Lüften Tekrardan Deneyiniz", "Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();
            }
            else
            {
                veri.da = new MySqlDataAdapter("SELECT randevular.id AS 'Randevu ID',tc_kimlik AS 'TC Kimlik',tarih AS 'Tarih',saat AS 'Saat',adi AS 'Adı',soyadi AS 'Soyadı',klinik_adi AS 'Poliklinik',doktor_adi AS 'Doktor İsmi',mua_tur AS 'Muayene Türü',randevular.durum AS 'Randevu Durumu' FROM hastalar,randevular WHERE hastalar.tc_kimlik = randevular.tc AND tarih = CURDATE() and islem = 0", veri.baglanti);
                veri.dt = new DataTable();
                veri.da.Fill(veri.dt);
                bekleyen_hasta_grid.DataSource = veri.dt;
                bekleyen_renk();
                veri.baglanti.Close();
            }
        }
        void islem_yapilan_hasta()
        {
            if (veri.baglanti_kontrol() == false)
            {
                MessageBox.Show("Bağlantı Hatası Oluştu Lüften Tekrardan Deneyiniz", "Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();
            }
            else
            {
                veri.da = new MySqlDataAdapter("SELECT h.*,r.* FROM randevular r,hastalar h WHERE h.tc_kimlik = r.tc AND r.tarih = CURDATE() AND r.islem = 1", veri.baglanti);
                veri.dt = new DataTable();
                veri.da.Fill(veri.dt);
                islem_yapilan_grid.DataSource = veri.dt;
                veri.baglanti.Close();
            }
        }
        void islem_biten_hasta()
        {
            if (veri.baglanti_kontrol() == false)
            {
                MessageBox.Show("Bağlantı Hatası Oluştu Lüften Tekrardan Deneyiniz", "Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();
            }
            else
            {
                veri.da = new MySqlDataAdapter("SELECT randevular.id AS 'Randevu ID',tc_kimlik AS 'TC Kimlik',tarih AS 'Tarih',saat AS 'Saat',adi AS 'Adı',soyadi AS 'Soyadı',klinik_adi AS 'Poliklinik',doktor_adi AS 'Doktor İsmi',mua_tur AS 'Muayene Türü',randevular.durum AS 'Randevu Durumu' FROM hastalar,randevular WHERE hastalar.tc_kimlik = randevular.tc AND tarih = CURDATE() and islem = 2", veri.baglanti);
                veri.dt = new DataTable();
                veri.da.Fill(veri.dt);
                islem_biten_grid.DataSource = veri.dt;
                biten_renk();
                veri.baglanti.Close();
            }
        }
        private void bekleyen_renk()
        {
            foreach (DataGridViewColumn col in bekleyen_hasta_grid.Columns)
            {
                int i = 0;
                while (i < bekleyen_hasta_grid.Rows.Count)
                {
                    if (bekleyen_hasta_grid.Rows[i].Cells[8].Value != null && bekleyen_hasta_grid.Rows[i].Cells[8].Value.Equals("Kontrol Muayenesi"))
                    {
                        bekleyen_hasta_grid.Rows[i].Cells[8].Style.BackColor = Color.GreenYellow;
                    }
                    if (bekleyen_hasta_grid.Rows[i].Cells[8].Value != null && bekleyen_hasta_grid.Rows[i].Cells[8].Value.Equals("Muayene"))
                    {
                        bekleyen_hasta_grid.Rows[i].Cells[8].Style.BackColor = Color.DarkSalmon;
                    }
                    if (bekleyen_hasta_grid.Rows[i].Cells[8].Value != null && bekleyen_hasta_grid.Rows[i].Cells[8].Value.Equals("Reçete Muayenesi"))
                    {
                        bekleyen_hasta_grid.Rows[i].Cells[8].Style.BackColor = Color.PowderBlue;
                    }
                    if (bekleyen_hasta_grid.Rows[i].Cells[8].Value != null && bekleyen_hasta_grid.Rows[i].Cells[8].Value.Equals("Günübirlik"))
                    {
                        bekleyen_hasta_grid.Rows[i].Cells[8].Style.BackColor = Color.Khaki;
                    }
                    i++;
                }
            }
        }
        private void biten_renk()
        {
            foreach (DataGridViewColumn col in islem_biten_grid.Columns)
            {
                int a = 0;
                while (a < islem_biten_grid.Rows.Count)
                {
                    if (islem_biten_grid.Rows[a].Cells[8].Value != null && islem_biten_grid.Rows[a].Cells[8].Value.Equals("Kontrol Muayenesi"))
                    {
                        islem_biten_grid.Rows[a].Cells[8].Style.BackColor = Color.GreenYellow;
                    }
                    if (islem_biten_grid.Rows[a].Cells[8].Value != null && islem_biten_grid.Rows[a].Cells[8].Value.Equals("Muayene"))
                    {
                        islem_biten_grid.Rows[a].Cells[8].Style.BackColor = Color.DarkSalmon;
                    }
                    if (islem_biten_grid.Rows[a].Cells[8].Value != null && islem_biten_grid.Rows[a].Cells[8].Value.Equals("Reçete Muayenesi"))
                    {
                        islem_biten_grid.Rows[a].Cells[8].Style.BackColor = Color.PowderBlue;
                    }
                    if (islem_biten_grid.Rows[a].Cells[8].Value != null && islem_biten_grid.Rows[a].Cells[8].Value.Equals("Günübirlik"))
                    {
                        islem_biten_grid.Rows[a].Cells[8].Style.BackColor = Color.Khaki;
                    }
                    a++;
                }
            }
        }

        private void frm_doktor_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval = 60000;
            islem_biten_hasta();
            bekleyen_hasta();
        }

        private void bekleyen_hasta_grid_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex != -1 && e.ColumnIndex != -1)
                {
                    var mouseninyeri = bekleyen_hasta_grid.PointToClient(Cursor.Position);
                    this.contextMenuStrip1.Show(bekleyen_hasta_grid, mouseninyeri);
                }
            }
        }

        private void bekleyen_hasta_grid_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            e.PaintParts &= ~DataGridViewPaintParts.Focus;
        }

        private void txt_sikayet_Click(object sender, EventArgs e)
        {
            panel6.BackColor = Color.Green;
            panel7.BackColor = Color.DimGray;
            panel8.BackColor = Color.DimGray;
            panel9.BackColor = Color.DimGray;
            panel10.BackColor = Color.DimGray;
            panel11.BackColor = Color.DimGray;
            panel12.BackColor = Color.DimGray;
            panel13.BackColor = Color.DimGray;
            panel14.BackColor = Color.DimGray;
        }

        private void txt_hikaye_Click(object sender, EventArgs e)
        {
            panel6.BackColor = Color.DimGray;
            panel7.BackColor = Color.Green;
            panel8.BackColor = Color.DimGray;
            panel9.BackColor = Color.DimGray;
            panel10.BackColor = Color.DimGray;
            panel11.BackColor = Color.DimGray;
            panel12.BackColor = Color.DimGray;
            panel13.BackColor = Color.DimGray;
            panel14.BackColor = Color.DimGray;
        }

        private void txt_mua_bulgu_Click(object sender, EventArgs e)
        {
            panel6.BackColor = Color.DimGray;
            panel7.BackColor = Color.DimGray;
            panel8.BackColor = Color.Green;
            panel9.BackColor = Color.DimGray;
            panel10.BackColor = Color.DimGray;
            panel11.BackColor = Color.DimGray;
            panel12.BackColor = Color.DimGray;
            panel13.BackColor = Color.DimGray;
            panel14.BackColor = Color.DimGray;
        }

        private void txt_on_tani_Click(object sender, EventArgs e)
        {
            panel6.BackColor = Color.DimGray;
            panel7.BackColor = Color.DimGray;
            panel8.BackColor = Color.DimGray;
            panel9.BackColor = Color.Green;
            panel10.BackColor = Color.DimGray;
            panel11.BackColor = Color.DimGray;
            panel12.BackColor = Color.DimGray;
            panel13.BackColor = Color.DimGray;
            panel14.BackColor = Color.DimGray;
        }

        private void txt_tani_Click(object sender, EventArgs e)
        {
            panel6.BackColor = Color.DimGray;
            panel7.BackColor = Color.DimGray;
            panel8.BackColor = Color.DimGray;
            panel9.BackColor = Color.DimGray;
            panel10.BackColor = Color.Green;
            panel11.BackColor = Color.DimGray;
            panel12.BackColor = Color.DimGray;
            panel13.BackColor = Color.DimGray;
            panel14.BackColor = Color.DimGray;
        }

        private void txt_islemler_Click(object sender, EventArgs e)
        {
            panel6.BackColor = Color.DimGray;
            panel7.BackColor = Color.DimGray;
            panel8.BackColor = Color.DimGray;
            panel9.BackColor = Color.DimGray;
            panel10.BackColor = Color.DimGray;
            panel11.BackColor = Color.Green;
            panel12.BackColor = Color.DimGray;
            panel13.BackColor = Color.DimGray;
            panel14.BackColor = Color.DimGray;
        }

        private void txt_tedevi_plan_Click(object sender, EventArgs e)
        {
            panel6.BackColor = Color.DimGray;
            panel7.BackColor = Color.DimGray;
            panel8.BackColor = Color.DimGray;
            panel9.BackColor = Color.DimGray;
            panel10.BackColor = Color.DimGray;
            panel11.BackColor = Color.DimGray;
            panel12.BackColor = Color.Green;
            panel13.BackColor = Color.DimGray;
            panel14.BackColor = Color.DimGray;
        }

        private void txt_mua_notlar_Click(object sender, EventArgs e)
        {
            panel6.BackColor = Color.DimGray;
            panel7.BackColor = Color.DimGray;
            panel8.BackColor = Color.DimGray;
            panel9.BackColor = Color.DimGray;
            panel10.BackColor = Color.DimGray;
            panel11.BackColor = Color.DimGray;
            panel12.BackColor = Color.DimGray;
            panel13.BackColor = Color.Green;
            panel14.BackColor = Color.DimGray;
        }

        private void txt_ilaclar_Click(object sender, EventArgs e)
        {
            panel6.BackColor = Color.DimGray;
            panel7.BackColor = Color.DimGray;
            panel8.BackColor = Color.DimGray;
            panel9.BackColor = Color.DimGray;
            panel10.BackColor = Color.DimGray;
            panel11.BackColor = Color.DimGray;
            panel12.BackColor = Color.DimGray;
            panel13.BackColor = Color.DimGray;
            panel14.BackColor = Color.Green;
        }

        private void islem_yapilan_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_tc.Text = islem_yapilan_grid.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_seri.Text = islem_yapilan_grid.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_no.Text = islem_yapilan_grid.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_adi.Text = islem_yapilan_grid.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_soyadi.Text = islem_yapilan_grid.Rows[e.RowIndex].Cells[5].Value.ToString();
            txt_baba_adi.Text = islem_yapilan_grid.Rows[e.RowIndex].Cells[6].Value.ToString();
            txt_anne_adi.Text = islem_yapilan_grid.Rows[e.RowIndex].Cells[7].Value.ToString();
            txt_dogum_yeri.Text = islem_yapilan_grid.Rows[e.RowIndex].Cells[8].Value.ToString();
            txt_dogum_tarih.Text = islem_yapilan_grid.Rows[e.RowIndex].Cells[9].Value.ToString();
            txt_medeni_hali.Text = islem_yapilan_grid.Rows[e.RowIndex].Cells[10].Value.ToString();
            txt_dini.Text = islem_yapilan_grid.Rows[e.RowIndex].Cells[11].Value.ToString();
            txt_kan_grubu.Text = islem_yapilan_grid.Rows[e.RowIndex].Cells[12].Value.ToString();
            cmb_il.SelectedItem = islem_yapilan_grid.Rows[e.RowIndex].Cells[13].Value.ToString();
            txt_ilce.Text = islem_yapilan_grid.Rows[e.RowIndex].Cells[14].Value.ToString();
            txt_mahalle.Text = islem_yapilan_grid.Rows[e.RowIndex].Cells[15].Value.ToString();
            txt_cilt_no.Text = islem_yapilan_grid.Rows[e.RowIndex].Cells[16].Value.ToString();
            txt_aile_sıra.Text = islem_yapilan_grid.Rows[e.RowIndex].Cells[17].Value.ToString();
            txt_sıra_no.Text = islem_yapilan_grid.Rows[e.RowIndex].Cells[18].Value.ToString();
            cmb_cinsiyet.SelectedItem = islem_yapilan_grid.Rows[e.RowIndex].Cells[19].Value.ToString();
            txt_tel.Text = islem_yapilan_grid.Rows[e.RowIndex].Cells[20].Value.ToString();
            txt_adres.Text = islem_yapilan_grid.Rows[e.RowIndex].Cells[21].Value.ToString();
        }

        private void btn_sikayet_kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                veri.baglanti.Open();
                veri.cmd.Connection = veri.baglanti;
                veri.cmd.CommandText = "INSERT INTO hasta_sikayetleri(hasta_id,sikayet,hikayesi,mua_bulgu,on_tani,tani,yapilan_islem,onerilen_tedavi,kullan_ilac)VALUES(" + islem_yapilan_grid.Rows[0].Cells[0].Value + ",'" + txt_sikayet.Text + "','" + txt_hikaye.Text + "', '" + txt_mua_bulgu.Text + "', '" + txt_on_tani.Text + "', '" + txt_tani.Text + "', '" + txt_islemler.Text + "', '" + txt_tedevi_plan.Text + "', '" + txt_ilaclar.Text + "')";
                i = veri.cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    veri.baglanti.Close();
                    MessageBox.Show("Kayıt İşlemi Başarılı\nDevam Etmek İçin Lütfen Hasta Muayensi Bitir İşlemini Yapınız", "Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btn_mua_bitir.Enabled = true;
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

        private void btn_mua_bitir_Click(object sender, EventArgs e)
        {
            try
            {
                veri.baglanti.Open();
                veri.cmd.Connection = veri.baglanti;
                veri.cmd.CommandText = "UPDATE randevular SET islem = 2,durum = 'Bitti' WHERE id= " + islem_yapilan_grid.Rows[0].Cells[22].Value;
                i = veri.cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    veri.baglanti.Close();
                    bekleyen_hasta();
                    islem_yapilan_hasta();
                    txt_tc.Text = "";
                    txt_seri.Text = "";
                    txt_no.Text = "";
                    txt_adi.Text = "";
                    txt_soyadi.Text = "";
                    txt_baba_adi.Text = "";
                    txt_anne_adi.Text = "";
                    txt_dogum_yeri.Text = "";
                    txt_dogum_tarih.Text = "";
                    txt_medeni_hali.Text = "";
                    txt_dini.Text = "";
                    txt_kan_grubu.Text = "";
                    cmb_il.SelectedItem = null;
                    txt_ilce.Text = "";
                    txt_mahalle.Text = "";
                    txt_cilt_no.Text = "";
                    txt_aile_sıra.Text = "";
                    txt_sıra_no.Text = "";
                    cmb_cinsiyet.SelectedItem = null;
                    txt_tel.Text = "";
                    txt_adres.Text = "";
                    txt_sikayet.Text = "";
                    txt_hikaye.Text = "";
                    txt_mua_bulgu.Text = "";
                    txt_on_tani.Text = "";
                    txt_tani.Text = "";
                    txt_islemler.Text = "";
                    txt_tedevi_plan.Text = "";
                    txt_mua_notlar.Text = "";
                    txt_ilaclar.Text = "";
                    tabControl1.SelectedTab = tab_islem_biten;
                    btn_mua_bitir.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                veri.baglanti.Close();
                MessageBox.Show("Güncelleme İşlemi Sırasında Bir Hata Oluştu!!!", "Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            double sayi = 60;
            if (sayi > 0)
            {
                bekleyen_hasta();
                islem_yapilan_hasta();
                islem_biten_hasta();
                sayi--;
            }
            else
            {
                sayi = 60;
            }
        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            if (veri.baglanti_kontrol() == false)
            {
                MessageBox.Show("Bağlantı Hatası Oluştu Lüften Tekrardan Deneyiniz", "Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();
            }
            else
            {
                string sql = "SELECT randevular.id AS 'Protocol',tc_kimlik AS 'TC Kimlik',tarih AS 'Tarih',saat AS 'Saat',adi AS 'Adı',soyadi AS 'Soyadı',klinik_adi AS 'Poliklinik',doktor_adi AS 'Doktor İsmi',mua_tur AS 'Muayene Türü',randevular.durum AS 'Randevu Durumu' " +
                             " FROM hastalar,randevular WHERE hastalar.tc_kimlik = randevular.tc AND islem = 2 AND tarih BETWEEN '" + xtarih1.Value.Date.ToString("yyyy-MM-dd") + "' AND '" + xtarih2.Value.Date.ToString("yyyy-MM-dd") + "'";

                veri.da = new MySqlDataAdapter(sql, veri.baglanti);
                veri.dt = new DataTable();
                veri.da.Fill(veri.dt);
                islem_biten_grid.DataSource = veri.dt;
                biten_renk();
                veri.baglanti.Close();
                if (islem_biten_grid.Rows.Count <= 0)
                {
                    MessageBox.Show("Arana Kriterlerde Veri Bulunamadı", "Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void bekleyen_hasta_grid_MouseClick(object sender, MouseEventArgs e)
        {
            int currentMouseOverRow = bekleyen_hasta_grid.HitTest(e.X, e.Y).RowIndex;
            //Click Eventi sağ tıklama ise
            if (e.Button == MouseButtons.Right)
            {
                // Bir contextmenu oluşturuyoruz
                ContextMenu m = new ContextMenu();
                //eğer sağ tıklama boşluğa değilse
                if (currentMouseOverRow >= 0)
                {
                    m.MenuItems.Add(new MenuItem("İşleme Al", bekleyen_hasta_grid_IslemeAl));
                    m.MenuItems.Add(new MenuItem("Randevu İptal Et", bekleyen_hasta_grid_RandevuIptal));
                    m.MenuItems.Add(new MenuItem("Randevu Geri Al", bekleyen_hasta_grid_RandevuGeriAl));
                }
                //boşluğada tıklansa hepsini sil menüsü gösterilsin

                m.Show(bekleyen_hasta_grid, new Point(e.X, e.Y));//menuyu goster
            }
        }

        private void bekleyen_hasta_grid_IslemeAl(object sender, EventArgs e)
        {
            try
            {
                veri.baglanti.Open();
                veri.cmd.Connection = veri.baglanti;
                veri.cmd.CommandText = "UPDATE randevular SET islem = 1 WHERE id= " + bekleyen_hasta_grid.SelectedRows[0].Cells[0].Value;
                i = veri.cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    veri.baglanti.Close();
                    bekleyen_hasta();
                    islem_yapilan_hasta();
                    tabControl1.SelectedTab = tab_islem_yapılan;
                }
            }
            catch (Exception ex)
            {
                veri.baglanti.Close();
                MessageBox.Show("Güncelleme İşlemi Sırasında Bir Hata Oluştu!!!", "Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bekleyen_hasta_grid_RandevuIptal(object sender, EventArgs e)
        {
            try
            {
                veri.baglanti.Open();
                veri.cmd.Connection = veri.baglanti;
                veri.cmd.CommandText = "UPDATE randevular SET durum = 'Gelmedi' WHERE id= " + bekleyen_hasta_grid.SelectedRows[0].Cells[0].Value;
                i = veri.cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    veri.baglanti.Close();
                    bekleyen_hasta();
                }
            }
            catch (Exception ex)
            {
                veri.baglanti.Close();
                MessageBox.Show("Güncelleme İşlemi Sırasında Bir Hata Oluştu!!!", "Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bekleyen_hasta_grid_RandevuGeriAl(object sender, EventArgs e)
        {
            try
            {
                veri.baglanti.Open();
                veri.cmd.Connection = veri.baglanti;
                veri.cmd.CommandText = "UPDATE randevular SET durum = 'Bekliyor' WHERE id= " + bekleyen_hasta_grid.SelectedRows[0].Cells[0].Value;
                i = veri.cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    veri.baglanti.Close();
                    bekleyen_hasta();
                }
            }
            catch (Exception ex)
            {
                veri.baglanti.Close();
                MessageBox.Show("Güncelleme İşlemi Sırasında Bir Hata Oluştu!!!", "Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bekleyen_hasta_grid_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                veri.baglanti.Open();
                veri.cmd.Connection = veri.baglanti;
                veri.cmd.CommandText = "UPDATE randevular SET islem = 1 WHERE id= " + bekleyen_hasta_grid.SelectedRows[0].Cells[0].Value;
                i = veri.cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    veri.baglanti.Close();
                    bekleyen_hasta();
                    islem_yapilan_hasta();
                    tabControl1.SelectedTab = tab_islem_yapılan;
                }
            }
            catch (Exception ex)
            {
                veri.baglanti.Close();
                MessageBox.Show("Güncelleme İşlemi Sırasında Bir Hata Oluştu!!!", "Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
       
    }
}
