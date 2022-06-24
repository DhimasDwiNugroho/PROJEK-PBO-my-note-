namespace MyNote_rev
{
    partial class ListItemNote
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_Kategori = new System.Windows.Forms.Label();
            this.lb_Nama = new System.Windows.Forms.Label();
            this.lb_Tanggal = new System.Windows.Forms.Label();
            this.lb_Isi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_Kategori
            // 
            this.lb_Kategori.AutoSize = true;
            this.lb_Kategori.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_Kategori.Location = new System.Drawing.Point(8, 5);
            this.lb_Kategori.Name = "lb_Kategori";
            this.lb_Kategori.Size = new System.Drawing.Size(110, 23);
            this.lb_Kategori.TabIndex = 0;
            this.lb_Kategori.Text = "Kategorinya";
            // 
            // lb_Nama
            // 
            this.lb_Nama.AutoSize = true;
            this.lb_Nama.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_Nama.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lb_Nama.Location = new System.Drawing.Point(11, 30);
            this.lb_Nama.Name = "lb_Nama";
            this.lb_Nama.Size = new System.Drawing.Size(61, 14);
            this.lb_Nama.TabIndex = 1;
            this.lb_Nama.Text = "Namanya";
            // 
            // lb_Tanggal
            // 
            this.lb_Tanggal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Tanggal.AutoSize = true;
            this.lb_Tanggal.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_Tanggal.Location = new System.Drawing.Point(266, 13);
            this.lb_Tanggal.Name = "lb_Tanggal";
            this.lb_Tanggal.Size = new System.Drawing.Size(110, 14);
            this.lb_Tanggal.TabIndex = 2;
            this.lb_Tanggal.Text = "xx/xx/xxxx xx:xx:xx";
            this.lb_Tanggal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_Isi
            // 
            this.lb_Isi.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_Isi.Location = new System.Drawing.Point(11, 46);
            this.lb_Isi.MaximumSize = new System.Drawing.Size(375, 65);
            this.lb_Isi.MinimumSize = new System.Drawing.Size(375, 20);
            this.lb_Isi.Name = "lb_Isi";
            this.lb_Isi.Size = new System.Drawing.Size(375, 20);
            this.lb_Isi.TabIndex = 3;
            this.lb_Isi.Text = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";
            // 
            // ListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.lb_Isi);
            this.Controls.Add(this.lb_Tanggal);
            this.Controls.Add(this.lb_Nama);
            this.Controls.Add(this.lb_Kategori);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MaximumSize = new System.Drawing.Size(400, 120);
            this.MinimumSize = new System.Drawing.Size(400, 70);
            this.Name = "ListItem";
            this.Size = new System.Drawing.Size(396, 70);
            this.Click += new System.EventHandler(this.ListItem_Click);
            this.MouseEnter += new System.EventHandler(this.ListItem_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ListItem_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Kategori;
        private System.Windows.Forms.Label lb_Nama;
        private System.Windows.Forms.Label lb_Tanggal;
        private System.Windows.Forms.Label lb_Isi;
    }
}
