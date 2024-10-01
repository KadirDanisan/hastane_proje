namespace hastane_proje
{
    partial class frmdoktorbilgiduzenle
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
            TxtSoyad = new TextBox();
            label6 = new Label();
            TxtAd = new TextBox();
            label4 = new Label();
            TxtSifre = new TextBox();
            MskTC = new MaskedTextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            CmdBrans = new ComboBox();
            SuspendLayout();
            // 
            // BtnBilgiGuncelle
            // 
            BtnBilgiGuncelle.Location = new Point(146, 209);
            BtnBilgiGuncelle.Name = "BtnBilgiGuncelle";
            BtnBilgiGuncelle.Size = new Size(138, 40);
            BtnBilgiGuncelle.TabIndex = 42;
            BtnBilgiGuncelle.Text = "Güncelle";
            BtnBilgiGuncelle.UseVisualStyleBackColor = true;
            BtnBilgiGuncelle.Click += BtnBilgiGuncelle_Click;
            // 
            // TxtSoyad
            // 
            TxtSoyad.Location = new Point(146, 44);
            TxtSoyad.Name = "TxtSoyad";
            TxtSoyad.Size = new Size(138, 31);
            TxtSoyad.TabIndex = 41;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(69, 44);
            label6.Name = "label6";
            label6.Size = new Size(67, 23);
            label6.TabIndex = 40;
            label6.Text = "Soyad :";
            // 
            // TxtAd
            // 
            TxtAd.Location = new Point(147, 7);
            TxtAd.Name = "TxtAd";
            TxtAd.Size = new Size(138, 31);
            TxtAd.TabIndex = 39;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(91, 10);
            label4.Name = "label4";
            label4.Size = new Size(45, 23);
            label4.TabIndex = 38;
            label4.Text = "Ad : ";
            // 
            // TxtSifre
            // 
            TxtSifre.Location = new Point(146, 118);
            TxtSifre.Name = "TxtSifre";
            TxtSifre.Size = new Size(138, 31);
            TxtSifre.TabIndex = 37;
            TxtSifre.UseSystemPasswordChar = true;
            // 
            // MskTC
            // 
            MskTC.Location = new Point(147, 81);
            MskTC.Mask = "00000000000";
            MskTC.Name = "MskTC";
            MskTC.Size = new Size(138, 31);
            MskTC.TabIndex = 36;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(85, 118);
            label3.Name = "label3";
            label3.Size = new Size(50, 23);
            label3.TabIndex = 35;
            label3.Text = "Şifre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 84);
            label2.Name = "label2";
            label2.Size = new Size(132, 23);
            label2.TabIndex = 34;
            label2.Text = "TC KİMLİK NO:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 151);
            label1.Name = "label1";
            label1.Size = new Size(59, 23);
            label1.TabIndex = 43;
            label1.Text = "Branş:";
            // 
            // CmdBrans
            // 
            CmdBrans.FormattingEnabled = true;
            CmdBrans.Location = new Point(147, 155);
            CmdBrans.Name = "CmdBrans";
            CmdBrans.Size = new Size(138, 31);
            CmdBrans.TabIndex = 44;
            // 
            // frmdoktorbilgiduzenle
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(364, 261);
            Controls.Add(CmdBrans);
            Controls.Add(label1);
            Controls.Add(BtnBilgiGuncelle);
            Controls.Add(TxtSoyad);
            Controls.Add(label6);
            Controls.Add(TxtAd);
            Controls.Add(label4);
            Controls.Add(TxtSifre);
            Controls.Add(MskTC);
            Controls.Add(label3);
            Controls.Add(label2);
            Font = new Font("Corbel", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmdoktorbilgiduzenle";
            Text = "Doktor Bilgi Düzenle";
            Load += frmdoktorbilgiduzenle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnBilgiGuncelle;
        private TextBox TxtSoyad;
        private Label label6;
        private TextBox TxtAd;
        private Label label4;
        private TextBox TxtSifre;
        private MaskedTextBox MskTC;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox CmdBrans;
    }
}