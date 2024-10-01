namespace hastane_proje
{
    partial class frmgirisler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmgirisler));
            BtnHastaGirisi = new Button();
            BtnDoktorGirisi = new Button();
            BtnSekreterGirisi = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // BtnHastaGirisi
            // 
            BtnHastaGirisi.BackgroundImage = (Image)resources.GetObject("BtnHastaGirisi.BackgroundImage");
            BtnHastaGirisi.BackgroundImageLayout = ImageLayout.Stretch;
            BtnHastaGirisi.Location = new Point(114, 45);
            BtnHastaGirisi.Name = "BtnHastaGirisi";
            BtnHastaGirisi.Size = new Size(150, 89);
            BtnHastaGirisi.TabIndex = 0;
            BtnHastaGirisi.UseVisualStyleBackColor = true;
            BtnHastaGirisi.Click += BtnHastaGirisi_Click;
            // 
            // BtnDoktorGirisi
            // 
            BtnDoktorGirisi.BackColor = SystemColors.ControlDark;
            BtnDoktorGirisi.BackgroundImage = (Image)resources.GetObject("BtnDoktorGirisi.BackgroundImage");
            BtnDoktorGirisi.BackgroundImageLayout = ImageLayout.Stretch;
            BtnDoktorGirisi.Location = new Point(344, 45);
            BtnDoktorGirisi.Name = "BtnDoktorGirisi";
            BtnDoktorGirisi.Size = new Size(143, 89);
            BtnDoktorGirisi.TabIndex = 1;
            BtnDoktorGirisi.UseVisualStyleBackColor = false;
            BtnDoktorGirisi.Click += BtnDoktorGirisi_Click;
            // 
            // BtnSekreterGirisi
            // 
            BtnSekreterGirisi.BackgroundImage = (Image)resources.GetObject("BtnSekreterGirisi.BackgroundImage");
            BtnSekreterGirisi.BackgroundImageLayout = ImageLayout.Stretch;
            BtnSekreterGirisi.Location = new Point(545, 45);
            BtnSekreterGirisi.Name = "BtnSekreterGirisi";
            BtnSekreterGirisi.Size = new Size(148, 89);
            BtnSekreterGirisi.TabIndex = 2;
            BtnSekreterGirisi.UseVisualStyleBackColor = true;
            BtnSekreterGirisi.Click += BtnSekreterGirisi_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(379, 150);
            label1.Name = "label1";
            label1.Size = new Size(72, 25);
            label1.TabIndex = 3;
            label1.Text = "Doktor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(157, 150);
            label2.Name = "label2";
            label2.Size = new Size(61, 25);
            label2.TabIndex = 4;
            label2.Text = "Hasta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(579, 150);
            label3.Name = "label3";
            label3.Size = new Size(83, 25);
            label3.TabIndex = 5;
            label3.Text = "Sekreter";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(128, 225);
            label4.Name = "label4";
            label4.Size = new Size(184, 32);
            label4.TabIndex = 6;
            label4.Text = "A HOSPİTAL";
            // 
            // frmgirisler
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 326);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnSekreterGirisi);
            Controls.Add(BtnDoktorGirisi);
            Controls.Add(BtnHastaGirisi);
            MaximizeBox = false;
            Name = "frmgirisler";
            Text = "A HOSPİTAL";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnHastaGirisi;
        private Button BtnDoktorGirisi;
        private Button BtnSekreterGirisi;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
