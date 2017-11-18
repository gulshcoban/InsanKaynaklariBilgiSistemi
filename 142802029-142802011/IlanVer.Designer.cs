namespace _142802029_142802011
{
    partial class frmIlanVer
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
            this.rdbtnGuncelle = new System.Windows.Forms.RadioButton();
            this.btnIlanGuncelle = new System.Windows.Forms.Button();
            this.txtIstenenOzellikler = new System.Windows.Forms.TextBox();
            this.txtIsTanimi = new System.Windows.Forms.TextBox();
            this.lblIstenenOzellikler = new System.Windows.Forms.Label();
            this.lblIstanimi = new System.Windows.Forms.Label();
            this.txtEposta = new System.Windows.Forms.TextBox();
            this.txtFaks = new System.Windows.Forms.TextBox();
            this.lblEposta = new System.Windows.Forms.Label();
            this.lblFaks = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.lblIlanNoGoster = new System.Windows.Forms.Label();
            this.lblIlanNo = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtTamAdres = new System.Windows.Forms.TextBox();
            this.txtIsYeriAdi = new System.Windows.Forms.TextBox();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblTamAdresi = new System.Windows.Forms.Label();
            this.lblIsyeriAdi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rdbtnGuncelle
            // 
            this.rdbtnGuncelle.AutoSize = true;
            this.rdbtnGuncelle.Location = new System.Drawing.Point(172, 289);
            this.rdbtnGuncelle.Name = "rdbtnGuncelle";
            this.rdbtnGuncelle.Size = new System.Drawing.Size(102, 17);
            this.rdbtnGuncelle.TabIndex = 46;
            this.rdbtnGuncelle.TabStop = true;
            this.rdbtnGuncelle.Text = "Bilgileri Güncelle";
            this.rdbtnGuncelle.UseVisualStyleBackColor = true;
            this.rdbtnGuncelle.CheckedChanged += new System.EventHandler(this.rdbtnGuncelle_CheckedChanged);
            // 
            // btnIlanGuncelle
            // 
            this.btnIlanGuncelle.Location = new System.Drawing.Point(172, 312);
            this.btnIlanGuncelle.Name = "btnIlanGuncelle";
            this.btnIlanGuncelle.Size = new System.Drawing.Size(102, 37);
            this.btnIlanGuncelle.TabIndex = 45;
            this.btnIlanGuncelle.Text = "Güncellemeleri Kaydet";
            this.btnIlanGuncelle.UseVisualStyleBackColor = true;
            this.btnIlanGuncelle.Click += new System.EventHandler(this.btnIlanGuncelle_Click);
            // 
            // txtIstenenOzellikler
            // 
            this.txtIstenenOzellikler.Location = new System.Drawing.Point(172, 196);
            this.txtIstenenOzellikler.Name = "txtIstenenOzellikler";
            this.txtIstenenOzellikler.Size = new System.Drawing.Size(100, 20);
            this.txtIstenenOzellikler.TabIndex = 34;
            // 
            // txtIsTanimi
            // 
            this.txtIsTanimi.Location = new System.Drawing.Point(172, 166);
            this.txtIsTanimi.Name = "txtIsTanimi";
            this.txtIsTanimi.Size = new System.Drawing.Size(100, 20);
            this.txtIsTanimi.TabIndex = 33;
            // 
            // lblIstenenOzellikler
            // 
            this.lblIstenenOzellikler.AutoSize = true;
            this.lblIstenenOzellikler.Location = new System.Drawing.Point(44, 203);
            this.lblIstenenOzellikler.Name = "lblIstenenOzellikler";
            this.lblIstenenOzellikler.Size = new System.Drawing.Size(90, 13);
            this.lblIstenenOzellikler.TabIndex = 44;
            this.lblIstenenOzellikler.Text = "İstenen Özellikler:";
            // 
            // lblIstanimi
            // 
            this.lblIstanimi.AutoSize = true;
            this.lblIstanimi.Location = new System.Drawing.Point(44, 176);
            this.lblIstanimi.Name = "lblIstanimi";
            this.lblIstanimi.Size = new System.Drawing.Size(52, 13);
            this.lblIstanimi.TabIndex = 43;
            this.lblIstanimi.Text = "İş Tanımı:";
            // 
            // txtEposta
            // 
            this.txtEposta.Location = new System.Drawing.Point(172, 136);
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Size = new System.Drawing.Size(100, 20);
            this.txtEposta.TabIndex = 32;
            // 
            // txtFaks
            // 
            this.txtFaks.Location = new System.Drawing.Point(172, 104);
            this.txtFaks.Name = "txtFaks";
            this.txtFaks.Size = new System.Drawing.Size(100, 20);
            this.txtFaks.TabIndex = 31;
            // 
            // lblEposta
            // 
            this.lblEposta.AutoSize = true;
            this.lblEposta.Location = new System.Drawing.Point(44, 146);
            this.lblEposta.Name = "lblEposta";
            this.lblEposta.Size = new System.Drawing.Size(47, 13);
            this.lblEposta.TabIndex = 42;
            this.lblEposta.Text = "E-Posta:";
            // 
            // lblFaks
            // 
            this.lblFaks.AutoSize = true;
            this.lblFaks.Location = new System.Drawing.Point(44, 114);
            this.lblFaks.Name = "lblFaks";
            this.lblFaks.Size = new System.Drawing.Size(33, 13);
            this.lblFaks.TabIndex = 41;
            this.lblFaks.Text = "Faks:";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(47, 289);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(108, 60);
            this.btnKaydet.TabIndex = 35;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // lblIlanNoGoster
            // 
            this.lblIlanNoGoster.AutoSize = true;
            this.lblIlanNoGoster.Location = new System.Drawing.Point(119, 239);
            this.lblIlanNoGoster.Name = "lblIlanNoGoster";
            this.lblIlanNoGoster.Size = new System.Drawing.Size(0, 13);
            this.lblIlanNoGoster.TabIndex = 40;
            // 
            // lblIlanNo
            // 
            this.lblIlanNo.AutoSize = true;
            this.lblIlanNo.Location = new System.Drawing.Point(44, 239);
            this.lblIlanNo.Name = "lblIlanNo";
            this.lblIlanNo.Size = new System.Drawing.Size(44, 13);
            this.lblIlanNo.TabIndex = 39;
            this.lblIlanNo.Text = "İlan No:";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(172, 73);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(100, 20);
            this.txtTelefon.TabIndex = 30;
            // 
            // txtTamAdres
            // 
            this.txtTamAdres.Location = new System.Drawing.Point(172, 45);
            this.txtTamAdres.Name = "txtTamAdres";
            this.txtTamAdres.Size = new System.Drawing.Size(100, 20);
            this.txtTamAdres.TabIndex = 29;
            // 
            // txtIsYeriAdi
            // 
            this.txtIsYeriAdi.Location = new System.Drawing.Point(172, 16);
            this.txtIsYeriAdi.Name = "txtIsYeriAdi";
            this.txtIsYeriAdi.Size = new System.Drawing.Size(100, 20);
            this.txtIsYeriAdi.TabIndex = 28;
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(44, 83);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(46, 13);
            this.lblTelefon.TabIndex = 38;
            this.lblTelefon.Text = "Telefon:";
            // 
            // lblTamAdresi
            // 
            this.lblTamAdresi.AutoSize = true;
            this.lblTamAdresi.Location = new System.Drawing.Point(44, 51);
            this.lblTamAdresi.Name = "lblTamAdresi";
            this.lblTamAdresi.Size = new System.Drawing.Size(61, 13);
            this.lblTamAdresi.TabIndex = 37;
            this.lblTamAdresi.Text = "Tam Adres:";
            // 
            // lblIsyeriAdi
            // 
            this.lblIsyeriAdi.AutoSize = true;
            this.lblIsyeriAdi.Location = new System.Drawing.Point(44, 19);
            this.lblIsyeriAdi.Name = "lblIsyeriAdi";
            this.lblIsyeriAdi.Size = new System.Drawing.Size(52, 13);
            this.lblIsyeriAdi.TabIndex = 36;
            this.lblIsyeriAdi.Text = "İşyeri Adı:";
            // 
            // frmIlanVer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 364);
            this.Controls.Add(this.rdbtnGuncelle);
            this.Controls.Add(this.btnIlanGuncelle);
            this.Controls.Add(this.txtIstenenOzellikler);
            this.Controls.Add(this.txtIsTanimi);
            this.Controls.Add(this.lblIstenenOzellikler);
            this.Controls.Add(this.lblIstanimi);
            this.Controls.Add(this.txtEposta);
            this.Controls.Add(this.txtFaks);
            this.Controls.Add(this.lblEposta);
            this.Controls.Add(this.lblFaks);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.lblIlanNoGoster);
            this.Controls.Add(this.lblIlanNo);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtTamAdres);
            this.Controls.Add(this.txtIsYeriAdi);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.lblTamAdresi);
            this.Controls.Add(this.lblIsyeriAdi);
            this.Name = "frmIlanVer";
            this.Text = "ILAN VER";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbtnGuncelle;
        private System.Windows.Forms.Button btnIlanGuncelle;
        public System.Windows.Forms.TextBox txtIstenenOzellikler;
        public System.Windows.Forms.TextBox txtIsTanimi;
        private System.Windows.Forms.Label lblIstenenOzellikler;
        private System.Windows.Forms.Label lblIstanimi;
        public System.Windows.Forms.TextBox txtEposta;
        public System.Windows.Forms.TextBox txtFaks;
        private System.Windows.Forms.Label lblEposta;
        private System.Windows.Forms.Label lblFaks;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label lblIlanNoGoster;
        private System.Windows.Forms.Label lblIlanNo;
        public System.Windows.Forms.TextBox txtTelefon;
        public System.Windows.Forms.TextBox txtTamAdres;
        public System.Windows.Forms.TextBox txtIsYeriAdi;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblTamAdresi;
        private System.Windows.Forms.Label lblIsyeriAdi;
    }
}