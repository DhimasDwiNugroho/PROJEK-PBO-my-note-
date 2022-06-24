namespace MyNote_rev
{
    partial class form_Note
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_Header = new System.Windows.Forms.Panel();
            this.btn_kategori = new System.Windows.Forms.Button();
            this.btn_tambah = new System.Windows.Forms.Button();
            this.lb_Header = new System.Windows.Forms.Label();
            this.flp_ItemListHolder = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_NoNotes = new System.Windows.Forms.Label();
            this.panel_Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Header
            // 
            this.panel_Header.BackColor = System.Drawing.Color.Black;
            this.panel_Header.Controls.Add(this.btn_kategori);
            this.panel_Header.Controls.Add(this.btn_tambah);
            this.panel_Header.Controls.Add(this.lb_Header);
            this.panel_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Header.Location = new System.Drawing.Point(0, 0);
            this.panel_Header.Name = "panel_Header";
            this.panel_Header.Size = new System.Drawing.Size(409, 75);
            this.panel_Header.TabIndex = 1;
            // 
            // btn_kategori
            // 
            this.btn_kategori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kategori.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_kategori.ForeColor = System.Drawing.Color.White;
            this.btn_kategori.Location = new System.Drawing.Point(221, 21);
            this.btn_kategori.Name = "btn_kategori";
            this.btn_kategori.Size = new System.Drawing.Size(85, 35);
            this.btn_kategori.TabIndex = 14;
            this.btn_kategori.Text = "Kategori";
            this.btn_kategori.UseVisualStyleBackColor = true;
            this.btn_kategori.Click += new System.EventHandler(this.btn_kategori_Click);
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
            this.lb_Header.Size = new System.Drawing.Size(169, 44);
            this.lb_Header.TabIndex = 0;
            this.lb_Header.Text = "MyNotes";
            // 
            // flp_ItemListHolder
            // 
            this.flp_ItemListHolder.AutoScroll = true;
            this.flp_ItemListHolder.BackColor = System.Drawing.Color.Black;
            this.flp_ItemListHolder.Dock = System.Windows.Forms.DockStyle.Top;
            this.flp_ItemListHolder.Location = new System.Drawing.Point(0, 75);
            this.flp_ItemListHolder.Name = "flp_ItemListHolder";
            this.flp_ItemListHolder.Size = new System.Drawing.Size(409, 451);
            this.flp_ItemListHolder.TabIndex = 2;
            // 
            // lbl_NoNotes
            // 
            this.lbl_NoNotes.AutoSize = true;
            this.lbl_NoNotes.Font = new System.Drawing.Font("Roboto Medium", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_NoNotes.ForeColor = System.Drawing.Color.White;
            this.lbl_NoNotes.Location = new System.Drawing.Point(58, 247);
            this.lbl_NoNotes.Name = "lbl_NoNotes";
            this.lbl_NoNotes.Size = new System.Drawing.Size(292, 37);
            this.lbl_NoNotes.TabIndex = 0;
            this.lbl_NoNotes.Text = "Belum Ada Catatan";
            // 
            // form_Note
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(409, 529);
            this.Controls.Add(this.lbl_NoNotes);
            this.Controls.Add(this.flp_ItemListHolder);
            this.Controls.Add(this.panel_Header);
            this.Name = "form_Note";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyNotes";
            this.panel_Header.ResumeLayout(false);
            this.panel_Header.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel_Header;
        private System.Windows.Forms.Label lb_Header;
        private System.Windows.Forms.FlowLayoutPanel flp_ItemListHolder;
        private System.Windows.Forms.Label lbl_NoNotes;
        private System.Windows.Forms.Button btn_tambah;
        private System.Windows.Forms.Button btn_kategori;
    }
}
