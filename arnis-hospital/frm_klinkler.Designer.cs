namespace arnis_hospital
{
    partial class frm_klinkler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_klinkler));
            this.klinik_grid = new System.Windows.Forms.DataGridView();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.btn_klinik_sil = new System.Windows.Forms.Button();
            this.btn_klinik_kayit = new System.Windows.Forms.Button();
            this.btn_klinik_duzenle = new System.Windows.Forms.Button();
            this.txt_klinik_ara = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_klinik = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.klinik_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // klinik_grid
            // 
            this.klinik_grid.AllowUserToAddRows = false;
            this.klinik_grid.AllowUserToDeleteRows = false;
            this.klinik_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.klinik_grid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.klinik_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.klinik_grid.Location = new System.Drawing.Point(12, 126);
            this.klinik_grid.Name = "klinik_grid";
            this.klinik_grid.ReadOnly = true;
            this.klinik_grid.Size = new System.Drawing.Size(409, 312);
            this.klinik_grid.TabIndex = 126;
            this.klinik_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.klinik_grid_CellClick);
            // 
            // btn_temizle
            // 
            this.btn_temizle.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btn_temizle.Image = ((System.Drawing.Image)(resources.GetObject("btn_temizle.Image")));
            this.btn_temizle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_temizle.Location = new System.Drawing.Point(336, 48);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(85, 34);
            this.btn_temizle.TabIndex = 125;
            this.btn_temizle.Text = "Temizle";
            this.btn_temizle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // btn_klinik_sil
            // 
            this.btn_klinik_sil.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btn_klinik_sil.Image = ((System.Drawing.Image)(resources.GetObject("btn_klinik_sil.Image")));
            this.btn_klinik_sil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_klinik_sil.Location = new System.Drawing.Point(246, 48);
            this.btn_klinik_sil.Name = "btn_klinik_sil";
            this.btn_klinik_sil.Size = new System.Drawing.Size(84, 34);
            this.btn_klinik_sil.TabIndex = 124;
            this.btn_klinik_sil.Text = "Klinik Sil";
            this.btn_klinik_sil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_klinik_sil.UseVisualStyleBackColor = true;
            this.btn_klinik_sil.Click += new System.EventHandler(this.btn_klinik_sil_Click);
            // 
            // btn_klinik_kayit
            // 
            this.btn_klinik_kayit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_klinik_kayit.Image = ((System.Drawing.Image)(resources.GetObject("btn_klinik_kayit.Image")));
            this.btn_klinik_kayit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_klinik_kayit.Location = new System.Drawing.Point(12, 48);
            this.btn_klinik_kayit.Name = "btn_klinik_kayit";
            this.btn_klinik_kayit.Size = new System.Drawing.Size(106, 34);
            this.btn_klinik_kayit.TabIndex = 123;
            this.btn_klinik_kayit.Text = "Klinik Kaydet";
            this.btn_klinik_kayit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_klinik_kayit.UseVisualStyleBackColor = true;
            this.btn_klinik_kayit.Click += new System.EventHandler(this.btn_klinik_kayit_Click);
            // 
            // btn_klinik_duzenle
            // 
            this.btn_klinik_duzenle.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btn_klinik_duzenle.Image = ((System.Drawing.Image)(resources.GetObject("btn_klinik_duzenle.Image")));
            this.btn_klinik_duzenle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_klinik_duzenle.Location = new System.Drawing.Point(127, 48);
            this.btn_klinik_duzenle.Name = "btn_klinik_duzenle";
            this.btn_klinik_duzenle.Size = new System.Drawing.Size(113, 34);
            this.btn_klinik_duzenle.TabIndex = 122;
            this.btn_klinik_duzenle.Text = "Klinik Düzenle";
            this.btn_klinik_duzenle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_klinik_duzenle.UseVisualStyleBackColor = true;
            this.btn_klinik_duzenle.Click += new System.EventHandler(this.btn_klinik_duzenle_Click);
            // 
            // txt_klinik_ara
            // 
            this.txt_klinik_ara.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_klinik_ara.Location = new System.Drawing.Point(241, 100);
            this.txt_klinik_ara.Name = "txt_klinik_ara";
            this.txt_klinik_ara.Size = new System.Drawing.Size(180, 20);
            this.txt_klinik_ara.TabIndex = 120;
            this.txt_klinik_ara.TextChanged += new System.EventHandler(this.txt_klinik_ara_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(151, 101);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 16);
            this.label14.TabIndex = 121;
            this.label14.Text = "Klinik Ara";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 119;
            this.label1.Text = "Klinik İsmi";
            // 
            // txt_klinik
            // 
            this.txt_klinik.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_klinik.Location = new System.Drawing.Point(95, 6);
            this.txt_klinik.Name = "txt_klinik";
            this.txt_klinik.Size = new System.Drawing.Size(326, 20);
            this.txt_klinik.TabIndex = 118;
            // 
            // frm_klinkler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 450);
            this.Controls.Add(this.klinik_grid);
            this.Controls.Add(this.btn_temizle);
            this.Controls.Add(this.btn_klinik_sil);
            this.Controls.Add(this.btn_klinik_kayit);
            this.Controls.Add(this.btn_klinik_duzenle);
            this.Controls.Add(this.txt_klinik_ara);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_klinik);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_klinkler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Klinikler";
            this.Load += new System.EventHandler(this.frm_klinkler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.klinik_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView klinik_grid;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.Button btn_klinik_sil;
        private System.Windows.Forms.Button btn_klinik_kayit;
        private System.Windows.Forms.Button btn_klinik_duzenle;
        private System.Windows.Forms.TextBox txt_klinik_ara;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_klinik;
    }
}