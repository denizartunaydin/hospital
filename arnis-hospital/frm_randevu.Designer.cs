namespace arnis_hospital
{
    partial class frm_randevu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_randevu));
            this.txt_tc_ara = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_ara = new System.Windows.Forms.Button();
            this.xtarih2 = new System.Windows.Forms.DateTimePicker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.xtarih1 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.cmb_tc = new System.Windows.Forms.ComboBox();
            this.cmb_saat = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_klinik = new System.Windows.Forms.ComboBox();
            this.cmb_doktor = new System.Windows.Forms.ComboBox();
            this.cmb_mua_tur = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tarih = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_randevu_sil = new System.Windows.Forms.Button();
            this.btn_randevu_kayit = new System.Windows.Forms.Button();
            this.btn_randevu_guncelle = new System.Windows.Forms.Button();
            this.randevu_grid = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.randevu_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_tc_ara
            // 
            this.txt_tc_ara.Location = new System.Drawing.Point(766, 62);
            this.txt_tc_ara.Name = "txt_tc_ara";
            this.txt_tc_ara.Size = new System.Drawing.Size(239, 20);
            this.txt_tc_ara.TabIndex = 144;
            this.txt_tc_ara.TextChanged += new System.EventHandler(this.txt_tc_ara_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(656, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 16);
            this.label7.TabIndex = 143;
            this.label7.Text = "Hasta TC Ara";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_ara);
            this.panel1.Controls.Add(this.xtarih2);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.xtarih1);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(-2, 544);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1028, 26);
            this.panel1.TabIndex = 142;
            // 
            // btn_ara
            // 
            this.btn_ara.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_ara.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ara.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ara.Image = ((System.Drawing.Image)(resources.GetObject("btn_ara.Image")));
            this.btn_ara.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ara.Location = new System.Drawing.Point(924, 0);
            this.btn_ara.Name = "btn_ara";
            this.btn_ara.Size = new System.Drawing.Size(83, 26);
            this.btn_ara.TabIndex = 117;
            this.btn_ara.Text = "Listele";
            this.btn_ara.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ara.UseVisualStyleBackColor = false;
            this.btn_ara.Click += new System.EventHandler(this.btn_ara_Click);
            // 
            // xtarih2
            // 
            this.xtarih2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.xtarih2.Location = new System.Drawing.Point(653, 4);
            this.xtarih2.Name = "xtarih2";
            this.xtarih2.Size = new System.Drawing.Size(94, 20);
            this.xtarih2.TabIndex = 116;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox1.Location = new System.Drawing.Point(768, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(149, 19);
            this.checkBox1.TabIndex = 105;
            this.checkBox1.Text = "Muayenesi Bitenler";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // xtarih1
            // 
            this.xtarih1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.xtarih1.Location = new System.Drawing.Point(553, 4);
            this.xtarih1.Name = "xtarih1";
            this.xtarih1.Size = new System.Drawing.Size(94, 20);
            this.xtarih1.TabIndex = 115;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(503, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 16);
            this.label10.TabIndex = 114;
            this.label10.Text = "Tarih";
            // 
            // cmb_tc
            // 
            this.cmb_tc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_tc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_tc.FormattingEnabled = true;
            this.cmb_tc.Location = new System.Drawing.Point(119, 6);
            this.cmb_tc.Name = "cmb_tc";
            this.cmb_tc.Size = new System.Drawing.Size(219, 21);
            this.cmb_tc.TabIndex = 141;
            // 
            // cmb_saat
            // 
            this.cmb_saat.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_saat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_saat.FormattingEnabled = true;
            this.cmb_saat.Items.AddRange(new object[] {
            "08:00",
            "08:30",
            "09:00",
            "09:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "17:30",
            "18:30"});
            this.cmb_saat.Location = new System.Drawing.Point(431, 36);
            this.cmb_saat.Name = "cmb_saat";
            this.cmb_saat.Size = new System.Drawing.Size(219, 21);
            this.cmb_saat.TabIndex = 138;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(354, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 137;
            this.label4.Text = "Saat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(9, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 136;
            this.label3.Text = "Tarih";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(354, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 135;
            this.label2.Text = "Doktor";
            // 
            // cmb_klinik
            // 
            this.cmb_klinik.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_klinik.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_klinik.FormattingEnabled = true;
            this.cmb_klinik.Location = new System.Drawing.Point(431, 6);
            this.cmb_klinik.Name = "cmb_klinik";
            this.cmb_klinik.Size = new System.Drawing.Size(219, 21);
            this.cmb_klinik.TabIndex = 133;
            this.cmb_klinik.SelectedIndexChanged += new System.EventHandler(this.cmb_klinik_SelectedIndexChanged);
            // 
            // cmb_doktor
            // 
            this.cmb_doktor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_doktor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_doktor.FormattingEnabled = true;
            this.cmb_doktor.Location = new System.Drawing.Point(431, 66);
            this.cmb_doktor.Name = "cmb_doktor";
            this.cmb_doktor.Size = new System.Drawing.Size(219, 21);
            this.cmb_doktor.TabIndex = 132;
            this.cmb_doktor.SelectedIndexChanged += new System.EventHandler(this.cmb_doktor_SelectedIndexChanged);
            // 
            // cmb_mua_tur
            // 
            this.cmb_mua_tur.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_mua_tur.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_mua_tur.FormattingEnabled = true;
            this.cmb_mua_tur.Items.AddRange(new object[] {
            "Kontrol Muayenesi",
            "Muayene",
            "Reçete Muayenesi",
            "Günübirlik"});
            this.cmb_mua_tur.Location = new System.Drawing.Point(119, 67);
            this.cmb_mua_tur.Name = "cmb_mua_tur";
            this.cmb_mua_tur.Size = new System.Drawing.Size(219, 21);
            this.cmb_mua_tur.TabIndex = 140;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(9, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 16);
            this.label5.TabIndex = 139;
            this.label5.Text = "Muayene Türü";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(354, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 134;
            this.label1.Text = "Poliklinik";
            // 
            // tarih
            // 
            this.tarih.CustomFormat = "yyyy-MM-dd";
            this.tarih.Location = new System.Drawing.Point(119, 37);
            this.tarih.Name = "tarih";
            this.tarih.Size = new System.Drawing.Size(219, 20);
            this.tarih.TabIndex = 131;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(9, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 16);
            this.label8.TabIndex = 130;
            this.label8.Text = "TC Kimlik No";
            // 
            // btn_randevu_sil
            // 
            this.btn_randevu_sil.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btn_randevu_sil.Image = ((System.Drawing.Image)(resources.GetObject("btn_randevu_sil.Image")));
            this.btn_randevu_sil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_randevu_sil.Location = new System.Drawing.Point(906, 6);
            this.btn_randevu_sil.Name = "btn_randevu_sil";
            this.btn_randevu_sil.Size = new System.Drawing.Size(99, 34);
            this.btn_randevu_sil.TabIndex = 129;
            this.btn_randevu_sil.Text = "Randevu Sil";
            this.btn_randevu_sil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_randevu_sil.UseVisualStyleBackColor = true;
            this.btn_randevu_sil.Click += new System.EventHandler(this.btn_randevu_sil_Click);
            // 
            // btn_randevu_kayit
            // 
            this.btn_randevu_kayit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_randevu_kayit.Image = ((System.Drawing.Image)(resources.GetObject("btn_randevu_kayit.Image")));
            this.btn_randevu_kayit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_randevu_kayit.Location = new System.Drawing.Point(659, 6);
            this.btn_randevu_kayit.Name = "btn_randevu_kayit";
            this.btn_randevu_kayit.Size = new System.Drawing.Size(101, 34);
            this.btn_randevu_kayit.TabIndex = 128;
            this.btn_randevu_kayit.Text = "Randevu Al";
            this.btn_randevu_kayit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_randevu_kayit.UseVisualStyleBackColor = true;
            this.btn_randevu_kayit.Click += new System.EventHandler(this.btn_randevu_kayit_Click);
            // 
            // btn_randevu_guncelle
            // 
            this.btn_randevu_guncelle.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btn_randevu_guncelle.Image = ((System.Drawing.Image)(resources.GetObject("btn_randevu_guncelle.Image")));
            this.btn_randevu_guncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_randevu_guncelle.Location = new System.Drawing.Point(766, 6);
            this.btn_randevu_guncelle.Name = "btn_randevu_guncelle";
            this.btn_randevu_guncelle.Size = new System.Drawing.Size(134, 34);
            this.btn_randevu_guncelle.TabIndex = 127;
            this.btn_randevu_guncelle.Text = "Randevu  Düzenle";
            this.btn_randevu_guncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_randevu_guncelle.UseVisualStyleBackColor = true;
            this.btn_randevu_guncelle.Click += new System.EventHandler(this.btn_randevu_guncelle_Click);
            // 
            // randevu_grid
            // 
            this.randevu_grid.AllowUserToAddRows = false;
            this.randevu_grid.AllowUserToDeleteRows = false;
            this.randevu_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.randevu_grid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.randevu_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.randevu_grid.Location = new System.Drawing.Point(12, 94);
            this.randevu_grid.Name = "randevu_grid";
            this.randevu_grid.ReadOnly = true;
            this.randevu_grid.Size = new System.Drawing.Size(993, 444);
            this.randevu_grid.TabIndex = 126;
            this.randevu_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.randevu_grid_CellClick);
            // 
            // frm_randevu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 574);
            this.Controls.Add(this.txt_tc_ara);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmb_tc);
            this.Controls.Add(this.cmb_saat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_klinik);
            this.Controls.Add(this.cmb_doktor);
            this.Controls.Add(this.cmb_mua_tur);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tarih);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_randevu_sil);
            this.Controls.Add(this.btn_randevu_kayit);
            this.Controls.Add(this.btn_randevu_guncelle);
            this.Controls.Add(this.randevu_grid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_randevu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Randevular";
            this.Load += new System.EventHandler(this.frm_randevu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.randevu_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_tc_ara;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_ara;
        private System.Windows.Forms.DateTimePicker xtarih2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DateTimePicker xtarih1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmb_tc;
        private System.Windows.Forms.ComboBox cmb_saat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_klinik;
        private System.Windows.Forms.ComboBox cmb_doktor;
        private System.Windows.Forms.ComboBox cmb_mua_tur;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker tarih;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_randevu_sil;
        private System.Windows.Forms.Button btn_randevu_kayit;
        private System.Windows.Forms.Button btn_randevu_guncelle;
        private System.Windows.Forms.DataGridView randevu_grid;
    }
}