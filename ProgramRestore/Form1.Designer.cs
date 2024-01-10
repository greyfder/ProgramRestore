namespace ProgramRestore
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
            this.tDosya = new System.Windows.Forms.TextBox();
            this.bSec = new System.Windows.Forms.Button();
            this.bYukle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tDosya
            // 
            this.tDosya.Location = new System.Drawing.Point(13, 38);
            this.tDosya.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tDosya.Name = "tDosya";
            this.tDosya.Size = new System.Drawing.Size(443, 29);
            this.tDosya.TabIndex = 0;
            // 
            // bSec
            // 
            this.bSec.Location = new System.Drawing.Point(508, 33);
            this.bSec.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bSec.Name = "bSec";
            this.bSec.Size = new System.Drawing.Size(137, 34);
            this.bSec.TabIndex = 1;
            this.bSec.Text = "Yedek Seç";
            this.bSec.UseVisualStyleBackColor = true;
            this.bSec.Click += new System.EventHandler(this.bSec_Click);
            // 
            // bYukle
            // 
            this.bYukle.Location = new System.Drawing.Point(508, 75);
            this.bYukle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bYukle.Name = "bYukle";
            this.bYukle.Size = new System.Drawing.Size(137, 82);
            this.bYukle.TabIndex = 2;
            this.bYukle.Text = "YÜKLE";
            this.bYukle.UseVisualStyleBackColor = true;
            this.bYukle.Click += new System.EventHandler(this.bYukle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(3, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(481, 75);
            this.label1.TabIndex = 3;
            this.label1.Text = "! ! ! \r\nBu işlemi yaptıktan sonra mevcut verileriniz silinecektir.\r\nYedeklediğini" +
    "z tarihteki veriler kullanılacaktır.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.26957F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(384, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "En Son Aldığınız Yedekleme Dosyasını Seçiniz.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 166);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bYukle);
            this.Controls.Add(this.bSec);
            this.Controls.Add(this.tDosya);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(684, 211);
            this.MinimumSize = new System.Drawing.Size(684, 211);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barkolu Satış Programı Yedekten Yükleme<Sahin>";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tDosya;
        private System.Windows.Forms.Button bSec;
        private System.Windows.Forms.Button bYukle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

