using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediete
{
    internal class OOPInheritance
    {
        // Parent Class (Base Class)
        public class Animal
        {
            public string Name { get; set; }

            public void Eat()
            {
                Console.WriteLine($"{Name} is eating.");
            }
        }

        // Child Class (Derived Class)
        public class Dog : Animal
        {
            public void Bark()
            {
                Console.WriteLine($"{Name} is barking.");
            }
        }

        //public static void Main()
        //{
        //    // Membuat objek dari class Dog
        //    Dog myDog = new Dog();
        //    myDog.Name = "Buddy";  // Properti dari parent class
        //    myDog.Eat();           // Metode dari parent class
        //    myDog.Bark();          // Metode dari child class
        //}
    }
}

/*
Inheritance (pewarisan) adalah salah satu prinsip utama dalam OOP yang memungkina sebuah class (anak/child class) mewarisi properti atau metode dari class lain (induk/parent class).
Tujuannya adalah untuk menghindari pengulana kode, memperluas fungsionalitas, dan membuat hierarki class yang lebih terstruktur.
Dalam Inheritance:
    1. Parent Class (Base Class): Class yang menyediakan properti dan metode yang dapat diwarisi oleh child class.
    2. Child Class (Derived Class): Class yang mewarisi properti dan metode dari parent class, sekaligus dapat menambahkan properti dan metode baru atau mengubah yang sudah ada (overriding).

Keuntungan Inheritance:
    1. Mengurangi duplikasi kode
    2. Mempermudah perawatan kode
    3. Mendukung hierarki logis dalam desain aplikasi.
 */