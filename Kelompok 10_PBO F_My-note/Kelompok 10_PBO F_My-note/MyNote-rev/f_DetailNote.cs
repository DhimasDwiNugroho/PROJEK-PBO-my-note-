using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyNote_rev
{
    public partial class f_DetailNote : Form
    {
        private NoteObj note;
        private List<KategoriObj> listKategori = new List<KategoriObj>();
        private int chara;
        public f_DetailNote(NoteObj obj)
        {
            InitializeComponent();
            readData();

            string[] nama = new string[listKategori.Count];
            for (int i = 0; i < listKategori.Count; i++)
            {
                nama.SetValue(listKategori[i].namaKategori, i);
            }
            cb_kategori.Items.AddRange(nama);

            if (obj != null)
            {
                note = obj;
                tb_nama.Text = obj.nama;
                tb_isi.Text = obj.isi;
                chara = obj.isi.Length;
                var namaKategori = note.namaKategori;
                cb_kategori.SelectedIndex = cb_kategori.FindStringExact(namaKategori);
                btn_hapus.Show();
                btn_simpan.Show();
                btn_tambah.Hide();
            }
            else
            {
                btn_hapus.Hide();
                btn_simpan.Hide();
                btn_tambah.Show();
            }

            lb_totalChar.Text = chara.ToString();
            tb_isi.TextChanged += new EventHandler(isiChanged);
        }

        private void isiChanged(object sender, EventArgs e)
        {
            if (chara <= 199)
            {
                chara = tb_isi.Text.Length;
                lb_totalChar.Text = chara.ToString();
            }
            else
            {
                string curr = tb_isi.Text;
                tb_isi.Text = curr.Substring(0, 200);
                MessageBox.Show("Batas karakter isi notes adalah 200 karakter");
            }
        }

        private void btn_hapus_Click(object sender, EventArgs e)
        {
            btn_hapus.Enabled = false;
            btn_simpan.Enabled = false;
            int idNote = note.idNote;
            deleteData(idNote);
            var mainForm = Application.OpenForms.OfType<form_Note>().First();
            mainForm.initData();
            this.Hide();
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            btn_hapus.Enabled = false;
            btn_simpan.Enabled = false;
            int idNote = note.idNote;
            string nama = tb_nama.Text;
            string isi = tb_isi.Text;
            int selectedKategori = cb_kategori.SelectedIndex;
            int idKategori = listKategori[selectedKategori].idKategori;
            updateData(idNote, nama, idKategori, isi);
            var mainForm = Application.OpenForms.OfType<form_Note>().First();
            mainForm.initData();
            this.Hide();
        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {
            btn_tambah.Enabled = false;
            string nama = tb_nama.Text;
            string isi = tb_isi.Text;
            int selectedKategori = cb_kategori.SelectedIndex;
            int idKategori = listKategori[selectedKategori].idKategori;
            addData(nama, idKategori, isi);
            var mainForm = Application.OpenForms.OfType<form_Note>().First();
            mainForm.initData();
            this.Hide();
        }

        private void readData()
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void deleteData(int idNote)
        {
            try
            {
                // Initialize the database
                var dbInfo = new DBInfo();
                var dbLogin = dbInfo.getArg();
                using var conn = new NpgsqlConnection(dbLogin);

                // Delete the data
                conn.Open();
                var query = "DELETE from note where id_note = :_id";
                using var cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("_id", idNote);
                using NpgsqlDataReader rdr = cmd.ExecuteReader();
                conn.Close();

                MessageBox.Show("Note berhasil terhapus");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updateData(int idNote, string nama, int kategori, string isi)
        {
            try
            {
                // Initialize the database
                var dbInfo = new DBInfo();
                var dbLogin = dbInfo.getArg();
                using var conn = new NpgsqlConnection(dbLogin);

                // Update the data
                conn.Open();
                var query = "UPDATE note SET nama = :_nama, kategori = :_kategori, isi = :_isi, tanggal = CURRENT_TIMESTAMP WHERE id_note = :_id";
                using var cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("_id", idNote);
                cmd.Parameters.AddWithValue("_nama", nama);
                cmd.Parameters.AddWithValue("_kategori", kategori);
                cmd.Parameters.AddWithValue("_isi", isi);
                using NpgsqlDataReader rdr = cmd.ExecuteReader();
                conn.Close();

                MessageBox.Show("Note berhasil diubah");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addData(string nama, int kategori, string isi)
        {
            try
            {
                // Initialize the database
                var dbInfo = new DBInfo();
                var dbLogin = dbInfo.getArg();
                using var conn = new NpgsqlConnection(dbLogin);

                // Update the data
                conn.Open();
                var query = "INSERT INTO note (nama, kategori, isi) " +
                    "VALUES (:_nama, :_kategori, :_isi)";
                using var cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("_nama", nama);
                cmd.Parameters.AddWithValue("_kategori", kategori);
                cmd.Parameters.AddWithValue("_isi", isi);
                using NpgsqlDataReader rdr = cmd.ExecuteReader();
                conn.Close();

                MessageBox.Show("Note berhasil ditambahkan");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
