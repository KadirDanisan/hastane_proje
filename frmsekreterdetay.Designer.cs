namespace hastane_proje
{
    partial class frmsekreterdetay
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
            groupBox1 = new GroupBox();
            label4 = new Label();
            LblAdSoyad = new Label();
            LblTC = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            BtnDuyuruOlustur = new Button();
            RchDuyuru = new RichTextBox();
            groupBox3 = new GroupBox();
            BtnKaydet = new Button();
            ChkDurum = new CheckBox();
            MskTC = new MaskedTextBox();
            CmdDoktor = new ComboBox();
            CmbBrans = new ComboBox();
            MskSaat = new MaskedTextBox();
            MskTarih = new MaskedTextBox();
            Txtid = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox4 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox5 = new GroupBox();
            dataGridView2 = new DataGridView();
            groupBox6 = new GroupBox();
            BtnRandevuListesi = new Button();
            BtnBransPanel = new Button();
            BtnDoktorPanel = new Button();
            BtnDuyrular = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(LblAdSoyad);
            groupBox1.Controls.Add(LblTC);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(268, 100);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sekreter Bilgi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 62);
            label4.Name = "label4";
            label4.Size = new Size(93, 23);
            label4.TabIndex = 4;
            label4.Text = "Ad Soyad :";
            // 
            // LblAdSoyad
            // 
            LblAdSoyad.AutoSize = true;
            LblAdSoyad.Location = new Point(105, 62);
            LblAdSoyad.Name = "LblAdSoyad";
            LblAdSoyad.Size = new Size(41, 23);
            LblAdSoyad.TabIndex = 3;
            LblAdSoyad.Text = "Null";
            // 
            // LblTC
            // 
            LblTC.AutoSize = true;
            LblTC.Location = new Point(74, 27);
            LblTC.Name = "LblTC";
            LblTC.Size = new Size(120, 23);
            LblTC.TabIndex = 2;
            LblTC.Text = "00000000000";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 27);
            label1.Name = "label1";
            label1.Size = new Size(72, 23);
            label1.TabIndex = 1;
            label1.Text = "TC NO :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(BtnDuyuruOlustur);
            groupBox2.Controls.Add(RchDuyuru);
            groupBox2.Location = new Point(12, 127);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(268, 374);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Duyuru Oluştur";
            // 
            // BtnDuyuruOlustur
            // 
            BtnDuyuruOlustur.Location = new Point(52, 332);
            BtnDuyuruOlustur.Name = "BtnDuyuruOlustur";
            BtnDuyuruOlustur.Size = new Size(142, 36);
            BtnDuyuruOlustur.TabIndex = 3;
            BtnDuyuruOlustur.Text = "Duyuru Oluştur";
            BtnDuyuruOlustur.UseVisualStyleBackColor = true;
            // 
            // RchDuyuru
            // 
            RchDuyuru.Location = new Point(15, 30);
            RchDuyuru.Name = "RchDuyuru";
            RchDuyuru.Size = new Size(229, 296);
            RchDuyuru.TabIndex = 1;
            RchDuyuru.Text = "";
            RchDuyuru.TextChanged += RchDuyuru_TextChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(BtnKaydet);
            groupBox3.Controls.Add(ChkDurum);
            groupBox3.Controls.Add(MskTC);
            groupBox3.Controls.Add(CmdDoktor);
            groupBox3.Controls.Add(CmbBrans);
            groupBox3.Controls.Add(MskSaat);
            groupBox3.Controls.Add(MskTarih);
            groupBox3.Controls.Add(Txtid);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Location = new Point(286, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(266, 348);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Randevu Paneli";
            // 
            // BtnKaydet
            // 
            BtnKaydet.Location = new Point(113, 306);
            BtnKaydet.Name = "BtnKaydet";
            BtnKaydet.Size = new Size(121, 36);
            BtnKaydet.TabIndex = 15;
            BtnKaydet.Text = "Kaydet";
            BtnKaydet.UseVisualStyleBackColor = true;
            BtnKaydet.Click += BtnKaydet_Click;
            // 
            // ChkDurum
            // 
            ChkDurum.AutoSize = true;
            ChkDurum.Location = new Point(113, 278);
            ChkDurum.Name = "ChkDurum";
            ChkDurum.Size = new Size(15, 14);
            ChkDurum.TabIndex = 13;
            ChkDurum.UseVisualStyleBackColor = true;
            // 
            // MskTC
            // 
            MskTC.Location = new Point(113, 232);
            MskTC.Mask = "00000000000";
            MskTC.Name = "MskTC";
            MskTC.Size = new Size(121, 31);
            MskTC.TabIndex = 12;
            // 
            // CmdDoktor
            // 
            CmdDoktor.FormattingEnabled = true;
            CmdDoktor.Location = new Point(113, 195);
            CmdDoktor.Name = "CmdDoktor";
            CmdDoktor.Size = new Size(121, 31);
            CmdDoktor.TabIndex = 11;
            // 
            // CmbBrans
            // 
            CmbBrans.FormattingEnabled = true;
            CmbBrans.Location = new Point(113, 159);
            CmbBrans.Name = "CmbBrans";
            CmbBrans.Size = new Size(121, 31);
            CmbBrans.TabIndex = 10;
            CmbBrans.SelectedIndexChanged += CmdBrans_SelectedIndexChanged;
            // 
            // MskSaat
            // 
            MskSaat.Location = new Point(113, 122);
            MskSaat.Mask = "00:00";
            MskSaat.Name = "MskSaat";
            MskSaat.Size = new Size(121, 31);
            MskSaat.TabIndex = 9;
            MskSaat.ValidatingType = typeof(DateTime);
            // 
            // MskTarih
            // 
            MskTarih.Location = new Point(113, 82);
            MskTarih.Mask = "00/00/0000";
            MskTarih.Name = "MskTarih";
            MskTarih.Size = new Size(121, 31);
            MskTarih.TabIndex = 8;
            MskTarih.ValidatingType = typeof(DateTime);
            // 
            // Txtid
            // 
            Txtid.Location = new Point(113, 45);
            Txtid.Name = "Txtid";
            Txtid.Size = new Size(121, 31);
            Txtid.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(33, 269);
            label9.Name = "label9";
            label9.Size = new Size(74, 23);
            label9.TabIndex = 6;
            label9.Text = "Durum :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(44, 160);
            label8.Name = "label8";
            label8.Size = new Size(63, 23);
            label8.TabIndex = 5;
            label8.Text = "Branş :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(33, 198);
            label7.Name = "label7";
            label7.Size = new Size(74, 23);
            label7.TabIndex = 4;
            label7.Text = "Doktor :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(70, 234);
            label6.Name = "label6";
            label6.Size = new Size(37, 23);
            label6.TabIndex = 3;
            label6.Text = "Tc :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(49, 85);
            label5.Name = "label5";
            label5.Size = new Size(58, 23);
            label5.TabIndex = 2;
            label5.Text = "Tarih :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 122);
            label3.Name = "label3";
            label3.Size = new Size(54, 23);
            label3.TabIndex = 1;
            label3.Text = "Saat :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 48);
            label2.Name = "label2";
            label2.Size = new Size(34, 23);
            label2.TabIndex = 0;
            label2.Text = "İd :";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridView1);
            groupBox4.Location = new Point(558, 12);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(380, 240);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "Branşlar";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(374, 210);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(dataGridView2);
            groupBox5.Location = new Point(558, 258);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(380, 243);
            groupBox5.TabIndex = 6;
            groupBox5.TabStop = false;
            groupBox5.Text = "Doktorlar";
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(3, 27);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(374, 213);
            dataGridView2.TabIndex = 1;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(BtnDuyrular);
            groupBox6.Controls.Add(BtnRandevuListesi);
            groupBox6.Controls.Add(BtnBransPanel);
            groupBox6.Controls.Add(BtnDoktorPanel);
            groupBox6.Location = new Point(286, 366);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(266, 135);
            groupBox6.TabIndex = 7;
            groupBox6.TabStop = false;
            groupBox6.Text = "Hızlı Erişim";
            // 
            // BtnRandevuListesi
            // 
            BtnRandevuListesi.Location = new Point(9, 82);
            BtnRandevuListesi.Name = "BtnRandevuListesi";
            BtnRandevuListesi.Size = new Size(119, 36);
            BtnRandevuListesi.TabIndex = 18;
            BtnRandevuListesi.Text = "Randevu Listesi";
            BtnRandevuListesi.UseVisualStyleBackColor = true;
            BtnRandevuListesi.Click += BtnRandevuListesi_Click;
            // 
            // BtnBransPanel
            // 
            BtnBransPanel.Location = new Point(139, 40);
            BtnBransPanel.Name = "BtnBransPanel";
            BtnBransPanel.Size = new Size(121, 36);
            BtnBransPanel.TabIndex = 17;
            BtnBransPanel.Text = "Branş";
            BtnBransPanel.UseVisualStyleBackColor = true;
            BtnBransPanel.Click += BtnBransPanel_Click;
            // 
            // BtnDoktorPanel
            // 
            BtnDoktorPanel.Location = new Point(9, 40);
            BtnDoktorPanel.Name = "BtnDoktorPanel";
            BtnDoktorPanel.Size = new Size(121, 36);
            BtnDoktorPanel.TabIndex = 16;
            BtnDoktorPanel.Text = "Doktor";
            BtnDoktorPanel.UseVisualStyleBackColor = true;
            BtnDoktorPanel.Click += BtnDoktorPanel_Click;
            // 
            // BtnDuyrular
            // 
            BtnDuyrular.Location = new Point(139, 82);
            BtnDuyrular.Name = "BtnDuyrular";
            BtnDuyrular.Size = new Size(119, 36);
            BtnDuyrular.TabIndex = 19;
            BtnDuyrular.Text = "Duyrular";
            BtnDuyrular.UseVisualStyleBackColor = true;
            BtnDuyrular.Click += BtnDuyrular_Click;
            // 
            // frmsekreterdetay
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(950, 513);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Corbel", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmsekreterdetay";
            Text = "Sekreter Detay";
            Load += frmsekreterdetay_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private Label LblAdSoyad;
        private Label LblTC;
        private Label label1;
        private GroupBox groupBox2;
        private Button BtnDuyuruOlustur;
        private RichTextBox RchDuyuru;
        private GroupBox groupBox3;
        private Label label5;
        private Label label3;
        private Label label2;
        private GroupBox groupBox4;
        private MaskedTextBox MskSaat;
        private MaskedTextBox MskTarih;
        private TextBox Txtid;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private MaskedTextBox MskTC;
        private ComboBox CmdDoktor;
        private ComboBox CmbBrans;
        private CheckBox ChkDurum;
        private Button BtnKaydet;
        private GroupBox groupBox5;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private GroupBox groupBox6;
        private Button BtnRandevuListesi;
        private Button BtnBransPanel;
        private Button BtnDoktorPanel;
        private Button BtnDuyrular;
    }
}