using System;
using System.Collections.Generic;
using System.Text;

namespace MyNote_rev
{
    public class KategoriObj
    {
        public int idKategori;
        public string namaKategori;
        public string keteranganKategori;
        public DateTime lastUpdate;

        public KategoriObj(int id, string nama, string keterangan, DateTime updateTime)
        {
            this.idKategori = id;
            this.namaKategori = nama;
            this.keteranganKategori = keterangan;
            this.lastUpdate = updateTime;
        }
    }
}
