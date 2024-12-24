using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediete
{
    internal class OOPPolymorphism
    {
        // Compile-time Polymorphism (Method Overloading)
        class Calculator
        {
            // Metode overload dengan parameter berbeda
            public int Add(int a, int b)
            {
                return a + b;
            }

            public double Add(double a, double b)
            {
                return a + b;
            }
        }

        // Run-time Polymorphism (Method Overriding)
        class Animal
        {
            public virtual void Speak()
            {
                Console.WriteLine("Animal is speaking...");
            }
        }

        class Dog : Animal
        {
            public override void Speak()
            {
                Console.WriteLine("Dog says: Woof Woof!");
            }
        }

        class Cat : Animal
        {
            public override void Speak()
            {
                Console.WriteLine("Cat says: Meow Meow!");
            }
        }

        //public static void Main()
        //{
        //    Console.WriteLine("Compile-time Polymorphism:");
        //    Calculator calc = new Calculator();

        //    Console.WriteLine(calc.Add(3, 4));      // Output: 7
        //    Console.WriteLine(calc.Add(3.5, 4.2)); // Output: 7.7

        //    Console.WriteLine();

        //    Console.WriteLine("Run-time Polymorphism:");
        //    Animal myAnimal;

        //    myAnimal = new Dog();
        //    myAnimal.Speak(); // Output: Dog says: Woof Woof!

        //    myAnimal = new Cat();
        //    myAnimal.Speak(); // Output: Cat says: Meow Meow!
        //}
    }
}
/*
Polymorphism berasal dari kata Yunani yang berarti "banyak bentuk". Dalam OOP, polymorphism memungkinkan sebuah objek untuk memiliki banyak bentuk tergantung pada konteksnya. Dengan kata lain, polymorphism memungkinkan Anda untuk menggunakan satu antarmuka (interface) untuk berbagai tipe objek yang berbeda.

Jenis - jenis Polymorphism:
    1. Compile-time Polymorphism (Static Polymorphism):
        - Terjadi saat metode atau operator yang sama digunakan dengan cara yang berbeda.
        - Contoh: Method Overloading dan Operator Overloading.

    2. Run-time Polymorphism (Dynamic Polymorphism):
        - Terjadi saat metode yang dipanggil ditentukan pada waktu runtime melalui mekanisme Method Overriding.
        - Melibatkan pewarisan (inheritance) dan penggunaan referensi base class atau interface.
 */


/*
 Penjelasan Kode:

1. Compile-time Polymorphism:
    - Terjadi di saat kompilasi.
    - Metode Add memiliki beberapa versi (overload) dengan parameter berbeda.

2. Run-time Polymorphism:
    - Terjadi di saat program berjalan.
    - Referensi base class Animal memanggil implementasi metode Speak berdasarkan objek aktual (Dog atau Cat).
 */