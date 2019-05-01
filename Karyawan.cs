using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTS2301
{
    class Karyawan
    {
        public string NIK { get; set; }
        public string Nama { get; set; }
        public int gajiBulanan { get; set; }

        public Karyawan(string nik, string nama, int gajibulanan)
        {
            NIK = nik;
            Nama = nama;
            gajiBulanan = gajibulanan;

            if (gajiBulanan < 0)
            {
                gajiBulanan = 0;
            }
        }
    }
}
