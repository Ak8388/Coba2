using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Jenis_Casting
{
    class ArrayNext
    {
        public static void Main(string[] args)
        {
            int[] angka1 = { 5, 2, 7, 9, 10, 21, 3 };
            Console.WriteLine("Mengurutkan Nilai :");
            Array.Sort(angka1);
            foreach(int a in angka1)
            {
                Console.Write($"{a} ");
            }

            Console.WriteLine("\nMembalikan Nilai :");
            Array.Reverse(angka1);
            foreach(int b in angka1)
            {
                Console.Write($"{b} ");
            }

            Console.WriteLine("\nMengubah indeks ke-1 menjadi 0 :");
            Array.Clear(angka1, 1, 6);
            foreach (int c in angka1)
            {
                Console.Write($"{c} ");
            }


            Console.WriteLine("\nMengubah Mengubah Nilai");
            angka1.SetValue(100, 0);
            foreach (int c in angka1)
            {
                Console.Write($"{c} ");
            }


            Console.WriteLine("\nMenggunakan Copy :");
            int[] source = new int[5] { 5,4,3,2,1};
            // Instantiate the target.
            int[] target = new int[2];

            // Copy first 3 elements in source to target.
            Array.Copy(source, 1, target, 0, 2);

            // Display the result.
            foreach (int value in target)
            {
                Console.Write(value + " ");
            }

            Console.WriteLine("\n\nSystem Linq");
            int[] numbers = { 5, 2, 1, 7, 9, 4 };
            foreach(int e in numbers)
            {
                Console.Write($"{e} ");
            }
            Console.WriteLine($"\nMencari Angka Terbesar : {numbers.Max()}");
            Console.WriteLine($"Mencari Angka Terkecil : {numbers.Min()}");
            Console.WriteLine($"Mencari Jumlah Angka : {numbers.Sum()}");
        }
    }
}
