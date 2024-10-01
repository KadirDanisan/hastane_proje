namespace hastane_proje
{
    partial class frmüyekayit
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
            TxtSifre = new TextBox();
            MskTC = new MaskedTextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            TxtAd = new TextBox();
            label4 = new Label();
            label5 = new Label();
            TxtSoyad = new TextBox();
            label6 = new Label();
            MskTelefon = new MaskedTextBox();
            CmbCinsiyet = new ComboBox();
            BtnKayitYap = new Button();
            label7 = new Label();
            SuspendLayout();
            // 
            // TxtSifre
            // 
            TxtSifre.Location = new Point(180, 225);
            TxtSifre.Name = "TxtSifre";
            TxtSifre.Size = new Size(138, 31);
            TxtSifre.TabIndex = 5;
            TxtSifre.UseSystemPasswordChar = true;
            // 
            // MskTC
            // 
            MskTC.Location = new Point(180, 151);
            MskTC.Mask = "00000000000";
            MskTC.Name = "MskTC";
            MskTC.Size = new Size(138, 31);
            MskTC.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(119, 225);
            label3.Name = "label3";
            label3.Size = new Size(50, 23);
            label3.TabIndex = 7;
            label3.Text = "Şifre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 154);
            label2.Name = "label2";
            label2.Size = new Size(132, 23);
            label2.TabIndex = 8;
            label2.Text = "TC KİMLİK NO:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 259);
            label1.Name = "label1";
            label1.Size = new Size(81, 23);
            label1.TabIndex = 10;
            label1.Text = "Cinsiyet :";
            // 
            // TxtAd
            // 
            TxtAd.Location = new Point(180, 77);
            TxtAd.Name = "TxtAd";
            TxtAd.Size = new Size(138, 31);
            TxtAd.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(124, 80);
            label4.Name = "label4";
            label4.Size = new Size(45, 23);
            label4.TabIndex = 12;
            label4.Text = "Ad : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(102, 191);
            label5.Name = "label5";
            label5.Size = new Size(73, 23);
            label5.TabIndex = 14;
            label5.Text = "Phone : ";
            // 
            // TxtSoyad
            // 
            TxtSoyad.Location = new Point(179, 114);
            TxtSoyad.Name = "TxtSoyad";
            TxtSoyad.Size = new Size(138, 31);
            TxtSoyad.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(102, 114);
            label6.Name = "label6";
            label6.Size = new Size(67, 23);
            label6.TabIndex = 16;
            label6.Text = "Soyad :";
            // 
            // MskTelefon
            // 
            MskTelefon.Location = new Point(181, 188);
            MskTelefon.Mask = "(999) 000-0000";
            MskTelefon.Name = "MskTelefon";
            MskTelefon.Size = new Size(138, 31);
            MskTelefon.TabIndex = 4;
            // 
            // CmbCinsiyet
            // 
            CmbCinsiyet.FormattingEnabled = true;
            CmbCinsiyet.Items.AddRange(new object[] { "E", "K" });
            CmbCinsiyet.Location = new Point(181, 262);
            CmbCinsiyet.Name = "CmbCinsiyet";
            CmbCinsiyet.Size = new Size(138, 31);
            CmbCinsiyet.TabIndex = 6;
            // 
            // BtnKayitYap
            // 
            BtnKayitYap.Location = new Point(181, 308);
            BtnKayitYap.Name = "BtnKayitYap";
            BtnKayitYap.Size = new Size(138, 40);
            BtnKayitYap.TabIndex = 7;
            BtnKayitYap.Text = "Kayıt Yap";
            BtnKayitYap.UseVisualStyleBackColor = true;
            BtnKayitYap.Click += BtnKayitYap_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Corbel", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label7.Location = new Point(133, 24);
            label7.Name = "label7";
            label7.Size = new Size(186, 36);
            label7.TabIndex = 21;
            label7.Text = "Hasta Kayıt Ol";
            // 
            // frmüyekayit
            // 
            AcceptButton = BtnKayitYap;
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(398, 372);
            Controls.Add(label7);
            Controls.Add(BtnKayitYap);
            Controls.Add(CmbCinsiyet);
            Controls.Add(MskTelefon);
            Controls.Add(TxtSoyad);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(TxtAd);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(TxtSifre);
            Controls.Add(MskTC);
            Controls.Add(label3);
            Controls.Add(label2);
            Font = new Font("Corbel", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmüyekayit";
            Text = "Hasta Kayıt";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtSifre;
        private MaskedTextBox MskTC;
        private Label label3;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private TextBox TxtAd;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private TextBox TxtSoyad;
        private Label label6;
        private MaskedTextBox MskTelefon;
        private ComboBox CmbCinsiyet;
        private Button BtnKayitYap;
        private Label label7;
    }
}