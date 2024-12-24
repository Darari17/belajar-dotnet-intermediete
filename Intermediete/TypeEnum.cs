using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediete
{
    internal class TypeEnum
    {
        enum Level
        {
            Low, Medium, High
        }

        enum Months
        {
            Jan, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec
        }

        //public static void Main()
        //{
        //    int myNumLevel = (int)Level.Medium;
        //    int myNumMonth = (int)Months.Aug;

        //    Console.WriteLine(myNumLevel);
        //    Console.WriteLine(myNumMonth);
        //}
    }
}
/*
PENJELASAN:
Enum adalah class khusus yang mewakili sekelompok konstanta (variable yang tidak dapat diubah / hanya dapat dibaca). Untuk membuat Enum, gunakan enum key (bukan class atau interface), dan pisahkan item enum dengan koma
 */