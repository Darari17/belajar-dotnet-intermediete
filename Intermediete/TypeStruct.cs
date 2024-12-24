using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediete
{
    internal class TypeStruct
    {
        struct Coordinate
        {
            public int x;
            public int y;

            public Coordinate(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        //public static void Main()
        //{
        //    Coordinate p = new Coordinate(10, 20);
        //    Console.WriteLine(p.x);
        //    Console.WriteLine(p.y);
        //}

    }
}

/*
 1. Dalam C#, Struct adalah tipe data type value yang mewakili struktur data. tipe ini dapat berisi konstruktor parameter, konstruktor statis, konstanta, kolom, metode, properti, pengindeks, operator, event, dan nested type.

2. Struct dapat digunakan untuk menyimpan nilai data kecil yang tidak memerlukan pewarisan, misal titik koordinat, pasangan key-value, dan struktur data yang kompleks.
 */