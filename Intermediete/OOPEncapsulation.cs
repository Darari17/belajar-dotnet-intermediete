using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediete
{
    internal class OOPEncapsulation
    {
        // Class
        public class BankAccount
        {
            // Field Private, hanya bisa di akses dalam class
            private decimal balance;

            // Property public untuk membaca saldo, tetapi tidak bisa langsung di ubah
            public decimal Balance
            {
                get { return balance; }
            }

            // Method public untuk menambahkan uang ke akun
            public void Deposit(decimal amount)
            {
                if (amount <= 0)
                {
                    Console.WriteLine("Deposit amount must be greater than zero.");
                    return;
                }
                balance += amount;
                Console.WriteLine($"Deposited: {amount:C}. New balance: {balance:C}");
            }

            // Method public untuk menarik uang dari akun
            public void Withdraw(decimal amount)
            {
                if (amount <= 0)
                {
                    Console.WriteLine("Withdrawal amount must be greater than zero.");
                    return;
                }
                if (amount > balance)
                {
                    Console.WriteLine("Insufficient funds.");
                    return;
                }
                balance -= amount;
                Console.WriteLine($"Withdrew: {amount:C}. Remaining balance: {balance:C}");
            }
        }

        //public static void Main()
        //{
        //    // Membuat objek BankAccount
        //    BankAccount account = new BankAccount();

        //    // Menggunakan method untuk mengatur dan membaca saldo
        //    account.Deposit(1000); // Output: Deposited: $1,000.00. New balance: $1,000.00
        //    account.Withdraw(300); // Output: Withdrew: $300.00. Remaining balance: $700.00
        //    account.Withdraw(800); // Output: Insufficient funds.

        //    // Tidak bisa langsung mengakses balance karena private
        //    // account.balance = 1000; // Error: balance is inaccessible due to its protection level

        //    // Bisa membaca saldo melalui property public
        //    Console.WriteLine($"Final Balance: {account.Balance:C}");
        //}
    }
}

/*
 Penjelasan:

Encapsulation adalah konsep OOP yang bertujuan menyembunyikan detail implementasi internal suatu objek dan hanya mengekspos apa yang di perlukan melalui antarmukan publik (public mehtods atau properties).
Dengan encapsulation, kita dapat melindungi data dari perubahan langsung yang tidak diinginkan dan mengontrol akses ke data tersebut.
Encapsulation dicapai melalui:
    1. Access Modifier: private, protected, internal, dan public untuk menentukan tingkat akses anggota class.
    2. Properties atau Methods: Digunakan untuk mengontrol akses dan modifikasi data dengan validasi jika diperlukan.

Manfaat dari encapsulation:
    1. Keamanan Data: Data sensitif dapat disembunyikan.
    2. Modularitas: Implementasi internal dapat diubah tanpa memengaruhi kode luar.
    3. Kontrol Akses: Memberikan kendali penuh terhadap bagaimana data diakses atau dimodifikasi.
 */