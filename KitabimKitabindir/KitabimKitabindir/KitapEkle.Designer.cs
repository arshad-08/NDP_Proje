namespace KitabimKitabindir
{
    partial class KitapEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitapEkle));
            this.label1 = new System.Windows.Forms.Label();
            this.linkGeriDon1 = new System.Windows.Forms.LinkLabel();
            this.txtKitap = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnCikis2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label1.Location = new System.Drawing.Point(33, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eklemek istediğniz kitabın adı yazınız ";
            // 
            // linkGeriDon1
            // 
            this.linkGeriDon1.AutoSize = true;
            this.linkGeriDon1.BackColor = System.Drawing.Color.Transparent;
            this.linkGeriDon1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkGeriDon1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkGeriDon1.LinkColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.linkGeriDon1.Location = new System.Drawing.Point(408, 334);
            this.linkGeriDon1.Name = "linkGeriDon1";
            this.linkGeriDon1.Size = new System.Drawing.Size(85, 24);
            this.linkGeriDon1.TabIndex = 15;
            this.linkGeriDon1.TabStop = true;
            this.linkGeriDon1.Text = "Geri Dön";
            this.linkGeriDon1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkGeriDon1_LinkClicked);
            // 
            // txtKitap
            // 
            this.txtKitap.Location = new System.Drawing.Point(363, 120);
            this.txtKitap.Multiline = true;
            this.txtKitap.Name = "txtKitap";
            this.txtKitap.Size = new System.Drawing.Size(139, 28);
            this.txtKitap.TabIndex = 13;
            this.txtKitap.TextChanged += new System.EventHandler(this.txtKitap_TextChanged);
            // 
            // btnEkle
            // 
            this.btnEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnEkle.Location = new System.Drawing.Point(392, 170);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(80, 27);
            this.btnEkle.TabIndex = 14;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnCikis2
            // 
            this.btnCikis2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCikis2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis2.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnCikis2.Location = new System.Drawing.Point(92, 331);
            this.btnCikis2.Name = "btnCikis2";
            this.btnCikis2.Size = new System.Drawing.Size(87, 27);
            this.btnCikis2.TabIndex = 4;
            this.btnCikis2.Text = "Çıkış";
            this.btnCikis2.UseVisualStyleBackColor = true;
            this.btnCikis2.Click += new System.EventHandler(this.btnCikis2_Click);
            // 
            // KitapEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.btnCikis2);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtKitap);
            this.Controls.Add(this.linkGeriDon1);
            this.Controls.Add(this.label1);
            this.Name = "KitapEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KitapEkle";
            this.Load += new System.EventHandler(this.KitapEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkGeriDon1;
        private System.Windows.Forms.TextBox txtKitap;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnCikis2;
    }
}