namespace hastane_proje
{
    partial class frmhastadetay
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
            RchSikayet = new RichTextBox();
            groupBox2 = new GroupBox();
            Txtid = new TextBox();
            label2 = new Label();
            label7 = new Label();
            BtnRandevuAl = new Button();
            label6 = new Label();
            CmbDoktor = new ComboBox();
            label5 = new Label();
            CmbBrans = new ComboBox();
            LnkBilgiDuzenle = new LinkLabel();
            groupBox3 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox4 = new GroupBox();
            dataGridView2 = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
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
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kişi Bilgi";
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
            // RchSikayet
            // 
            RchSikayet.Location = new Point(83, 155);
            RchSikayet.Name = "RchSikayet";
            RchSikayet.Size = new Size(158, 96);
            RchSikayet.TabIndex = 1;
            RchSikayet.Text = "";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(Txtid);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(BtnRandevuAl);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(RchSikayet);
            groupBox2.Controls.Add(CmbDoktor);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(CmbBrans);
            groupBox2.Location = new Point(12, 137);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(268, 297);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Randevu Paneli";
            // 
            // Txtid
            // 
            Txtid.Enabled = false;
            Txtid.Location = new Point(83, 30);
            Txtid.Name = "Txtid";
            Txtid.Size = new Size(158, 31);
            Txtid.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 36);
            label2.Name = "label2";
            label2.Size = new Size(34, 23);
            label2.TabIndex = 8;
            label2.Text = "İd :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1, 158);
            label7.Name = "label7";
            label7.Size = new Size(76, 23);
            label7.TabIndex = 7;
            label7.Text = "Şikayet :";
            // 
            // BtnRandevuAl
            // 
            BtnRandevuAl.Location = new Point(102, 257);
            BtnRandevuAl.Name = "BtnRandevuAl";
            BtnRandevuAl.Size = new Size(121, 36);
            BtnRandevuAl.TabIndex = 3;
            BtnRandevuAl.Text = "Randevu Al";
            BtnRandevuAl.UseVisualStyleBackColor = true;
            BtnRandevuAl.Click += BtnRandevuAl_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 121);
            label6.Name = "label6";
            label6.Size = new Size(74, 23);
            label6.TabIndex = 4;
            label6.Text = "Doktor :";
            // 
            // CmbDoktor
            // 
            CmbDoktor.FormattingEnabled = true;
            CmbDoktor.Location = new Point(83, 118);
            CmbDoktor.Name = "CmbDoktor";
            CmbDoktor.Size = new Size(158, 31);
            CmbDoktor.TabIndex = 5;
            CmbDoktor.SelectedIndexChanged += CmbDoktor_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 77);
            label5.Name = "label5";
            label5.Size = new Size(63, 23);
            label5.TabIndex = 3;
            label5.Text = "Branş :";
            // 
            // CmbBrans
            // 
            CmbBrans.FormattingEnabled = true;
            CmbBrans.Location = new Point(83, 74);
            CmbBrans.Name = "CmbBrans";
            CmbBrans.Size = new Size(158, 31);
            CmbBrans.TabIndex = 6;
            CmbBrans.SelectedIndexChanged += CmbBrans_SelectedIndexChanged;
            // 
            // LnkBilgiDuzenle
            // 
            LnkBilgiDuzenle.AutoSize = true;
            LnkBilgiDuzenle.Location = new Point(12, 115);
            LnkBilgiDuzenle.Name = "LnkBilgiDuzenle";
            LnkBilgiDuzenle.Size = new Size(153, 23);
            LnkBilgiDuzenle.TabIndex = 8;
            LnkBilgiDuzenle.TabStop = true;
            LnkBilgiDuzenle.Text = "Bilgilerimi Düzenle";
            LnkBilgiDuzenle.LinkClicked += LnkBilgiDuzenle_LinkClicked;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Location = new Point(297, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(595, 216);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Randevu Geçmişi";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(589, 186);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridView2);
            groupBox4.Location = new Point(297, 234);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(595, 200);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Aktif Randevular";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(3, 27);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(589, 170);
            dataGridView2.TabIndex = 1;
            dataGridView2.CellClick += dataGridView2_CellClick;
            // 
            // frmhastadetay
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(904, 446);
            Controls.Add(LnkBilgiDuzenle);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Corbel", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmhastadetay";
            RightToLeftLayout = true;
            Text = "Hasta Detay";
            Load += frmhastadetay_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private Label LblAdSoyad;
        private Label LblTC;
        private Label label1;
        private RichTextBox RchSikayet;
        private GroupBox groupBox2;
        private Label label7;
        private Button BtnRandevuAl;
        private Label label6;
        private ComboBox CmbDoktor;
        private Label label5;
        private ComboBox CmbBrans;
        private GroupBox groupBox3;
        private DataGridView dataGridView1;
        private GroupBox groupBox4;
        private DataGridView dataGridView2;
        private LinkLabel LnkBilgiDuzenle;
        private TextBox Txtid;
        private Label label2;
    }
}