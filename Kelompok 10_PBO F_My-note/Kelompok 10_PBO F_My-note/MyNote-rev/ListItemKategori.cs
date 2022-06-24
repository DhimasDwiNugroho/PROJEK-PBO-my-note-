using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyNote_rev
{
    public partial class ListItemKategori : UserControl
    {
        public ListItemKategori()
        {
            InitializeComponent();
        }

        #region Properties
        private string _kategori;
        private string _isi;
        private string _tanggal;

        [Category("Custom Props")]
        public string Kategori
        {
            get { return _kategori; }
            set { _kategori = value; lb_Kategori.Text = value; }
        }

        [Category("Custom Props")]
        public string Isi
        {
            get { return _isi; }
            set { _isi = value; lb_Isi.Text = value; }
        }

        [Category("Custom Props")]
        public string Tanggal
        {
            get { return _tanggal; }
            set { _tanggal = value; lb_Tanggal.Text = value; }
        }
        #endregion

        public KategoriObj _obj;
        private void ListItem_Click(object sender, EventArgs e)
        {
            f_DetailKategori detail = new f_DetailKategori(_obj);
            detail.Show();
        }

        private void ListItem_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Silver;
        }

        private void ListItem_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = ListItemKategori.DefaultBackColor;
        }
    }
}
