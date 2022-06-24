using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyNote_rev
{
    public partial class f_Kategori : Form
    {
        private List<KategoriObj> listKategori = new List<KategoriObj>();
        public f_Kategori()
        {
            InitializeComponent();
            initData();
        }

        public void initData()
        {
            listKategori.Clear();
            flp_ItemListHolder.Controls.Clear();
            readData();
            if (listKategori.Count > 0)
            {
                lbl_NoKategori.Hide();
                populateList();
            }
            else
            {
                lbl_NoKategori.Show();
                flp_ItemListHolder.Hide();
            }
        }

        private void populateList()
        {
            ListItemKategori[] listItems = new ListItemKategori[listKategori.Count];
            for (int i = 0; i < listItems.Length; i++)
            {
                string isi;
                if (listKategori[i].keteranganKategori.Length > 62)
                {
                    isi = listKategori[i].keteranganKategori.Substring(0, 62) + "...";
                }
                else
                {
                    isi = listKategori[i].keteranganKategori;
                }
                listItems[i] = new ListItemKategori();
                listItems[i]._obj = listKategori[i];
                listItems[i].Kategori = listKategori[i].namaKategori;
                listItems[i].Isi = isi;
                listItems[i].Tanggal = listKategori[i].lastUpdate.ToString();

                flp_ItemListHolder.Controls.Add(listItems[i]);

            }
        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {
            f_DetailKategori detail = new f_DetailKategori(null);
            detail.Show();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_Note note = new form_Note();
            note.Show();
        }

        private void readData()
        {
            // Initialize the database
            var dbInfo = new DBInfo();
            var dbLogin = dbInfo.getArg();
            using var conn = new NpgsqlConnection(dbLogin);

            // Read the data
            conn.Open();
            var query = "SELECT * from kategori";
            using var cmd = new NpgsqlCommand(query, conn);
            using NpgsqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                listKategori.Add(new KategoriObj(rdr.GetInt32(0), rdr.GetString(1), rdr.GetString(2), rdr.GetDateTime(3)));
            }
            conn.Close();
        }
    }
}
