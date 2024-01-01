namespace GeriSayim
{
    partial class Form1
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
            this.saat = new System.Windows.Forms.TextBox();
            this.yenidenbasla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.iptal = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.kapa = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.saniye = new System.Windows.Forms.TextBox();
            this.dakika = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // saat
            // 
            this.saat.AccessibleDescription = "";
            this.saat.AccessibleName = "";
            this.saat.Location = new System.Drawing.Point(17, 53);
            this.saat.Name = "saat";
            this.saat.Size = new System.Drawing.Size(122, 20);
            this.saat.TabIndex = 12;
            this.saat.TabStop = false;
            this.saat.Tag = "";
            this.saat.Text = "1";
            // 
            // yenidenbasla
            // 
            this.yenidenbasla.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.yenidenbasla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yenidenbasla.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.yenidenbasla.Location = new System.Drawing.Point(17, 217);
            this.yenidenbasla.Name = "yenidenbasla";
            this.yenidenbasla.Size = new System.Drawing.Size(191, 32);
            this.yenidenbasla.TabIndex = 19;
            this.yenidenbasla.Text = "Süre Sonra YENİDEN BAŞLAT";
            this.yenidenbasla.UseVisualStyleBackColor = false;
            this.yenidenbasla.Click += new System.EventHandler(this.yenidenbasla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Bu bilgisayarı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(156, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Dakika";
            // 
            // iptal
            // 
            this.iptal.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.iptal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iptal.Location = new System.Drawing.Point(18, 255);
            this.iptal.Name = "iptal";
            this.iptal.Size = new System.Drawing.Size(190, 32);
            this.iptal.TabIndex = 18;
            this.iptal.Text = "HER ŞEYİ İPTAL ET";
            this.iptal.UseVisualStyleBackColor = false;
            this.iptal.Click += new System.EventHandler(this.iptal_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(156, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Saat";
            // 
            // kapa
            // 
            this.kapa.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.kapa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kapa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.kapa.Location = new System.Drawing.Point(17, 180);
            this.kapa.Name = "kapa";
            this.kapa.Size = new System.Drawing.Size(191, 32);
            this.kapa.TabIndex = 11;
            this.kapa.Text = "Süre Sonra KAPAT";
            this.kapa.UseVisualStyleBackColor = false;
            this.kapa.Click += new System.EventHandler(this.kapa_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(156, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Saniye";
            // 
            // saniye
            // 
            this.saniye.Location = new System.Drawing.Point(17, 131);
            this.saniye.Name = "saniye";
            this.saniye.Size = new System.Drawing.Size(122, 20);
            this.saniye.TabIndex = 17;
            this.saniye.Text = "30";
            // 
            // dakika
            // 
            this.dakika.Location = new System.Drawing.Point(17, 91);
            this.dakika.Name = "dakika";
            this.dakika.Size = new System.Drawing.Size(122, 20);
            this.dakika.TabIndex = 13;
            this.dakika.Text = "1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(225, 298);
            this.Controls.Add(this.saat);
            this.Controls.Add(this.yenidenbasla);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.iptal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kapa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.saniye);
            this.Controls.Add(this.dakika);
            this.Name = "Form1";
            this.Text = "GeriSayim";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox saat;
        private System.Windows.Forms.Button yenidenbasla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button iptal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button kapa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox saniye;
        private System.Windows.Forms.TextBox dakika;
    }
}

