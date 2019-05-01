using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTS2301
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Nama  : Galih Rizal Muhammad
               Nim   : 18.11.2301
               Kelas : Informatika 07 
            */
            
            Karyawan karyawan1 = new Karyawan("123456", "jojo", 3000000);
            Karyawan karyawan2 = new Karyawan("654123", "Paijo", 2000000);

            Console.WriteLine("NIK\tNama\tGajiBulanan\t");
            Console.WriteLine("\t{0}\t{1}\t{2}\t", karyawan1.NIK, karyawan1.Nama, karyawan1.gajiBulanan);
            Console.WriteLine("\t{0}\t{1}\t{2}\t", karyawan2.NIK, karyawan2.Nama, karyawan2.gajiBulanan);
            Console.ReadKey();

            karyawan1.gajiBulanan = karyawan1.gajiBulanan + (karyawan1.gajiBulanan * 10 / 100);
            karyawan2.gajiBulanan = karyawan2.gajiBulanan + (karyawan2.gajiBulanan * 10 / 100);

            Console.WriteLine("Kenaikan gaji 10 yes");

            Console.WriteLine("\t{0}\t{1}\t{2}\t", karyawan1.NIK, karyawan1.Nama, karyawan1.gajiBulanan);
            Console.WriteLine("\t{0}\t{1}\t{2}\t", karyawan2.NIK, karyawan2.Nama, karyawan2.gajiBulanan);
            Console.ReadKey();
        }
    }
}
