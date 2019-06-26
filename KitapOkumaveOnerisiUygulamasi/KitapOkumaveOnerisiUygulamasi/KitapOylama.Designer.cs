namespace KitapOkumaveOnerisiUygulamasi
{
    partial class KitapOylama
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
            this.grdKitapOyla = new System.Windows.Forms.DataGridView();
            this.lblOyla = new System.Windows.Forms.Label();
            this.btnoylama = new System.Windows.Forms.Button();
            this.btnSol = new System.Windows.Forms.Button();
            this.btnSag = new System.Windows.Forms.Button();
            this.btnSayfaNumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdKitapOyla)).BeginInit();
            this.SuspendLayout();
            // 
            // grdKitapOyla
            // 
            this.grdKitapOyla.AllowUserToOrderColumns = true;
            this.grdKitapOyla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdKitapOyla.Location = new System.Drawing.Point(32, 47);
            this.grdKitapOyla.Name = "grdKitapOyla";
            this.grdKitapOyla.Size = new System.Drawing.Size(353, 323);
            this.grdKitapOyla.TabIndex = 0;
            this.grdKitapOyla.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdKitapOyla_CellEndEdit);
            // 
            // lblOyla
            // 
            this.lblOyla.AutoSize = true;
            this.lblOyla.Location = new System.Drawing.Point(29, 31);
            this.lblOyla.Name = "lblOyla";
            this.lblOyla.Size = new System.Drawing.Size(120, 13);
            this.lblOyla.TabIndex = 1;
            this.lblOyla.Text = "En az 10 Kitap Oylayınız";
            // 
            // btnoylama
            // 
            this.btnoylama.Location = new System.Drawing.Point(310, 375);
            this.btnoylama.Name = "btnoylama";
            this.btnoylama.Size = new System.Drawing.Size(75, 23);
            this.btnoylama.TabIndex = 2;
            this.btnoylama.Text = "Oyla ";
            this.btnoylama.UseVisualStyleBackColor = true;
            this.btnoylama.Click += new System.EventHandler(this.btnoylama_Click);
            // 
            // btnSol
            // 
            this.btnSol.Location = new System.Drawing.Point(32, 376);
            this.btnSol.Name = "btnSol";
            this.btnSol.Size = new System.Drawing.Size(75, 23);
            this.btnSol.TabIndex = 3;
            this.btnSol.Text = "<";
            this.btnSol.UseVisualStyleBackColor = true;
            this.btnSol.Click += new System.EventHandler(this.btnSol_Click);
            // 
            // btnSag
            // 
            this.btnSag.Location = new System.Drawing.Point(164, 375);
            this.btnSag.Name = "btnSag";
            this.btnSag.Size = new System.Drawing.Size(75, 23);
            this.btnSag.TabIndex = 4;
            this.btnSag.Text = ">";
            this.btnSag.UseVisualStyleBackColor = true;
            this.btnSag.Click += new System.EventHandler(this.btnSag_Click);
            // 
            // btnSayfaNumber
            // 
            this.btnSayfaNumber.AutoSize = true;
            this.btnSayfaNumber.Location = new System.Drawing.Point(113, 380);
            this.btnSayfaNumber.Name = "btnSayfaNumber";
            this.btnSayfaNumber.Size = new System.Drawing.Size(35, 13);
            this.btnSayfaNumber.TabIndex = 5;
            this.btnSayfaNumber.Text = "label1";
            // 
            // KitapOylama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 444);
            this.Controls.Add(this.btnSayfaNumber);
            this.Controls.Add(this.btnSag);
            this.Controls.Add(this.btnSol);
            this.Controls.Add(this.btnoylama);
            this.Controls.Add(this.lblOyla);
            this.Controls.Add(this.grdKitapOyla);
            this.Name = "KitapOylama";
            this.Text = "KitapOylama";
            ((System.ComponentModel.ISupportInitialize)(this.grdKitapOyla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdKitapOyla;
        private System.Windows.Forms.Label lblOyla;
        private System.Windows.Forms.Button btnoylama;
        private System.Windows.Forms.Button btnSol;
        private System.Windows.Forms.Button btnSag;
        private System.Windows.Forms.Label btnSayfaNumber;
    }
}