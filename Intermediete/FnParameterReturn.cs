using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediete
{
    internal class FnParameterReturn
    {
        // Function atau Method dengan Paramter dan Return 
        static int Tambah(int a, int b) // Return int
        {
            int hasil = a + b;
            return hasil; // Mengembalikan hasil penjumlahan
        }

        //public static void Main()
        //{
        //    int hasilPenjumlahan = Tambah(5, 7); // Memanggil method dengan return value
        //    Console.WriteLine($"Hasil Penjumlahan 5 + 7 = {hasilPenjumlahan}");
        //}
    }
}
