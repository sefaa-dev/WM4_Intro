
namespace KisiEnvanteri
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAd = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblDogumTarihi = new System.Windows.Forms.Label();
            this.pbResim = new System.Windows.Forms.PictureBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.lstKisiler = new System.Windows.Forms.ListBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dışarıAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.içeriAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblAd.ForeColor = System.Drawing.Color.Red;
            this.lblAd.Location = new System.Drawing.Point(55, 65);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(49, 20);
            this.lblAd.TabIndex = 0;
            this.lblAd.Text = "AD ->";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblSoyad.ForeColor = System.Drawing.Color.Red;
            this.lblSoyad.Location = new System.Drawing.Point(55, 117);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(75, 20);
            this.lblSoyad.TabIndex = 1;
            this.lblSoyad.Text = "SOYAD ->";
            // 
            // lblDogumTarihi
            // 
            this.lblDogumTarihi.AutoSize = true;
            this.lblDogumTarihi.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblDogumTarihi.ForeColor = System.Drawing.Color.Red;
            this.lblDogumTarihi.Location = new System.Drawing.Point(54, 213);
            this.lblDogumTarihi.Name = "lblDogumTarihi";
            this.lblDogumTarihi.Size = new System.Drawing.Size(118, 20);
            this.lblDogumTarihi.TabIndex = 2;
            this.lblDogumTarihi.Text = "Doğum Tarihi ->";
            // 
            // pbResim
            // 
            this.pbResim.Location = new System.Drawing.Point(214, 260);
            this.pbResim.Name = "pbResim";
            this.pbResim.Size = new System.Drawing.Size(198, 224);
            this.pbResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbResim.TabIndex = 3;
            this.pbResim.TabStop = false;
            this.pbResim.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(186, 62);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(164, 23);
            this.txtAd.TabIndex = 4;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(186, 114);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(164, 23);
            this.txtSoyad.TabIndex = 5;
            // 
            // lstKisiler
            // 
            this.lstKisiler.FormattingEnabled = true;
            this.lstKisiler.ItemHeight = 15;
            this.lstKisiler.Location = new System.Drawing.Point(460, 62);
            this.lstKisiler.Name = "lstKisiler";
            this.lstKisiler.Size = new System.Drawing.Size(230, 409);
            this.lstKisiler.TabIndex = 7;
            this.lstKisiler.SelectedIndexChanged += new System.EventHandler(this.lstKisiler_SelectedIndexChanged);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnKaydet.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKaydet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnKaydet.Location = new System.Drawing.Point(73, 306);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(99, 65);
            this.btnKaydet.TabIndex = 8;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGuncelle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGuncelle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnGuncelle.Location = new System.Drawing.Point(73, 395);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(99, 65);
            this.btnGuncelle.TabIndex = 9;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Location = new System.Drawing.Point(186, 213);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(200, 23);
            this.dtpDogumTarihi.TabIndex = 10;
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblTelefon.ForeColor = System.Drawing.Color.Red;
            this.lblTelefon.Location = new System.Drawing.Point(59, 168);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(75, 20);
            this.lblTelefon.TabIndex = 11;
            this.lblTelefon.Text = "Telefon ->";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(186, 165);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(164, 23);
            this.txtTelefon.TabIndex = 12;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaİşlemleriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(783, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaİşlemleriToolStripMenuItem
            // 
            this.dosyaİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dışarıAktarToolStripMenuItem,
            this.içeriAktarToolStripMenuItem});
            this.dosyaİşlemleriToolStripMenuItem.Name = "dosyaİşlemleriToolStripMenuItem";
            this.dosyaİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.dosyaİşlemleriToolStripMenuItem.Text = "Dosya İşlemleri";
            // 
            // dışarıAktarToolStripMenuItem
            // 
            this.dışarıAktarToolStripMenuItem.Name = "dışarıAktarToolStripMenuItem";
            this.dışarıAktarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dışarıAktarToolStripMenuItem.Text = "Dışarı Aktar";
            this.dışarıAktarToolStripMenuItem.Click += new System.EventHandler(this.dışarıAktarToolStripMenuItem_Click);
            // 
            // içeriAktarToolStripMenuItem
            // 
            this.içeriAktarToolStripMenuItem.Name = "içeriAktarToolStripMenuItem";
            this.içeriAktarToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.içeriAktarToolStripMenuItem.Text = "İçeri Aktar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 536);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.dtpDogumTarihi);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.lstKisiler);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.pbResim);
            this.Controls.Add(this.lblDogumTarihi);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblDogumTarihi;
        private System.Windows.Forms.PictureBox pbResim;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.ListBox lstKisiler;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.DateTimePicker dtpDogumTarihi;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dışarıAktarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem içeriAktarToolStripMenuItem;
    }
}

