using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PemrogramanMinggu13
{
    class program
    {
        static void Main(string[] args)
        {
            // membuat objek mhs1
            Mahasiswa mhs1 = new Mahasiswa();
            mhs1.Nim = "1234";
            mhs1.NamaMahasiswa = "Erik";

            // membuat objek mhs2
            Mahasiswa mhs2 = new Mahasiswa();
            mhs2.Nim = "1235";
            mhs2.NamaMahasiswa = "Wely";

            // membuat objek dosen
            Dosen dosen = new Dosen();
            dosen.Nik = "4874";
            dosen.NamaDosen = "Cornelia";

            // membuat objek list
            List<Mahasiswa> list = new List<Mahasiswa>();

            // menambahkan elemen list
            list.Add(mhs1);
            list.Add(mhs2);

            // mengakses elemen list
            // mahasiswa mhs = list[1];

            Console.WriteLine("Nim    Nama");
            Console.WriteLine("=============");

            foreach (Mahasiswa mhs in list)
            {
                Console.WriteLine("{0},  {1}", mhs.Nim, mhs.NamaMahasiswa);
            }

            Console.ReadKey();
        }
    }
}
            