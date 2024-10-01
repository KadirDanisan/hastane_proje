namespace hastane_proje
{
    partial class frmbilgiduzenle
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
            BtnBilgiGuncelle = new Button();
            CmbCinsiyet = new ComboBox();
            MskTelefon = new MaskedTextBox();
            TxtSoyad = new TextBox();
            label6 = new Label();
            label5 = new Label();
            TxtAd = new TextBox();
            label4 = new Label();
            label1 = new Label();
            TxtSifre = new TextBox();
            MskTC = new MaskedTextBox();
            label3 = new Label();
            label2 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // BtnBilgiGuncelle
            // 
            BtnBilgiGuncelle.Location = new Point(158, 302);
            BtnBilgiGuncelle.Name = "BtnBilgiGuncelle";
            BtnBilgiGuncelle.Size = new Size(138, 40);
            BtnBilgiGuncelle.TabIndex = 7;
            BtnBilgiGuncelle.Text = "Güncelle";
            BtnBilgiGuncelle.UseVisualStyleBackColor = true;
            BtnBilgiGuncelle.Click += BtnBilgiGuncelle_Click;
            // 
            // CmbCinsiyet
            // 
            CmbCinsiyet.FormattingEnabled = true;
            CmbCinsiyet.Items.AddRange(new object[] { "Erkek ", "Kadın" });
            CmbCinsiyet.Location = new Point(158, 256);
            CmbCinsiyet.Name = "CmbCinsiyet";
            CmbCinsiyet.Size = new Size(138, 31);
            CmbCinsiyet.TabIndex = 6;
            // 
            // MskTelefon
            // 
            MskTelefon.Location = new Point(158, 182);
            MskTelefon.Mask = "(999) 000-0000";
            MskTelefon.Name = "MskTelefon";
            MskTelefon.Size = new Size(138, 31);
            MskTelefon.TabIndex = 4;
            // 
            // TxtSoyad
            // 
            TxtSoyad.Location = new Point(156, 108);
            TxtSoyad.Name = "TxtSoyad";
            TxtSoyad.Size = new Size(138, 31);
            TxtSoyad.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(79, 108);
            label6.Name = "label6";
            label6.Size = new Size(67, 23);
            label6.TabIndex = 29;
            label6.Text = "Soyad :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(79, 185);
            label5.Name = "label5";
            label5.Size = new Size(73, 23);
            label5.TabIndex = 28;
            label5.Text = "Phone : ";
            // 
            // TxtAd
            // 
            TxtAd.Location = new Point(157, 71);
            TxtAd.Name = "TxtAd";
            TxtAd.Size = new Size(138, 31);
            TxtAd.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(101, 74);
            label4.Name = "label4";
            label4.Size = new Size(45, 23);
            label4.TabIndex = 26;
            label4.Text = "Ad : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 253);
            label1.Name = "label1";
            label1.Size = new Size(81, 23);
            label1.TabIndex = 25;
            label1.Text = "Cinsiyet :";
            // 
            // TxtSifre
            // 
            TxtSifre.Location = new Point(157, 219);
            TxtSifre.Name = "TxtSifre";
            TxtSifre.Size = new Size(138, 31);
            TxtSifre.TabIndex = 5;
            TxtSifre.UseSystemPasswordChar = true;
            // 
            // MskTC
            // 
            MskTC.Location = new Point(157, 145);
            MskTC.Mask = "00000000000";
            MskTC.Name = "MskTC";
            MskTC.Size = new Size(138, 31);
            MskTC.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(96, 219);
            label3.Name = "label3";
            label3.Size = new Size(50, 23);
            label3.TabIndex = 22;
            label3.Text = "Şifre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 148);
            label2.Name = "label2";
            label2.Size = new Size(132, 23);
            label2.TabIndex = 21;
            label2.Text = "TC KİMLİK NO:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Corbel", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label7.Location = new Point(65, 9);
            label7.Name = "label7";
            label7.Size = new Size(262, 36);
            label7.TabIndex = 34;
            label7.Text = "Hasta Kayıt Güncelle";
            // 
            // frmbilgiduzenle
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(369, 375);
            Controls.Add(label7);
            Controls.Add(BtnBilgiGuncelle);
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
            Name = "frmbilgiduzenle";
            Text = "Bilgi Düzenle";
            Load += frmbilgiduzenle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnBilgiGuncelle;
        private ComboBox CmbCinsiyet;
        private MaskedTextBox MskTelefon;
        private TextBox TxtSoyad;
        private Label label6;
        private Label label5;
        private TextBox TxtAd;
        private Label label4;
        private Label label1;
        private TextBox TxtSifre;
        private MaskedTextBox MskTC;
        private Label label3;
        private Label label2;
        private Label label7;
    }
}