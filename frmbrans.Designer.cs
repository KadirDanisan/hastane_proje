namespace hastane_proje
{
    partial class frmbrans
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
            BtnEkle = new Button();
            BtnSil = new Button();
            dataGridView1 = new DataGridView();
            BtnGuncelle = new Button();
            Txtid = new TextBox();
            label6 = new Label();
            TxtBrans = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // BtnEkle
            // 
            BtnEkle.Location = new Point(69, 97);
            BtnEkle.Name = "BtnEkle";
            BtnEkle.Size = new Size(61, 40);
            BtnEkle.TabIndex = 77;
            BtnEkle.Text = "Ekle";
            BtnEkle.UseVisualStyleBackColor = true;
            BtnEkle.Click += BtnEkle_Click;
            // 
            // BtnSil
            // 
            BtnSil.Location = new Point(147, 97);
            BtnSil.Name = "BtnSil";
            BtnSil.Size = new Size(61, 40);
            BtnSil.TabIndex = 76;
            BtnSil.Text = "Sil";
            BtnSil.UseVisualStyleBackColor = true;
            BtnSil.Click += BtnSil_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(239, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(322, 160);
            dataGridView1.TabIndex = 75;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // BtnGuncelle
            // 
            BtnGuncelle.Location = new Point(69, 143);
            BtnGuncelle.Name = "BtnGuncelle";
            BtnGuncelle.Size = new Size(139, 40);
            BtnGuncelle.TabIndex = 74;
            BtnGuncelle.Text = "Güncelle";
            BtnGuncelle.UseVisualStyleBackColor = true;
            BtnGuncelle.Click += BtnGuncelle_Click;
            // 
            // Txtid
            // 
            Txtid.Location = new Point(70, 60);
            Txtid.Name = "Txtid";
            Txtid.Size = new Size(138, 31);
            Txtid.TabIndex = 73;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 60);
            label6.Name = "label6";
            label6.Size = new Size(34, 23);
            label6.TabIndex = 72;
            label6.Text = "İd :";
            // 
            // TxtBrans
            // 
            TxtBrans.Location = new Point(71, 23);
            TxtBrans.Name = "TxtBrans";
            TxtBrans.Size = new Size(138, 31);
            TxtBrans.TabIndex = 71;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 26);
            label4.Name = "label4";
            label4.Size = new Size(45, 23);
            label4.TabIndex = 70;
            label4.Text = "Ad : ";
            // 
            // frmbrans
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(622, 215);
            Controls.Add(BtnEkle);
            Controls.Add(BtnSil);
            Controls.Add(dataGridView1);
            Controls.Add(BtnGuncelle);
            Controls.Add(Txtid);
            Controls.Add(label6);
            Controls.Add(TxtBrans);
            Controls.Add(label4);
            Font = new Font("Corbel", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmbrans";
            Text = "frmbrans";
            Load += frmbrans_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnEkle;
        private Button BtnSil;
        private DataGridView dataGridView1;
        private Button BtnGuncelle;
        private TextBox Txtid;
        private Label label6;
        private TextBox TxtBrans;
        private Label label4;
    }
}