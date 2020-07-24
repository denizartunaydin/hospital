namespace arnis_hospital
{
    partial class frm_giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_giris));
            this.btn_cikis = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmb_kullanici = new System.Windows.Forms.ComboBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cikis
            // 
            this.btn_cikis.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btn_cikis.Image = ((System.Drawing.Image)(resources.GetObject("btn_cikis.Image")));
            this.btn_cikis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cikis.Location = new System.Drawing.Point(329, 98);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(83, 51);
            this.btn_cikis.TabIndex = 19;
            this.btn_cikis.Text = "Çıkış Yap";
            this.btn_cikis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cikis.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // cmb_kullanici
            // 
            this.cmb_kullanici.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_kullanici.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_kullanici.FormattingEnabled = true;
            this.cmb_kullanici.Location = new System.Drawing.Point(240, 37);
            this.cmb_kullanici.Name = "cmb_kullanici";
            this.cmb_kullanici.Size = new System.Drawing.Size(172, 21);
            this.cmb_kullanici.TabIndex = 13;
            // 
            // btn_login
            // 
            this.btn_login.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btn_login.Image = ((System.Drawing.Image)(resources.GetObject("btn_login.Image")));
            this.btn_login.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_login.Location = new System.Drawing.Point(240, 98);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(83, 51);
            this.btn_login.TabIndex = 15;
            this.btn_login.Text = "Giriş Yap";
            this.btn_login.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(147, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Şifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(147, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(240, 63);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.PasswordChar = '*';
            this.txt_sifre.Size = new System.Drawing.Size(172, 20);
            this.txt_sifre.TabIndex = 14;
            // 
            // frm_giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 167);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmb_kullanici);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_sifre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hastane Yönetim Sistemi ";
            this.Load += new System.EventHandler(this.frm_giris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.ComboBox cmb_kullanici;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_sifre;
    }
}

