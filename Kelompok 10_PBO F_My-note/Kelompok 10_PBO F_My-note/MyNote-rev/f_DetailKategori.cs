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
    public partial class f_DetailKategori : Form
    {
        private KategoriObj kategori;
        int chara = 0;
        public f_DetailKategori(KategoriObj obj)
        {
            InitializeComponent();

            if (obj != null)
            {
                kategori = obj;
                tb_nama.Text = obj.namaKategori;
                tb_isi.Text = obj.keteranganKategori;
                chara = obj.keteranganKategori.Length;
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
            if (chara <= 99)
            {
                chara = tb_isi.Text.Length;
                lb_totalChar.Text = chara.ToString();
            }
            else
            {
                string curr = tb_isi.Text;
                tb_isi.Text = curr.Substring(0, 100);
                MessageBox.Show("Batas karakter isi notes adalah 100 karakter");
            }
        }

        private void btn_hapus_Click(object sender, EventArgs e)
        {
            btn_hapus.Enabled = false;
            btn_simpan.Enabled = false;
            int idKategori = kategori.idKategori;
            deleteData(idKategori);
            var mainForm = Application.OpenForms.OfType<f_Kategori>().First();
            mainForm.initData();
            this.Hide();
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            btn_hapus.Enabled = false;
            btn_simpan.Enabled = false;
            int idKategori = kategori.idKategori;
            string nama = tb_nama.Text;
            string keterangan = tb_isi.Text;
            updateData(idKategori, nama, keterangan);
            var mainForm = Application.OpenForms.OfType<f_Kategori>().First();
            mainForm.initData();
            this.Hide();
        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {
            btn_tambah.Enabled = false;
            string nama = tb_nama.Text;
            string keterangan = tb_isi.Text;
            addData(nama, keterangan);
            var mainForm = Application.OpenForms.OfType<f_Kategori>().First();
            mainForm.initData();
            this.Hide();
        }

        private void deleteData(int idKategori)
        {
            try
            {
                // Initialize the database
                var dbInfo = new DBInfo();
                var dbLogin = dbInfo.getArg();
                using var conn = new NpgsqlConnection(dbLogin);

                // Delete the data
                conn.Open();
                var query = "DELETE from kategori where id_kategori = :_id";
                using var cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("_id", idKategori);
                using NpgsqlDataReader rdr = cmd.ExecuteReader();
                conn.Close();

                MessageBox.Show("Kategori berhasil terhapus");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updateData(int idKategori, string nama, string keterangan)
        {
            try
            {
                // Initialize the database
                var dbInfo = new DBInfo();
                var dbLogin = dbInfo.getArg();
                using var conn = new NpgsqlConnection(dbLogin);

                // Update the data
                conn.Open();
                var query = "UPDATE kategori SET nama = :_nama, keterangan = :_keterangan, last_update = CURRENT_TIMESTAMP WHERE id_kategori = :_id";
                using var cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("_id", idKategori);
                cmd.Parameters.AddWithValue("_nama", nama);
                cmd.Parameters.AddWithValue("_keterangan", keterangan);
                using NpgsqlDataReader rdr = cmd.ExecuteReader();
                conn.Close();

                MessageBox.Show("Kategori berhasil diubah");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addData(string nama, string keterangan)
        {
            try
            {
                // Initialize the database
                var dbInfo = new DBInfo();
                var dbLogin = dbInfo.getArg();
                using var conn = new NpgsqlConnection(dbLogin);

                // Update the data
                conn.Open();
                var query = "INSERT INTO kategori (nama, keterangan) " +
                    "VALUES (:_nama, :_keterangan)";
                using var cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("_nama", nama);
                cmd.Parameters.AddWithValue("_keterangan", keterangan);
                using NpgsqlDataReader rdr = cmd.ExecuteReader();
                conn.Close();

                MessageBox.Show("Kategori berhasil ditambahkan");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
