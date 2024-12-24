using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediete
{
    internal class OOPAbstraction
    {
        // Menggunakan Abstract Class
        abstract class Payment
        {
            public abstract void Pay(); // Metode abstrak (tanpa implementasi)
        }

        class CreditCardPayment : Payment
        {
            public override void Pay()
            {
                Console.WriteLine("Payment made using Credit Card.");
            }
        }

        class PayPalPayment : Payment
        {
            public override void Pay()
            {
                Console.WriteLine("Payment made using PayPal.");
            }
        }

        //========================================================================================

        // Menggunakan Interface
        interface IPayment
        {
            void Pay(); // Metode tanpa implementasi
        }

        class CreditCardPayment2 : IPayment
        {
            public void Pay()
            {
                Console.WriteLine("Payment made using Credit Card.");
            }
        }

        class PayPalPayment2 : IPayment
        {
            public void Pay()
            {
                Console.WriteLine("Payment made using PayPal.");
            }
        }

        //========================================================================================

        //public static void Main()
        //{
        //    Console.WriteLine("Abstract Class:");
        //    Payment payment;

        //    // Menggunakan CreditCardPayment
        //    payment = new CreditCardPayment();
        //    payment.Pay();

        //    // Menggunakan PayPalPayment
        //    payment = new PayPalPayment();
        //    payment.Pay();

        //    Console.WriteLine();

        //    Console.WriteLine("Abtract Interface:");
        //    IPayment payment2;

        //    // Menggunakan CreditCardPayment
        //    payment2 = new CreditCardPayment2();
        //    payment2.Pay();

        //    // Menggunakan PayPalPayment
        //    payment2 = new PayPalPayment2();
        //    payment.Pay();

        //}
    }
}

/*
 OOP Abstraction adalah salah satu prinsip utama dalam pemrograman berorientasi objek (OOP). Abstraction bertujuan untuk menyembunyikan detail implementasi kompleks dan hanya menampilkan fitur penting atau esensial kepada pengguna. Dengan abstraction, kita fokus pada "apa yang dilakukan" sebuah objek daripada "bagaimana caranya" objek tersebut melakukannya.

 Keuntungan Abstraction:
    1. Mengurangi kompleksitas: Pengguna tidak perlu mengetahui detail implementasi.
    2. Meningkatkan fleksibilitas: Implementasi dapat berubah tanpa memengaruhi kode yang menggunakan abstraksi.
    3. Mempermudah pengembangan: Fokus pada desain dan fungsionalitas utama.

 Cara Menerapkan Abstraction di C#
    1. Abstract Class: Kelas yang mendefinisikan kerangka kerja dengan metode abstrak (tanpa implementasi) dan metode konkret (dengan implementasi).
    2. Interface: Hanya mendefinisikan kontrak tanpa implementasi sama sekali.

 */
