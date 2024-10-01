namespace hastane_proje
{
    partial class frmdoktorpaneli
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
            CmbBrans = new ComboBox();
            BtnEkle = new Button();
            BtnSil = new Button();
            dataGridView1 = new DataGridView();
            BtnGuncelle = new Button();
            TxtSoyad = new TextBox();
            label6 = new Label();
            TxtAd = new TextBox();
            label4 = new Label();
            TxtSifre = new TextBox();
            MskTC = new MaskedTextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // CmbBrans
            // 
            CmbBrans.FormattingEnabled = true;
            CmbBrans.Items.AddRange(new object[] { "Erkek ", "Kadın" });
            CmbBrans.Location = new Point(168, 137);
            CmbBrans.Name = "CmbBrans";
            CmbBrans.Size = new Size(138, 31);
            CmbBrans.TabIndex = 4;
            // 
            // BtnEkle
            // 
            BtnEkle.Location = new Point(169, 220);
            BtnEkle.Name = "BtnEkle";
            BtnEkle.Size = new Size(61, 40);
            BtnEkle.TabIndex = 6;
            BtnEkle.Text = "Ekle";
            BtnEkle.UseVisualStyleBackColor = true;
            BtnEkle.Click += BtnEkle_Click;
            // 
            // BtnSil
            // 
            BtnSil.Location = new Point(247, 220);
            BtnSil.Name = "BtnSil";
            BtnSil.Size = new Size(61, 40);
            BtnSil.TabIndex = 7;
            BtnSil.Text = "Sil";
            BtnSil.UseVisualStyleBackColor = true;
            BtnSil.Click += BtnSil_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(337, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(322, 280);
            dataGridView1.TabIndex = 75;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // BtnGuncelle
            // 
            BtnGuncelle.Location = new Point(169, 266);
            BtnGuncelle.Name = "BtnGuncelle";
            BtnGuncelle.Size = new Size(139, 40);
            BtnGuncelle.TabIndex = 8;
            BtnGuncelle.Text = "Güncelle";
            BtnGuncelle.UseVisualStyleBackColor = true;
            BtnGuncelle.Click += BtnGuncelle_Click;
            // 
            // TxtSoyad
            // 
            TxtSoyad.Location = new Point(168, 63);
            TxtSoyad.Name = "TxtSoyad";
            TxtSoyad.Size = new Size(138, 31);
            TxtSoyad.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(91, 63);
            label6.Name = "label6";
            label6.Size = new Size(67, 23);
            label6.TabIndex = 72;
            label6.Text = "Soyad :";
            // 
            // TxtAd
            // 
            TxtAd.Location = new Point(169, 26);
            TxtAd.Name = "TxtAd";
            TxtAd.Size = new Size(138, 31);
            TxtAd.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(113, 29);
            label4.Name = "label4";
            label4.Size = new Size(45, 23);
            label4.TabIndex = 70;
            label4.Text = "Ad : ";
            // 
            // TxtSifre
            // 
            TxtSifre.Location = new Point(169, 174);
            TxtSifre.Name = "TxtSifre";
            TxtSifre.Size = new Size(138, 31);
            TxtSifre.TabIndex = 5;
            TxtSifre.UseSystemPasswordChar = true;
            // 
            // MskTC
            // 
            MskTC.Location = new Point(169, 100);
            MskTC.Name = "MskTC";
            MskTC.Size = new Size(138, 31);
            MskTC.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(104, 174);
            label3.Name = "label3";
            label3.Size = new Size(50, 23);
            label3.TabIndex = 67;
            label3.Text = "Şifre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 103);
            label2.Name = "label2";
            label2.Size = new Size(132, 23);
            label2.TabIndex = 66;
            label2.Text = "TC KİMLİK NO:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 140);
            label1.Name = "label1";
            label1.Size = new Size(63, 23);
            label1.TabIndex = 79;
            label1.Text = "Branş :";
            // 
            // frmdoktorpaneli
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(719, 317);
            Controls.Add(label1);
            Controls.Add(CmbBrans);
            Controls.Add(BtnEkle);
            Controls.Add(BtnSil);
            Controls.Add(dataGridView1);
            Controls.Add(BtnGuncelle);
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
            Name = "frmdoktorpaneli";
            Text = "frmdoktorpaneli";
            Load += frmdoktorpaneli_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox CmbBrans;
        private Button BtnEkle;
        private Button BtnSil;
        private DataGridView dataGridView1;
        private Button BtnGuncelle;
        private TextBox TxtSoyad;
        private Label label6;
        private TextBox TxtAd;
        private Label label4;
        private TextBox TxtSifre;
        private MaskedTextBox MskTC;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}