namespace KitapOkumaveOnerisiUygulamasi
{
    partial class Kitaplar
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
            this.tcKitaplar = new System.Windows.Forms.TabControl();
            this.tbpageKitaplar = new System.Windows.Forms.TabPage();
            this.grdKitapListele = new System.Windows.Forms.DataGridView();
            this.tabPageEnyiKitaplar = new System.Windows.Forms.TabPage();
            this.grdEniyiKitaplar = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grdPopülerKitaplar = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.grdYeniKitap = new System.Windows.Forms.DataGridView();
            this.tbonerilenKitap = new System.Windows.Forms.TabPage();
            this.grdOneri = new System.Windows.Forms.DataGridView();
            this.tcKitaplar.SuspendLayout();
            this.tbpageKitaplar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdKitapListele)).BeginInit();
            this.tabPageEnyiKitaplar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEniyiKitaplar)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPopülerKitaplar)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdYeniKitap)).BeginInit();
            this.tbonerilenKitap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOneri)).BeginInit();
            this.SuspendLayout();
            // 
            // tcKitaplar
            // 
            this.tcKitaplar.Controls.Add(this.tbpageKitaplar);
            this.tcKitaplar.Controls.Add(this.tabPageEnyiKitaplar);
            this.tcKitaplar.Controls.Add(this.tabPage1);
            this.tcKitaplar.Controls.Add(this.tabPage2);
            this.tcKitaplar.Controls.Add(this.tbonerilenKitap);
            this.tcKitaplar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcKitaplar.Location = new System.Drawing.Point(0, 0);
            this.tcKitaplar.Name = "tcKitaplar";
            this.tcKitaplar.SelectedIndex = 0;
            this.tcKitaplar.Size = new System.Drawing.Size(480, 449);
            this.tcKitaplar.TabIndex = 0;
            // 
            // tbpageKitaplar
            // 
            this.tbpageKitaplar.Controls.Add(this.grdKitapListele);
            this.tbpageKitaplar.Location = new System.Drawing.Point(4, 22);
            this.tbpageKitaplar.Name = "tbpageKitaplar";
            this.tbpageKitaplar.Padding = new System.Windows.Forms.Padding(3);
            this.tbpageKitaplar.Size = new System.Drawing.Size(472, 423);
            this.tbpageKitaplar.TabIndex = 0;
            this.tbpageKitaplar.Text = "Kitaplar";
            this.tbpageKitaplar.UseVisualStyleBackColor = true;
            // 
            // grdKitapListele
            // 
            this.grdKitapListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdKitapListele.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdKitapListele.Location = new System.Drawing.Point(3, 3);
            this.grdKitapListele.Name = "grdKitapListele";
            this.grdKitapListele.Size = new System.Drawing.Size(466, 417);
            this.grdKitapListele.TabIndex = 0;
            this.grdKitapListele.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdKitapListele_CellContentClick);
            // 
            // tabPageEnyiKitaplar
            // 
            this.tabPageEnyiKitaplar.Controls.Add(this.grdEniyiKitaplar);
            this.tabPageEnyiKitaplar.Location = new System.Drawing.Point(4, 22);
            this.tabPageEnyiKitaplar.Name = "tabPageEnyiKitaplar";
            this.tabPageEnyiKitaplar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEnyiKitaplar.Size = new System.Drawing.Size(472, 423);
            this.tabPageEnyiKitaplar.TabIndex = 1;
            this.tabPageEnyiKitaplar.Text = "En İyi Kitaplar";
            this.tabPageEnyiKitaplar.UseVisualStyleBackColor = true;
            // 
            // grdEniyiKitaplar
            // 
            this.grdEniyiKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEniyiKitaplar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdEniyiKitaplar.Location = new System.Drawing.Point(3, 3);
            this.grdEniyiKitaplar.Name = "grdEniyiKitaplar";
            this.grdEniyiKitaplar.Size = new System.Drawing.Size(466, 417);
            this.grdEniyiKitaplar.TabIndex = 0;
            this.grdEniyiKitaplar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdEniyiKitaplar_CellContentClick);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grdPopülerKitaplar);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(472, 423);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "En Popüler Kitaplar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // grdPopülerKitaplar
            // 
            this.grdPopülerKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPopülerKitaplar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdPopülerKitaplar.Location = new System.Drawing.Point(3, 3);
            this.grdPopülerKitaplar.Name = "grdPopülerKitaplar";
            this.grdPopülerKitaplar.Size = new System.Drawing.Size(466, 417);
            this.grdPopülerKitaplar.TabIndex = 0;
            this.grdPopülerKitaplar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPopülerKitaplar_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.grdYeniKitap);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(472, 423);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Yeni Kitaplar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // grdYeniKitap
            // 
            this.grdYeniKitap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdYeniKitap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdYeniKitap.Location = new System.Drawing.Point(3, 3);
            this.grdYeniKitap.Name = "grdYeniKitap";
            this.grdYeniKitap.Size = new System.Drawing.Size(466, 417);
            this.grdYeniKitap.TabIndex = 0;
            this.grdYeniKitap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdYeniKitap_CellContentClick);
            // 
            // tbonerilenKitap
            // 
            this.tbonerilenKitap.Controls.Add(this.grdOneri);
            this.tbonerilenKitap.Location = new System.Drawing.Point(4, 22);
            this.tbonerilenKitap.Name = "tbonerilenKitap";
            this.tbonerilenKitap.Padding = new System.Windows.Forms.Padding(3);
            this.tbonerilenKitap.Size = new System.Drawing.Size(472, 423);
            this.tbonerilenKitap.TabIndex = 4;
            this.tbonerilenKitap.Text = "Önerilen Kitaplar";
            this.tbonerilenKitap.UseVisualStyleBackColor = true;
            // 
            // grdOneri
            // 
            this.grdOneri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOneri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdOneri.Location = new System.Drawing.Point(3, 3);
            this.grdOneri.Name = "grdOneri";
            this.grdOneri.Size = new System.Drawing.Size(466, 417);
            this.grdOneri.TabIndex = 0;
            this.grdOneri.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdOneri_CellContentClick);
            // 
            // Kitaplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 449);
            this.Controls.Add(this.tcKitaplar);
            this.Name = "Kitaplar";
            this.Text = "Kitaplar";
            this.tcKitaplar.ResumeLayout(false);
            this.tbpageKitaplar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdKitapListele)).EndInit();
            this.tabPageEnyiKitaplar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdEniyiKitaplar)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdPopülerKitaplar)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdYeniKitap)).EndInit();
            this.tbonerilenKitap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdOneri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcKitaplar;
        private System.Windows.Forms.TabPage tbpageKitaplar;
        private System.Windows.Forms.TabPage tabPageEnyiKitaplar;
        private System.Windows.Forms.DataGridView grdKitapListele;
        private System.Windows.Forms.DataGridView grdEniyiKitaplar;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView grdPopülerKitaplar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView grdYeniKitap;
        private System.Windows.Forms.TabPage tbonerilenKitap;
        private System.Windows.Forms.DataGridView grdOneri;
    }
}