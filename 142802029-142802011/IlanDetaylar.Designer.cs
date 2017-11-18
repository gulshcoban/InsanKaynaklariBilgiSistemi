namespace _142802029_142802011
{
    partial class frmDetaylar
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
            this.btnIseAl = new System.Windows.Forms.Button();
            this.btnTumKisileriGor = new System.Windows.Forms.Button();
            this.btnBasvuruYap = new System.Windows.Forms.Button();
            this.listBoxIlanlar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnIseAl
            // 
            this.btnIseAl.Location = new System.Drawing.Point(22, 146);
            this.btnIseAl.Name = "btnIseAl";
            this.btnIseAl.Size = new System.Drawing.Size(341, 23);
            this.btnIseAl.TabIndex = 7;
            this.btnIseAl.Text = "En Uygun Adayı İşe Alın";
            this.btnIseAl.UseVisualStyleBackColor = true;
            this.btnIseAl.Click += new System.EventHandler(this.btnIseAl_Click);
            // 
            // btnTumKisileriGor
            // 
            this.btnTumKisileriGor.Location = new System.Drawing.Point(22, 109);
            this.btnTumKisileriGor.Name = "btnTumKisileriGor";
            this.btnTumKisileriGor.Size = new System.Drawing.Size(151, 24);
            this.btnTumKisileriGor.TabIndex = 6;
            this.btnTumKisileriGor.Text = "Başvuru Yapan Kişileri Gör";
            this.btnTumKisileriGor.UseVisualStyleBackColor = true;
            this.btnTumKisileriGor.Click += new System.EventHandler(this.btnTumKisileriGor_Click);
            // 
            // btnBasvuruYap
            // 
            this.btnBasvuruYap.Location = new System.Drawing.Point(200, 110);
            this.btnBasvuruYap.Name = "btnBasvuruYap";
            this.btnBasvuruYap.Size = new System.Drawing.Size(163, 23);
            this.btnBasvuruYap.TabIndex = 5;
            this.btnBasvuruYap.Text = "Başvuru Yap";
            this.btnBasvuruYap.UseVisualStyleBackColor = true;
            this.btnBasvuruYap.Click += new System.EventHandler(this.btnBasvuruYap_Click);
            // 
            // listBoxIlanlar
            // 
            this.listBoxIlanlar.FormattingEnabled = true;
            this.listBoxIlanlar.Location = new System.Drawing.Point(22, 17);
            this.listBoxIlanlar.Name = "listBoxIlanlar";
            this.listBoxIlanlar.Size = new System.Drawing.Size(341, 82);
            this.listBoxIlanlar.TabIndex = 4;
            // 
            // frmDetaylar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 188);
            this.Controls.Add(this.btnIseAl);
            this.Controls.Add(this.btnTumKisileriGor);
            this.Controls.Add(this.btnBasvuruYap);
            this.Controls.Add(this.listBoxIlanlar);
            this.Name = "frmDetaylar";
            this.Text = "ILAN DETAYLARI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIseAl;
        private System.Windows.Forms.Button btnTumKisileriGor;
        private System.Windows.Forms.Button btnBasvuruYap;
        public System.Windows.Forms.ListBox listBoxIlanlar;
    }
}