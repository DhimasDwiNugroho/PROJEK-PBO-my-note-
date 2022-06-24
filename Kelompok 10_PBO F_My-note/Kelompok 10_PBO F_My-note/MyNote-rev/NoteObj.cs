using System;
using System.Collections.Generic;
using System.Text;

namespace MyNote_rev
{
    public class NoteObj
    {
        public int idNote;
        public string nama;
        public int idKategori;
        public string namaKategori;
        public string isi;
        public DateTime tanggal;

        public NoteObj(int _idNote, string _nama, int _idKategori, string _namaKategori, string _isi, DateTime _tanggal)
        {
            this.idNote = _idNote;
            this.nama = _nama;
            this.idKategori = _idKategori;
            this.namaKategori = _namaKategori;
            this.isi = _isi;
            this.tanggal = _tanggal;
        }
    }
}
