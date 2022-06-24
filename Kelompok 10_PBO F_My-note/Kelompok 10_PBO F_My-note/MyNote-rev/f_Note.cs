using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyNote_rev
{
    public partial class form_Note : Form
    {
        private List<NoteObj> notes = new List<NoteObj>();
        public form_Note()
        {
            InitializeComponent();
            initData();
        }

        public void initData()
        {
            notes.Clear();
            flp_ItemListHolder.Controls.Clear();
            readData();
            if (notes.Count > 0)
            {
                lbl_NoNotes.Hide();
                populateList();
            }
            else
            {
                lbl_NoNotes.Show();
                flp_ItemListHolder.Hide();
            }
        }

        private void populateList()
        {
            ListItemNote[] listItems = new ListItemNote[notes.Count];
            for (int i = 0; i < listItems.Length; i++)
            {
                string isi;
                if (notes[i].isi.Length > 62)
                {
                    isi = notes[i].isi.Substring(0, 62) + "...";
                }
                else
                {
                    isi = notes[i].isi;
                }
                listItems[i] = new ListItemNote();
                listItems[i]._obj = notes[i];
                listItems[i].Kategori = notes[i].namaKategori;
                listItems[i].Nama = notes[i].nama;
                listItems[i].Isi = isi;
                listItems[i].Tanggal = notes[i].tanggal.ToString();

                flp_ItemListHolder.Controls.Add(listItems[i]);

            }
        }

        private void readData()
        {
            // Initialize the database
            var dbInfo = new DBInfo();
            var dbLogin = dbInfo.getArg();
            using var conn = new NpgsqlConnection(dbLogin);

            // Read the data
            conn.Open();
            var query = "SELECT * from note as n " +
                "INNER JOIN kategori as kg " +
                "ON n.kategori = kg.id_kategori";
            using var cmd = new NpgsqlCommand(query, conn);
            using NpgsqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                notes.Add(new NoteObj(rdr.GetInt32(0), rdr.GetString(1), rdr.GetInt32(2), rdr.GetString(6), rdr.GetString(3), rdr.GetDateTime(4)));
            }
            conn.Close();
        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {
            f_DetailNote detail = new f_DetailNote(null);
            detail.Show();
        }

        private void btn_kategori_Click(object sender, EventArgs e)
        {
            this.Hide();
            f_Kategori kategori = new f_Kategori();
            kategori.Show();
        }
    }
}
