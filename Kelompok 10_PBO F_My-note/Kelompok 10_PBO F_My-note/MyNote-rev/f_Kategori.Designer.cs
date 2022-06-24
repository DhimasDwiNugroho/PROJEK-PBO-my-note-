namespace MyNote_rev
{
    partial class f_Kategori
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
            this.flp_ItemListHolder = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_Header = new System.Windows.Forms.Panel();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_tambah = new System.Windows.Forms.Button();
            this.lb_Header = new System.Windows.Forms.Label();
            this.lbl_NoKategori = new System.Windows.Forms.Label();
            this.panel_Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // flp_ItemListHolder
            // 
            this.flp_ItemListHolder.AutoScroll = true;
            this.flp_ItemListHolder.BackColor = System.Drawing.Color.Black;
            this.flp_ItemListHolder.Dock = System.Windows.Forms.DockStyle.Top;
            this.flp_ItemListHolder.Location = new System.Drawing.Point(0, 75);
            this.flp_ItemListHolder.Name = "flp_ItemListHolder";
            this.flp_ItemListHolder.Size = new System.Drawing.Size(409, 455);
            this.flp_ItemListHolder.TabIndex = 4;
            // 
            // panel_Header
            // 
            this.panel_Header.BackColor = System.Drawing.Color.Black;
            this.panel_Header.Controls.Add(this.btn_back);
            this.panel_Header.Controls.Add(this.btn_tambah);
            this.panel_Header.Controls.Add(this.lb_Header);
            this.panel_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Header.Location = new System.Drawing.Point(0, 0);
            this.panel_Header.Name = "panel_Header";
            this.panel_Header.Size = new System.Drawing.Size(409, 75);
            this.panel_Header.TabIndex = 3;
            // 
            // btn_back
            // 
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.Location = new System.Drawing.Point(221, 21);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(85, 35);
            this.btn_back.TabIndex = 14;
            this.btn_back.Text = "Kembali";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_tambah
            // 
            this.btn_tambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tambah.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_tambah.ForeColor = System.Drawing.Color.White;
            this.btn_tambah.Location = new System.Drawing.Point(312, 21);
            this.btn_tambah.Name = "btn_tambah";
            this.btn_tambah.Size = new System.Drawing.Size(85, 35);
            this.btn_tambah.TabIndex = 13;
            this.btn_tambah.Text = "Tambah";
            this.btn_tambah.UseVisualStyleBackColor = true;
            this.btn_tambah.Click += new System.EventHandler(this.btn_tambah_Click);
            // 
            // lb_Header
            // 
            this.lb_Header.AutoSize = true;
            this.lb_Header.BackColor = System.Drawing.Color.Black;
            this.lb_Header.Font = new System.Drawing.Font("Roboto", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_Header.ForeColor = System.Drawing.Color.White;
            this.lb_Header.Location = new System.Drawing.Point(11, 17);
            this.lb_Header.Name = "lb_Header";
            this.lb_Header.Size = new System.Drawing.Size(161, 44);
            this.lb_Header.TabIndex = 0;
            this.lb_Header.Text = "Kategori";
            // 
            // lbl_NoKategori
            // 
            this.lbl_NoKategori.AutoSize = true;
            this.lbl_NoKategori.Font = new System.Drawing.Font("Roboto Medium", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_NoKategori.ForeColor = System.Drawing.Color.White;
            this.lbl_NoKategori.Location = new System.Drawing.Point(58, 266);
            this.lbl_NoKategori.Name = "lbl_NoKategori";
            this.lbl_NoKategori.Size = new System.Drawing.Size(302, 37);
            this.lbl_NoKategori.TabIndex = 15;
            this.lbl_NoKategori.Text = "Belum Ada Kategori";
            // 
            // f_Kategori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(409, 529);
            this.Controls.Add(this.lbl_NoKategori);
            this.Controls.Add(this.flp_ItemListHolder);
            this.Controls.Add(this.panel_Header);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "f_Kategori";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MyNotes";
            this.panel_Header.ResumeLayout(false);
            this.panel_Header.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flp_ItemListHolder;
        private System.Windows.Forms.Panel panel_Header;
        private System.Windows.Forms.Button btn_tambah;
        private System.Windows.Forms.Label lb_Header;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lbl_NoKategori;
    }
}