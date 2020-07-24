namespace arnis_hospital
{
    partial class frm_doktor_giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_doktor_giris));
            this.lbl_user = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_geri = new System.Windows.Forms.Button();
            this.txt_doktor_ara = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.lbl_doktor_isim = new System.Windows.Forms.Label();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.doktor_grid = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.doktor_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Location = new System.Drawing.Point(368, 157);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(0, 13);
            this.lbl_user.TabIndex = 112;
            this.lbl_user.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(366, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 111;
            this.label2.Text = "Şifre";
            // 
            // btn_geri
            // 
            this.btn_geri.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btn_geri.Image = ((System.Drawing.Image)(resources.GetObject("btn_geri.Image")));
            this.btn_geri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_geri.Location = new System.Drawing.Point(531, 64);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(102, 39);
            this.btn_geri.TabIndex = 110;
            this.btn_geri.Text = "Geri Dön";
            this.btn_geri.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_geri.UseVisualStyleBackColor = true;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // txt_doktor_ara
            // 
            this.txt_doktor_ara.Location = new System.Drawing.Point(109, 12);
            this.txt_doktor_ara.Name = "txt_doktor_ara";
            this.txt_doktor_ara.Size = new System.Drawing.Size(250, 20);
            this.txt_doktor_ara.TabIndex = 108;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(9, 13);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 16);
            this.label14.TabIndex = 109;
            this.label14.Text = "Doktor Ara";
            // 
            // btn_login
            // 
            this.btn_login.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btn_login.Image = ((System.Drawing.Image)(resources.GetObject("btn_login.Image")));
            this.btn_login.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_login.Location = new System.Drawing.Point(423, 64);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(102, 39);
            this.btn_login.TabIndex = 107;
            this.btn_login.Text = "Giriş Yap";
            this.btn_login.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // lbl_doktor_isim
            // 
            this.lbl_doktor_isim.AutoSize = true;
            this.lbl_doktor_isim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_doktor_isim.Location = new System.Drawing.Point(365, 7);
            this.lbl_doktor_isim.Name = "lbl_doktor_isim";
            this.lbl_doktor_isim.Size = new System.Drawing.Size(60, 24);
            this.lbl_doktor_isim.TabIndex = 106;
            this.lbl_doktor_isim.Text = "label1";
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(422, 38);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.PasswordChar = '*';
            this.txt_sifre.Size = new System.Drawing.Size(211, 20);
            this.txt_sifre.TabIndex = 105;
            // 
            // doktor_grid
            // 
            this.doktor_grid.AllowUserToAddRows = false;
            this.doktor_grid.AllowUserToDeleteRows = false;
            this.doktor_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.doktor_grid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.doktor_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doktor_grid.ColumnHeadersVisible = false;
            this.doktor_grid.Location = new System.Drawing.Point(12, 38);
            this.doktor_grid.Name = "doktor_grid";
            this.doktor_grid.ReadOnly = true;
            this.doktor_grid.Size = new System.Drawing.Size(347, 219);
            this.doktor_grid.TabIndex = 104;
            this.doktor_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.doktor_grid_CellClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(423, 109);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 113;
            this.pictureBox1.TabStop = false;
            // 
            // frm_doktor_giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 265);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.txt_doktor_ara);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.lbl_doktor_isim);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.doktor_grid);
            this.Name = "frm_doktor_giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doktor Giriş";
            this.Load += new System.EventHandler(this.frm_doktor_giris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.doktor_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_geri;
        private System.Windows.Forms.TextBox txt_doktor_ara;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label lbl_doktor_isim;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.DataGridView doktor_grid;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}