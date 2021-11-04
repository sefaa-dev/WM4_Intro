
namespace PaymentMethod
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
            this.cmbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCvv = new System.Windows.Forms.TextBox();
            this.cmbYil = new System.Windows.Forms.ComboBox();
            this.cmbAy = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.lstTaksitler = new System.Windows.Forms.ListBox();
            this.btnOdemeYap = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbPaymentMethod
            // 
            this.cmbPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentMethod.FormattingEnabled = true;
            this.cmbPaymentMethod.Location = new System.Drawing.Point(10, 9);
            this.cmbPaymentMethod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbPaymentMethod.Name = "cmbPaymentMethod";
            this.cmbPaymentMethod.Size = new System.Drawing.Size(152, 23);
            this.cmbPaymentMethod.TabIndex = 0;
            this.cmbPaymentMethod.SelectedIndexChanged += new System.EventHandler(this.cmbPaymentMethod_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCvv);
            this.groupBox1.Controls.Add(this.cmbYil);
            this.groupBox1.Controls.Add(this.cmbAy);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtAdSoyad);
            this.groupBox1.Controls.Add(this.txtCardNumber);
            this.groupBox1.Location = new System.Drawing.Point(10, 57);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(301, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kart Bilgileri";
            // 
            // txtCvv
            // 
            this.txtCvv.Location = new System.Drawing.Point(239, 67);
            this.txtCvv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCvv.Name = "txtCvv";
            this.txtCvv.PlaceholderText = "000";
            this.txtCvv.Size = new System.Drawing.Size(49, 23);
            this.txtCvv.TabIndex = 5;
            // 
            // cmbYil
            // 
            this.cmbYil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYil.FormattingEnabled = true;
            this.cmbYil.Location = new System.Drawing.Point(142, 66);
            this.cmbYil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbYil.Name = "cmbYil";
            this.cmbYil.Size = new System.Drawing.Size(46, 23);
            this.cmbYil.TabIndex = 4;
            // 
            // cmbAy
            // 
            this.cmbAy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAy.FormattingEnabled = true;
            this.cmbAy.Location = new System.Drawing.Point(91, 66);
            this.cmbAy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbAy.Name = "cmbAy";
            this.cmbAy.Size = new System.Drawing.Size(46, 23);
            this.cmbAy.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Son Kull. Tar.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(202, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "CVV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ad Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kart No";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(91, 41);
            this.txtAdSoyad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(196, 23);
            this.txtAdSoyad.TabIndex = 1;
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Location = new System.Drawing.Point(91, 15);
            this.txtCardNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.PlaceholderText = "0000 0000 0000 0000";
            this.txtCardNumber.Size = new System.Drawing.Size(196, 23);
            this.txtCardNumber.TabIndex = 0;
            // 
            // lstTaksitler
            // 
            this.lstTaksitler.FormattingEnabled = true;
            this.lstTaksitler.ItemHeight = 15;
            this.lstTaksitler.Location = new System.Drawing.Point(317, 18);
            this.lstTaksitler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstTaksitler.Name = "lstTaksitler";
            this.lstTaksitler.Size = new System.Drawing.Size(204, 199);
            this.lstTaksitler.TabIndex = 2;
            // 
            // btnOdemeYap
            // 
            this.btnOdemeYap.Location = new System.Drawing.Point(317, 220);
            this.btnOdemeYap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOdemeYap.Name = "btnOdemeYap";
            this.btnOdemeYap.Size = new System.Drawing.Size(204, 60);
            this.btnOdemeYap.TabIndex = 3;
            this.btnOdemeYap.Text = "Ödeme Yap";
            this.btnOdemeYap.UseVisualStyleBackColor = true;
            this.btnOdemeYap.Click += new System.EventHandler(this.btnOdemeYap_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 317);
            this.Controls.Add(this.btnOdemeYap);
            this.Controls.Add(this.lstTaksitler);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbPaymentMethod);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPaymentMethod;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCvv;
        private System.Windows.Forms.ComboBox cmbYil;
        private System.Windows.Forms.ComboBox cmbAy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstTaksitler;
        private System.Windows.Forms.Button btnOdemeYap;
    }
}

