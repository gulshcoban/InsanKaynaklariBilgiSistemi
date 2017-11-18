namespace _142802029_142802011
{
    partial class frmAnasayfa
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
            this.btnPostorder = new System.Windows.Forms.Button();
            this.btnPreorder = new System.Windows.Forms.Button();
            this.btnInorder = new System.Windows.Forms.Button();
            this.btnIsımAra = new System.Windows.Forms.Button();
            this.txtArananIsim = new System.Windows.Forms.TextBox();
            this.lblArananIsim = new System.Windows.Forms.Label();
            this.btnOrtAd = new System.Windows.Forms.Button();
            this.btnIngAd = new System.Windows.Forms.Button();
            this.btnDerinlik = new System.Windows.Forms.Button();
            this.btnKisiSayisi = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblIlanSec = new System.Windows.Forms.Label();
            this.btnIlanVer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPostorder
            // 
            this.btnPostorder.Location = new System.Drawing.Point(746, 232);
            this.btnPostorder.Name = "btnPostorder";
            this.btnPostorder.Size = new System.Drawing.Size(75, 35);
            this.btnPostorder.TabIndex = 31;
            this.btnPostorder.Text = "Postorder";
            this.btnPostorder.UseVisualStyleBackColor = true;
            this.btnPostorder.Click += new System.EventHandler(this.btnPostorder_Click);
            // 
            // btnPreorder
            // 
            this.btnPreorder.Location = new System.Drawing.Point(632, 232);
            this.btnPreorder.Name = "btnPreorder";
            this.btnPreorder.Size = new System.Drawing.Size(75, 35);
            this.btnPreorder.TabIndex = 30;
            this.btnPreorder.Text = "Preorder";
            this.btnPreorder.UseVisualStyleBackColor = true;
            this.btnPreorder.Click += new System.EventHandler(this.btnPreorder_Click);
            // 
            // btnInorder
            // 
            this.btnInorder.Location = new System.Drawing.Point(511, 232);
            this.btnInorder.Name = "btnInorder";
            this.btnInorder.Size = new System.Drawing.Size(75, 35);
            this.btnInorder.TabIndex = 29;
            this.btnInorder.Text = "Inorder";
            this.btnInorder.UseVisualStyleBackColor = true;
            this.btnInorder.Click += new System.EventHandler(this.btnInorder_Click);
            // 
            // btnIsımAra
            // 
            this.btnIsımAra.Location = new System.Drawing.Point(722, 180);
            this.btnIsımAra.Name = "btnIsımAra";
            this.btnIsımAra.Size = new System.Drawing.Size(99, 23);
            this.btnIsımAra.TabIndex = 28;
            this.btnIsımAra.Text = "Kişiyi Gör";
            this.btnIsımAra.UseVisualStyleBackColor = true;
            this.btnIsımAra.Click += new System.EventHandler(this.btnIsımAra_Click);
            // 
            // txtArananIsim
            // 
            this.txtArananIsim.Location = new System.Drawing.Point(622, 182);
            this.txtArananIsim.Name = "txtArananIsim";
            this.txtArananIsim.Size = new System.Drawing.Size(85, 20);
            this.txtArananIsim.TabIndex = 27;
            // 
            // lblArananIsim
            // 
            this.lblArananIsim.AutoSize = true;
            this.lblArananIsim.Location = new System.Drawing.Point(508, 185);
            this.lblArananIsim.Name = "lblArananIsim";
            this.lblArananIsim.Size = new System.Drawing.Size(96, 13);
            this.lblArananIsim.TabIndex = 26;
            this.lblArananIsim.Text = "Aranan kişinin ismi:";
            // 
            // btnOrtAd
            // 
            this.btnOrtAd.Location = new System.Drawing.Point(511, 142);
            this.btnOrtAd.Name = "btnOrtAd";
            this.btnOrtAd.Size = new System.Drawing.Size(310, 23);
            this.btnOrtAd.TabIndex = 25;
            this.btnOrtAd.Text = "Gereken Ortalamalara Göre Kişilerin Adları ";
            this.btnOrtAd.UseVisualStyleBackColor = true;
            this.btnOrtAd.Click += new System.EventHandler(this.btnOrtAd_Click);
            // 
            // btnIngAd
            // 
            this.btnIngAd.Location = new System.Drawing.Point(511, 113);
            this.btnIngAd.Name = "btnIngAd";
            this.btnIngAd.Size = new System.Drawing.Size(310, 23);
            this.btnIngAd.TabIndex = 24;
            this.btnIngAd.Text = "İngilizce Bilen Kişilerin Adları";
            this.btnIngAd.UseVisualStyleBackColor = true;
            this.btnIngAd.Click += new System.EventHandler(this.btnIngAd_Click);
            // 
            // btnDerinlik
            // 
            this.btnDerinlik.Location = new System.Drawing.Point(511, 84);
            this.btnDerinlik.Name = "btnDerinlik";
            this.btnDerinlik.Size = new System.Drawing.Size(310, 23);
            this.btnDerinlik.TabIndex = 23;
            this.btnDerinlik.Text = "Ağacın Derinliğini Gör";
            this.btnDerinlik.UseVisualStyleBackColor = true;
            this.btnDerinlik.Click += new System.EventHandler(this.btnDerinlik_Click);
            // 
            // btnKisiSayisi
            // 
            this.btnKisiSayisi.Location = new System.Drawing.Point(511, 53);
            this.btnKisiSayisi.Name = "btnKisiSayisi";
            this.btnKisiSayisi.Size = new System.Drawing.Size(310, 26);
            this.btnKisiSayisi.TabIndex = 22;
            this.btnKisiSayisi.Text = "Toplam Kişi Sayısını Gör";
            this.btnKisiSayisi.UseVisualStyleBackColor = true;
            this.btnKisiSayisi.Click += new System.EventHandler(this.btnKisiSayisi_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(30, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(459, 150);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "İlan No";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Şirket Adı";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "İçerik";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Detayları Gör";
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // lblIlanSec
            // 
            this.lblIlanSec.AutoSize = true;
            this.lblIlanSec.Location = new System.Drawing.Point(27, 25);
            this.lblIlanSec.Name = "lblIlanSec";
            this.lblIlanSec.Size = new System.Drawing.Size(229, 13);
            this.lblIlanSec.TabIndex = 20;
            this.lblIlanSec.Text = "Lütfen Başvuru Yapmak İstediğiniz İlanı Seçiniz";
            // 
            // btnIlanVer
            // 
            this.btnIlanVer.Location = new System.Drawing.Point(30, 218);
            this.btnIlanVer.Name = "btnIlanVer";
            this.btnIlanVer.Size = new System.Drawing.Size(459, 63);
            this.btnIlanVer.TabIndex = 19;
            this.btnIlanVer.Text = "İLAN VER";
            this.btnIlanVer.UseVisualStyleBackColor = true;
            this.btnIlanVer.Click += new System.EventHandler(this.btnIlanVer_Click);
            // 
            // frmAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 295);
            this.Controls.Add(this.btnPostorder);
            this.Controls.Add(this.btnPreorder);
            this.Controls.Add(this.btnInorder);
            this.Controls.Add(this.btnIsımAra);
            this.Controls.Add(this.txtArananIsim);
            this.Controls.Add(this.lblArananIsim);
            this.Controls.Add(this.btnOrtAd);
            this.Controls.Add(this.btnIngAd);
            this.Controls.Add(this.btnDerinlik);
            this.Controls.Add(this.btnKisiSayisi);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblIlanSec);
            this.Controls.Add(this.btnIlanVer);
            this.Name = "frmAnasayfa";
            this.Text = "ANASAYFA";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPostorder;
        private System.Windows.Forms.Button btnPreorder;
        private System.Windows.Forms.Button btnInorder;
        private System.Windows.Forms.Button btnIsımAra;
        private System.Windows.Forms.TextBox txtArananIsim;
        private System.Windows.Forms.Label lblArananIsim;
        private System.Windows.Forms.Button btnOrtAd;
        private System.Windows.Forms.Button btnIngAd;
        private System.Windows.Forms.Button btnDerinlik;
        private System.Windows.Forms.Button btnKisiSayisi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewButtonColumn Column4;
        private System.Windows.Forms.Label lblIlanSec;
        private System.Windows.Forms.Button btnIlanVer;
    }
}

