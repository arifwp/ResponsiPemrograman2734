using System;

namespace ResponsiPemrograman2734
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Karyawan karyawan = new Karyawan(19112734, 5000000, "Arif");
            Karyawan karyawan2 = new Karyawan(19110000, 2000000, "Wahyu");

            Console.WriteLine("No. \t Nik/Nama \t\t Gaji Bulanan ");
            Console.WriteLine("1. \t {0} {1} \t\t {2}", karyawan.Nik, karyawan.Nama, karyawan.GajiBulanan);
            Console.WriteLine("2. \t {0} {1} \t {2}", karyawan2.Nik, karyawan2.Nama, karyawan2.GajiBulanan);

            Console.WriteLine("");

            Console.WriteLine("Asyiiik kenaikan gaji 10%");
            
            Console.WriteLine("");

            Console.WriteLine("No. \t Nik/Nama \t\t Gaji Bulanan ");
            Console.WriteLine("1. \t {0} {1} \t\t {2}", karyawan.Nik, karyawan.Nama, karyawan.GajiTambahan);
            Console.WriteLine("2. \t {0} {1} \t {2}", karyawan2.Nik, karyawan2.Nama, karyawan2.GajiTambahan);
        }
    }

    class Karyawan {
        
        public int Nik { get; set; }
        public int GajiBulanan { get; set; }
        public string Nama { get; set; }
        public int GajiTambahan { get; set; }

        public Karyawan (int Nik, int Gaji, string Nama) {

            this.Nik = Nik;
            this.Nama = Nama;

            if(Gaji < 0) {
                this.GajiBulanan = 0;
            } else {
                this.GajiBulanan = Gaji;
            }

            double y = 0;
            y = 0.1 * GajiBulanan;
            GajiTambahan = Convert.ToInt32(y) + GajiBulanan;

        }

    }




}


