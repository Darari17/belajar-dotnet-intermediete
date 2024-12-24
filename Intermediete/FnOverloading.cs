using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediete
{
    internal class FnOverloading
    {
        // Function atau Method Overloading
        static void Cetak()
        {
            Console.WriteLine("Method Tanpa Parameter");
        }

        static void Cetak(string pesan)
        {
            Console.WriteLine($"Pesan: {pesan}");
        }

        static void Cetak(string pesan, int jumlah)
        {
            for (int i = 0; i < jumlah; i++)
            {
                Console.WriteLine($"Pesan ke-{i + 1}: {pesan}");
            }
        }

        //public static void Main()
        //{
        //    Cetak(); // Overloading tanpa parameter
        //    Cetak("Halo Dunia"); // Overloading dengan satu parameter
        //    Cetak("Selamat Belajar C#", 3); // Overloading dengan dua parameter
        //}
    }
}
