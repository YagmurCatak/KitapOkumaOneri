namespace KitapOkumaveOnerisiUygulamasi
{
    partial class Anasayfa
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
            this.btnOturumac = new System.Windows.Forms.Button();
            this.btnUyeOl = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOturumac
            // 
            this.btnOturumac.Location = new System.Drawing.Point(204, 3);
            this.btnOturumac.Name = "btnOturumac";
            this.btnOturumac.Size = new System.Drawing.Size(75, 23);
            this.btnOturumac.TabIndex = 0;
            this.btnOturumac.Text = "Oturum Aç";
            this.btnOturumac.UseVisualStyleBackColor = true;
            this.btnOturumac.Click += new System.EventHandler(this.btnOturumac_Click);
            // 
            // btnUyeOl
            // 
            this.btnUyeOl.Location = new System.Drawing.Point(287, 3);
            this.btnUyeOl.Name = "btnUyeOl";
            this.btnUyeOl.Size = new System.Drawing.Size(75, 23);
            this.btnUyeOl.TabIndex = 1;
            this.btnUyeOl.Text = "Üye Ol";
            this.btnUyeOl.UseVisualStyleBackColor = true;
            this.btnUyeOl.Click += new System.EventHandler(this.btnUyeOl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(21, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "SINIRSIZ OKUMANIN TADINI ÇIKARTIN ";
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 287);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUyeOl);
            this.Controls.Add(this.btnOturumac);
            this.Name = "Anasayfa";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Anasayfa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOturumac;
        private System.Windows.Forms.Button btnUyeOl;
        private System.Windows.Forms.Label label1;
    }
}

