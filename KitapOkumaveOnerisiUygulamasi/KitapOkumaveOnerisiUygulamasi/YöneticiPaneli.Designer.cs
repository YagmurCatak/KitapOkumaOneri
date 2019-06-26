namespace KitapOkumaveOnerisiUygulamasi
{
    partial class YöneticiPaneli
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnOturumAC = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSec = new System.Windows.Forms.Button();
            this.txtResim = new System.Windows.Forms.TextBox();
            this.txtisbn = new System.Windows.Forms.TextBox();
            this.txtYayimci = new System.Windows.Forms.TextBox();
            this.txtYayın = new System.Windows.Forms.TextBox();
            this.txtYazar = new System.Windows.Forms.TextBox();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.grdKitap = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnKullaniciSil = new System.Windows.Forms.Button();
            this.grdKullanici = new System.Windows.Forms.DataGridView();
            this.errorKitap = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdKitap)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdKullanici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorKitap)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(780, 346);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnOturumAC);
            this.tabPage1.Controls.Add(this.btnEkle);
            this.tabPage1.Controls.Add(this.btnSec);
            this.tabPage1.Controls.Add(this.txtResim);
            this.tabPage1.Controls.Add(this.txtisbn);
            this.tabPage1.Controls.Add(this.txtYayimci);
            this.tabPage1.Controls.Add(this.txtYayın);
            this.tabPage1.Controls.Add(this.txtYazar);
            this.tabPage1.Controls.Add(this.txtKitapAdi);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnSil);
            this.tabPage1.Controls.Add(this.grdKitap);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(772, 320);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kitaplar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnOturumAC
            // 
            this.btnOturumAC.Location = new System.Drawing.Point(66, 123);
            this.btnOturumAC.Name = "btnOturumAC";
            this.btnOturumAC.Size = new System.Drawing.Size(130, 23);
            this.btnOturumAC.TabIndex = 16;
            this.btnOturumAC.Text = "Oturum Aç ";
            this.btnOturumAC.UseVisualStyleBackColor = true;
            this.btnOturumAC.Click += new System.EventHandler(this.btnOturumAC_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(602, 123);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 15;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSec
            // 
            this.btnSec.Location = new System.Drawing.Point(264, 93);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(75, 23);
            this.btnSec.TabIndex = 14;
            this.btnSec.Text = "Seç";
            this.btnSec.UseVisualStyleBackColor = true;
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
            // 
            // txtResim
            // 
            this.txtResim.Location = new System.Drawing.Point(141, 95);
            this.txtResim.Name = "txtResim";
            this.txtResim.Size = new System.Drawing.Size(100, 20);
            this.txtResim.TabIndex = 13;
            // 
            // txtisbn
            // 
            this.txtisbn.Location = new System.Drawing.Point(502, 95);
            this.txtisbn.Name = "txtisbn";
            this.txtisbn.Size = new System.Drawing.Size(100, 20);
            this.txtisbn.TabIndex = 12;
            // 
            // txtYayimci
            // 
            this.txtYayimci.Location = new System.Drawing.Point(502, 55);
            this.txtYayimci.Name = "txtYayimci";
            this.txtYayimci.Size = new System.Drawing.Size(100, 20);
            this.txtYayimci.TabIndex = 11;
            // 
            // txtYayın
            // 
            this.txtYayın.Location = new System.Drawing.Point(502, 17);
            this.txtYayın.Name = "txtYayın";
            this.txtYayın.Size = new System.Drawing.Size(100, 20);
            this.txtYayın.TabIndex = 10;
            // 
            // txtYazar
            // 
            this.txtYazar.Location = new System.Drawing.Point(141, 55);
            this.txtYazar.Name = "txtYazar";
            this.txtYazar.Size = new System.Drawing.Size(100, 20);
            this.txtYazar.TabIndex = 9;
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Location = new System.Drawing.Point(141, 17);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(100, 20);
            this.txtKitapAdi.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(441, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Isbn :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Kitap Resmi : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(441, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Yayımcı : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(441, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Yayın : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kitap Yazarı : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kitap Adı : ";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(692, 123);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // grdKitap
            // 
            this.grdKitap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdKitap.Location = new System.Drawing.Point(3, 152);
            this.grdKitap.Name = "grdKitap";
            this.grdKitap.Size = new System.Drawing.Size(764, 166);
            this.grdKitap.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnKullaniciSil);
            this.tabPage2.Controls.Add(this.grdKullanici);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(772, 320);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Kullanıcılar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnKullaniciSil
            // 
            this.btnKullaniciSil.Location = new System.Drawing.Point(241, 268);
            this.btnKullaniciSil.Name = "btnKullaniciSil";
            this.btnKullaniciSil.Size = new System.Drawing.Size(75, 23);
            this.btnKullaniciSil.TabIndex = 1;
            this.btnKullaniciSil.Text = "Sil";
            this.btnKullaniciSil.UseVisualStyleBackColor = true;
            this.btnKullaniciSil.Click += new System.EventHandler(this.btnKullaniciSil_Click);
            // 
            // grdKullanici
            // 
            this.grdKullanici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdKullanici.Location = new System.Drawing.Point(28, 16);
            this.grdKullanici.Name = "grdKullanici";
            this.grdKullanici.Size = new System.Drawing.Size(197, 275);
            this.grdKullanici.TabIndex = 0;
            // 
            // errorKitap
            // 
            this.errorKitap.ContainerControl = this;
            // 
            // YöneticiPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 346);
            this.Controls.Add(this.tabControl1);
            this.Name = "YöneticiPaneli";
            this.Text = "YöneticiPaneli";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdKitap)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdKullanici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorKitap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView grdKitap;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnSec;
        private System.Windows.Forms.TextBox txtResim;
        private System.Windows.Forms.TextBox txtisbn;
        private System.Windows.Forms.TextBox txtYayimci;
        private System.Windows.Forms.TextBox txtYayın;
        private System.Windows.Forms.TextBox txtYazar;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ErrorProvider errorKitap;
        private System.Windows.Forms.DataGridView grdKullanici;
        private System.Windows.Forms.Button btnKullaniciSil;
        private System.Windows.Forms.Button btnOturumAC;
    }
}