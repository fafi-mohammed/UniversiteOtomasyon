namespace UniversiteOtomasyon
{
    partial class NotGirisForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotGirisForm));
            this.btnKayitEkle = new System.Windows.Forms.Button();
            this.cmbOgrenciId = new System.Windows.Forms.ComboBox();
            this.cmbDersId = new System.Windows.Forms.ComboBox();
            this.txtOrtalama = new System.Windows.Forms.TextBox();
            this.txtVize = new System.Windows.Forms.TextBox();
            this.txtFinal = new System.Windows.Forms.TextBox();
            this.btnKayitGuncelle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnKayitEkle
            // 
            this.btnKayitEkle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnKayitEkle.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKayitEkle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnKayitEkle.Location = new System.Drawing.Point(815, 434);
            this.btnKayitEkle.Name = "btnKayitEkle";
            this.btnKayitEkle.Size = new System.Drawing.Size(129, 68);
            this.btnKayitEkle.TabIndex = 0;
            this.btnKayitEkle.Text = "Kayit Ekle";
            this.btnKayitEkle.UseVisualStyleBackColor = false;
            this.btnKayitEkle.Click += new System.EventHandler(this.btnKayitEkle_Click);
            // 
            // cmbOgrenciId
            // 
            this.cmbOgrenciId.FormattingEnabled = true;
            this.cmbOgrenciId.Location = new System.Drawing.Point(799, 261);
            this.cmbOgrenciId.Name = "cmbOgrenciId";
            this.cmbOgrenciId.Size = new System.Drawing.Size(313, 28);
            this.cmbOgrenciId.TabIndex = 1;
            // 
            // cmbDersId
            // 
            this.cmbDersId.FormattingEnabled = true;
            this.cmbDersId.Location = new System.Drawing.Point(799, 357);
            this.cmbDersId.Name = "cmbDersId";
            this.cmbDersId.Size = new System.Drawing.Size(313, 28);
            this.cmbDersId.TabIndex = 2;
            // 
            // txtOrtalama
            // 
            this.txtOrtalama.Location = new System.Drawing.Point(237, 443);
            this.txtOrtalama.Name = "txtOrtalama";
            this.txtOrtalama.Size = new System.Drawing.Size(311, 26);
            this.txtOrtalama.TabIndex = 3;
            // 
            // txtVize
            // 
            this.txtVize.Location = new System.Drawing.Point(237, 265);
            this.txtVize.Name = "txtVize";
            this.txtVize.Size = new System.Drawing.Size(311, 26);
            this.txtVize.TabIndex = 4;
            // 
            // txtFinal
            // 
            this.txtFinal.Location = new System.Drawing.Point(237, 357);
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Size = new System.Drawing.Size(311, 26);
            this.txtFinal.TabIndex = 5;
            // 
            // btnKayitGuncelle
            // 
            this.btnKayitGuncelle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnKayitGuncelle.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKayitGuncelle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnKayitGuncelle.Location = new System.Drawing.Point(966, 434);
            this.btnKayitGuncelle.Name = "btnKayitGuncelle";
            this.btnKayitGuncelle.Size = new System.Drawing.Size(137, 68);
            this.btnKayitGuncelle.TabIndex = 6;
            this.btnKayitGuncelle.Text = "Kayit  Güncelle";
            this.btnKayitGuncelle.UseVisualStyleBackColor = false;
            this.btnKayitGuncelle.Click += new System.EventHandler(this.btnKayitGuncelle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Moccasin;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(322, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 65);
            this.label1.TabIndex = 7;
            this.label1.Text = "Not Giriş Ekranı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(645, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Öğrenci ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(685, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ders ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 394);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(106, 359);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "Final";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.Location = new System.Drawing.Point(97, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 29);
            this.label6.TabIndex = 12;
            this.label6.Text = "Vize Notu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.Location = new System.Drawing.Point(97, 440);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 29);
            this.label7.TabIndex = 13;
            this.label7.Text = "Ortalama";
            // 
            // NotGirisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1192, 621);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKayitGuncelle);
            this.Controls.Add(this.txtFinal);
            this.Controls.Add(this.txtVize);
            this.Controls.Add(this.txtOrtalama);
            this.Controls.Add(this.cmbDersId);
            this.Controls.Add(this.cmbOgrenciId);
            this.Controls.Add(this.btnKayitEkle);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "NotGirisForm";
            this.Text = "KayitForm";
            this.Load += new System.EventHandler(this.NotGirisForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKayitEkle;
        private System.Windows.Forms.ComboBox cmbOgrenciId;
        private System.Windows.Forms.ComboBox cmbDersId;
        private System.Windows.Forms.TextBox txtOrtalama;
        private System.Windows.Forms.TextBox txtVize;
        private System.Windows.Forms.TextBox txtFinal;
        private System.Windows.Forms.Button btnKayitGuncelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}