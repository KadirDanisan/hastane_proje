namespace hastane_proje
{
    partial class frmhastagiris
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            MskTC = new MaskedTextBox();
            TxtSifre = new TextBox();
            BtnGirisYap = new Button();
            LnkUyeOl = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Corbel", 24F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(71, 22);
            label1.Name = "label1";
            label1.Size = new Size(258, 39);
            label1.TabIndex = 0;
            label1.Text = "Hasta Giriş Paneli";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 80);
            label2.Name = "label2";
            label2.Size = new Size(132, 23);
            label2.TabIndex = 1;
            label2.Text = "TC KİMLİK NO:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(102, 113);
            label3.Name = "label3";
            label3.Size = new Size(50, 23);
            label3.TabIndex = 2;
            label3.Text = "Şifre:";
            // 
            // MskTC
            // 
            MskTC.Location = new Point(158, 77);
            MskTC.Mask = "00000000000";
            MskTC.Name = "MskTC";
            MskTC.Size = new Size(138, 31);
            MskTC.TabIndex = 4;
            // 
            // TxtSifre
            // 
            TxtSifre.Location = new Point(158, 114);
            TxtSifre.Name = "TxtSifre";
            TxtSifre.Size = new Size(138, 31);
            TxtSifre.TabIndex = 5;
            TxtSifre.UseSystemPasswordChar = true;
            // 
            // BtnGirisYap
            // 
            BtnGirisYap.Location = new Point(157, 151);
            BtnGirisYap.Name = "BtnGirisYap";
            BtnGirisYap.Size = new Size(138, 33);
            BtnGirisYap.TabIndex = 6;
            BtnGirisYap.Text = "Giriş Yap";
            BtnGirisYap.UseVisualStyleBackColor = true;
            BtnGirisYap.Click += BtnGirisYap_Click;
            // 
            // LnkUyeOl
            // 
            LnkUyeOl.AutoSize = true;
            LnkUyeOl.Location = new Point(313, 122);
            LnkUyeOl.Name = "LnkUyeOl";
            LnkUyeOl.Size = new Size(62, 23);
            LnkUyeOl.TabIndex = 7;
            LnkUyeOl.TabStop = true;
            LnkUyeOl.Text = "Üye Ol";
            LnkUyeOl.LinkClicked += LnkUyeOl_LinkClicked;
            // 
            // frmhastagiris
            // 
            AcceptButton = BtnGirisYap;
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(441, 210);
            Controls.Add(LnkUyeOl);
            Controls.Add(BtnGirisYap);
            Controls.Add(TxtSifre);
            Controls.Add(MskTC);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Corbel", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmhastagiris";
            Text = "Hasta Giriş";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private MaskedTextBox MskTC;
        private TextBox TxtSifre;
        private Button BtnGirisYap;
        private LinkLabel LnkUyeOl;
    }
}