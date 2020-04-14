using System;

namespace ResponsiPemrograman2731
{
    class Program 
    {
        static void Main(string[] args)
        {
            
            Karyawan kar1 = new Karyawan(190302123,"Paijo",300000);
            Karyawan kar2 = new Karyawan(190302124, "Jono",200000);

            Console.WriteLine("No \t NIK/Nama \t \t GajiBulanan ");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("1 \t {0} {1} \t  {2}", kar1.NIK, kar1.Nama, kar1.GajiBulanan);
            Console.WriteLine("2 \t {0} {1} \t  {2}", kar2.NIK, kar2.Nama, kar2.GajiBulanan);
            Console.WriteLine();
            Console.WriteLine("Asyikk Kenaikan Gaji 10%1!");
            Console.ReadKey();
        }
    }

}
