namespace MyNote_rev
{
    partial class f_DetailKategori
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
            this.btn_tambah = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_isi = new System.Windows.Forms.TextBox();
            this.tb_nama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_simpan = new System.Windows.Forms.Button();
            this.btn_hapus = new System.Windows.Forms.Button();
            this.lb_totalChar = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_tambah
            // 
            this.btn_tambah.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_tambah.Location = new System.Drawing.Point(105, 192);
            this.btn_tambah.Name = "btn_tambah";
            this.btn_tambah.Size = new System.Drawing.Size(85, 35);
            this.btn_tambah.TabIndex = 30;
            this.btn_tambah.Text = "Tambah";
            this.btn_tambah.UseVisualStyleBackColor = true;
            this.btn_tambah.Click += new System.EventHandler(this.btn_tambah_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 28;
            this.label2.Text = "Keterangan";
            // 
            // tb_isi
            // 
            this.tb_isi.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_isi.Location = new System.Drawing.Point(14, 83);
            this.tb_isi.Multiline = true;
            this.tb_isi.Name = "tb_isi";
            this.tb_isi.Size = new System.Drawing.Size(177, 85);
            this.tb_isi.TabIndex = 27;
            // 
            // tb_nama
            // 
            this.tb_nama.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_nama.Location = new System.Drawing.Point(14, 30);
            this.tb_nama.Name = "tb_nama";
            this.tb_nama.Size = new System.Drawing.Size(177, 27);
            this.tb_nama.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 24;
            this.label1.Text = "Nama";
            // 
            // btn_simpan
            // 
            this.btn_simpan.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_simpan.Location = new System.Drawing.Point(106, 192);
            this.btn_simpan.Name = "btn_simpan";
            this.btn_simpan.Size = new System.Drawing.Size(85, 35);
            this.btn_simpan.TabIndex = 23;
            this.btn_simpan.Text = "Simpan";
            this.btn_simpan.UseVisualStyleBackColor = true;
            this.btn_simpan.Click += new System.EventHandler(this.btn_simpan_Click);
            // 
            // btn_hapus
            // 
            this.btn_hapus.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_hapus.Location = new System.Drawing.Point(14, 192);
            this.btn_hapus.Name = "btn_hapus";
            this.btn_hapus.Size = new System.Drawing.Size(85, 35);
            this.btn_hapus.TabIndex = 22;
            this.btn_hapus.Text = "Hapus";
            this.btn_hapus.UseVisualStyleBackColor = true;
            this.btn_hapus.Click += new System.EventHandler(this.btn_hapus_Click);
            // 
            // lb_totalChar
            // 
            this.lb_totalChar.AutoSize = true;
            this.lb_totalChar.BackColor = System.Drawing.Color.Black;
            this.lb_totalChar.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_totalChar.ForeColor = System.Drawing.Color.White;
            this.lb_totalChar.Location = new System.Drawing.Point(77, 171);
            this.lb_totalChar.Name = "lb_totalChar";
            this.lb_totalChar.Size = new System.Drawing.Size(28, 15);
            this.lb_totalChar.TabIndex = 21;
            this.lb_totalChar.Text = "100";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(105, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "/ 100 karakter";
            // 
            // f_DetailKategori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(205, 241);
            this.Controls.Add(this.btn_tambah);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_isi);
            this.Controls.Add(this.tb_nama);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_simpan);
            this.Controls.Add(this.btn_hapus);
            this.Controls.Add(this.lb_totalChar);
            this.Controls.Add(this.label4);
            this.Name = "f_DetailKategori";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kategori";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_tambah;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_isi;
        private System.Windows.Forms.TextBox tb_nama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_simpan;
        private System.Windows.Forms.Button btn_hapus;
        private System.Windows.Forms.Label lb_totalChar;
        private System.Windows.Forms.Label label4;
    }
}