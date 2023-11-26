namespace Şehir_Turu
{
    partial class frmAnaSayfa
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnaSayfa));
            this.btnCami = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAvm = new System.Windows.Forms.Button();
            this.btnMuze = new System.Windows.Forms.Button();
            this.btnTramvay = new System.Windows.Forms.Button();
            this.btnMetro = new System.Windows.Forms.Button();
            this.btnOtobus = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDolmus = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnHakkinda = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUniversite = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCami
            // 
            this.btnCami.Font = new System.Drawing.Font("Dubai Medium", 13.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCami.Location = new System.Drawing.Point(455, 130);
            this.btnCami.Name = "btnCami";
            this.btnCami.Size = new System.Drawing.Size(187, 45);
            this.btnCami.TabIndex = 1;
            this.btnCami.Text = "Camiler";
            this.btnCami.UseVisualStyleBackColor = true;
            this.btnCami.Click += new System.EventHandler(this.btnCami_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(449, 507);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(450, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gezilecek Yerler";
            // 
            // btnAvm
            // 
            this.btnAvm.Font = new System.Drawing.Font("Dubai Medium", 13.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvm.Location = new System.Drawing.Point(455, 232);
            this.btnAvm.Name = "btnAvm";
            this.btnAvm.Size = new System.Drawing.Size(288, 45);
            this.btnAvm.TabIndex = 4;
            this.btnAvm.Text = "Alısveris Merkezleri";
            this.btnAvm.UseVisualStyleBackColor = true;
            // 
            // btnMuze
            // 
            this.btnMuze.Font = new System.Drawing.Font("Dubai Medium", 13.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMuze.Location = new System.Drawing.Point(455, 181);
            this.btnMuze.Name = "btnMuze";
            this.btnMuze.Size = new System.Drawing.Size(187, 45);
            this.btnMuze.TabIndex = 6;
            this.btnMuze.Text = "Müzeler";
            this.btnMuze.UseVisualStyleBackColor = true;
            // 
            // btnTramvay
            // 
            this.btnTramvay.Font = new System.Drawing.Font("Dubai Medium", 13.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTramvay.Location = new System.Drawing.Point(455, 359);
            this.btnTramvay.Name = "btnTramvay";
            this.btnTramvay.Size = new System.Drawing.Size(164, 45);
            this.btnTramvay.TabIndex = 5;
            this.btnTramvay.Text = "Tramvay";
            this.btnTramvay.UseVisualStyleBackColor = true;
            // 
            // btnMetro
            // 
            this.btnMetro.Font = new System.Drawing.Font("Dubai Medium", 13.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMetro.Location = new System.Drawing.Point(455, 308);
            this.btnMetro.Name = "btnMetro";
            this.btnMetro.Size = new System.Drawing.Size(164, 45);
            this.btnMetro.TabIndex = 7;
            this.btnMetro.Text = "Metro";
            this.btnMetro.UseVisualStyleBackColor = true;
            // 
            // btnOtobus
            // 
            this.btnOtobus.Font = new System.Drawing.Font("Dubai Medium", 13.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOtobus.Location = new System.Drawing.Point(455, 410);
            this.btnOtobus.Name = "btnOtobus";
            this.btnOtobus.Size = new System.Drawing.Size(164, 45);
            this.btnOtobus.TabIndex = 8;
            this.btnOtobus.Text = "Otobüs";
            this.btnOtobus.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(455, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ulaşım";
            // 
            // btnDolmus
            // 
            this.btnDolmus.Font = new System.Drawing.Font("Dubai Medium", 13.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDolmus.Location = new System.Drawing.Point(455, 461);
            this.btnDolmus.Name = "btnDolmus";
            this.btnDolmus.Size = new System.Drawing.Size(164, 45);
            this.btnDolmus.TabIndex = 10;
            this.btnDolmus.Text = "Dolmus";
            this.btnDolmus.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(12, 510);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Hakkında";
            // 
            // btnHakkinda
            // 
            this.btnHakkinda.Font = new System.Drawing.Font("Dubai Medium", 13.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHakkinda.Location = new System.Drawing.Point(17, 538);
            this.btnHakkinda.Name = "btnHakkinda";
            this.btnHakkinda.Size = new System.Drawing.Size(187, 45);
            this.btnHakkinda.TabIndex = 12;
            this.btnHakkinda.Text = "Bilgi Al";
            this.btnHakkinda.UseVisualStyleBackColor = true;
            this.btnHakkinda.Click += new System.EventHandler(this.btnHakkinda_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(455, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Egitim";
            // 
            // btnUniversite
            // 
            this.btnUniversite.Font = new System.Drawing.Font("Dubai Medium", 13.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUniversite.Location = new System.Drawing.Point(455, 54);
            this.btnUniversite.Name = "btnUniversite";
            this.btnUniversite.Size = new System.Drawing.Size(187, 45);
            this.btnUniversite.TabIndex = 13;
            this.btnUniversite.Text = "Üniversiteler";
            this.btnUniversite.UseVisualStyleBackColor = true;
            this.btnUniversite.Click += new System.EventHandler(this.btnUniversite_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(451, 538);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 22);
            this.label5.TabIndex = 15;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(451, 572);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 22);
            this.label6.TabIndex = 16;
            this.label6.Text = "label6";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(782, 603);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnUniversite);
            this.Controls.Add(this.btnHakkinda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDolmus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOtobus);
            this.Controls.Add(this.btnMetro);
            this.Controls.Add(this.btnMuze);
            this.Controls.Add(this.btnTramvay);
            this.Controls.Add(this.btnAvm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCami);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAnaSayfa";
            this.Text = "Ana Sayfa";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCami;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAvm;
        private System.Windows.Forms.Button btnMuze;
        private System.Windows.Forms.Button btnTramvay;
        private System.Windows.Forms.Button btnMetro;
        private System.Windows.Forms.Button btnOtobus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDolmus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnHakkinda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUniversite;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
    }
}

