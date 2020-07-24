namespace arnis_hospital
{
    partial class frm_kullanicilar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_kullanicilar));
            this.cmb_gorev = new System.Windows.Forms.ComboBox();
            this.btn_kullanici_sil = new System.Windows.Forms.Button();
            this.btn_kullanici_kayit = new System.Windows.Forms.Button();
            this.btn_kullanici_duzenle = new System.Windows.Forms.Button();
            this.kullanici_grid = new System.Windows.Forms.DataGridView();
            this.txt_kullanici_ara = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_kadi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_ksifre = new System.Windows.Forms.TextBox();
            this.txt_isim = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kullanici_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_gorev
            // 
            this.cmb_gorev.FormattingEnabled = true;
            this.cmb_gorev.Items.AddRange(new object[] {
            "Doktor",
            "Yönetim",
            "Muhasebe",
            "Ön Büro"});
            this.cmb_gorev.Location = new System.Drawing.Point(69, 38);
            this.cmb_gorev.Name = "cmb_gorev";
            this.cmb_gorev.Size = new System.Drawing.Size(161, 21);
            this.cmb_gorev.TabIndex = 123;
            // 
            // btn_kullanici_sil
            // 
            this.btn_kullanici_sil.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btn_kullanici_sil.Image = ((System.Drawing.Image)(resources.GetObject("btn_kullanici_sil.Image")));
            this.btn_kullanici_sil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kullanici_sil.Location = new System.Drawing.Point(278, 76);
            this.btn_kullanici_sil.Name = "btn_kullanici_sil";
            this.btn_kullanici_sil.Size = new System.Drawing.Size(96, 34);
            this.btn_kullanici_sil.TabIndex = 122;
            this.btn_kullanici_sil.Text = "Kullanıcı Sil";
            this.btn_kullanici_sil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_kullanici_sil.UseVisualStyleBackColor = true;
            this.btn_kullanici_sil.Click += new System.EventHandler(this.btn_kullanici_sil_Click);
            // 
            // btn_kullanici_kayit
            // 
            this.btn_kullanici_kayit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kullanici_kayit.Image = ((System.Drawing.Image)(resources.GetObject("btn_kullanici_kayit.Image")));
            this.btn_kullanici_kayit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kullanici_kayit.Location = new System.Drawing.Point(12, 76);
            this.btn_kullanici_kayit.Name = "btn_kullanici_kayit";
            this.btn_kullanici_kayit.Size = new System.Drawing.Size(124, 34);
            this.btn_kullanici_kayit.TabIndex = 121;
            this.btn_kullanici_kayit.Text = "Kullanıcı Kaydet";
            this.btn_kullanici_kayit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_kullanici_kayit.UseVisualStyleBackColor = true;
            this.btn_kullanici_kayit.Click += new System.EventHandler(this.btn_kullanici_kayit_Click);
            // 
            // btn_kullanici_duzenle
            // 
            this.btn_kullanici_duzenle.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btn_kullanici_duzenle.Image = ((System.Drawing.Image)(resources.GetObject("btn_kullanici_duzenle.Image")));
            this.btn_kullanici_duzenle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kullanici_duzenle.Location = new System.Drawing.Point(142, 76);
            this.btn_kullanici_duzenle.Name = "btn_kullanici_duzenle";
            this.btn_kullanici_duzenle.Size = new System.Drawing.Size(130, 34);
            this.btn_kullanici_duzenle.TabIndex = 120;
            this.btn_kullanici_duzenle.Text = "Kullanıcı Düzenle";
            this.btn_kullanici_duzenle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_kullanici_duzenle.UseVisualStyleBackColor = true;
            this.btn_kullanici_duzenle.Click += new System.EventHandler(this.btn_kullanici_duzenle_Click);
            // 
            // kullanici_grid
            // 
            this.kullanici_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kullanici_grid.Location = new System.Drawing.Point(12, 117);
            this.kullanici_grid.Name = "kullanici_grid";
            this.kullanici_grid.Size = new System.Drawing.Size(548, 297);
            this.kullanici_grid.TabIndex = 119;
            this.kullanici_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kullanici_grid_CellClick);
            // 
            // txt_kullanici_ara
            // 
            this.txt_kullanici_ara.Location = new System.Drawing.Point(380, 90);
            this.txt_kullanici_ara.Name = "txt_kullanici_ara";
            this.txt_kullanici_ara.Size = new System.Drawing.Size(180, 20);
            this.txt_kullanici_ara.TabIndex = 117;
            this.txt_kullanici_ara.TextChanged += new System.EventHandler(this.txt_kullanici_ara_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(466, 71);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 16);
            this.label14.TabIndex = 118;
            this.label14.Text = "Kullanıcı Ara";
            // 
            // txt_kadi
            // 
            this.txt_kadi.Location = new System.Drawing.Point(348, 12);
            this.txt_kadi.Name = "txt_kadi";
            this.txt_kadi.Size = new System.Drawing.Size(212, 20);
            this.txt_kadi.TabIndex = 113;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(246, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 16);
            this.label8.TabIndex = 116;
            this.label8.Text = "Kullanıcı Adı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(9, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 16);
            this.label6.TabIndex = 115;
            this.label6.Text = "Görevi";
            // 
            // txt_ksifre
            // 
            this.txt_ksifre.Location = new System.Drawing.Point(348, 38);
            this.txt_ksifre.Name = "txt_ksifre";
            this.txt_ksifre.Size = new System.Drawing.Size(212, 20);
            this.txt_ksifre.TabIndex = 114;
            // 
            // txt_isim
            // 
            this.txt_isim.Location = new System.Drawing.Point(69, 12);
            this.txt_isim.Name = "txt_isim";
            this.txt_isim.Size = new System.Drawing.Size(161, 20);
            this.txt_isim.TabIndex = 112;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(246, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 111;
            this.label3.Text = "Şifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 110;
            this.label1.Text = "İsim";
            // 
            // frm_kullanicilar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 429);
            this.Controls.Add(this.cmb_gorev);
            this.Controls.Add(this.btn_kullanici_sil);
            this.Controls.Add(this.btn_kullanici_kayit);
            this.Controls.Add(this.btn_kullanici_duzenle);
            this.Controls.Add(this.kullanici_grid);
            this.Controls.Add(this.txt_kullanici_ara);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txt_kadi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_ksifre);
            this.Controls.Add(this.txt_isim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_kullanicilar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcılar";
            this.Load += new System.EventHandler(this.frm_kullanicilar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kullanici_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_gorev;
        private System.Windows.Forms.Button btn_kullanici_sil;
        private System.Windows.Forms.Button btn_kullanici_kayit;
        private System.Windows.Forms.Button btn_kullanici_duzenle;
        private System.Windows.Forms.DataGridView kullanici_grid;
        private System.Windows.Forms.TextBox txt_kullanici_ara;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_kadi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_ksifre;
        private System.Windows.Forms.TextBox txt_isim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}