using System;
using System.Collections.Generic;
using System.Text;

namespace Jenis_Casting
{
    class Operator_Matematika
    {
        public static void Operator()
        {
            int angka1 = 10, angka2 = 20;
            Console.WriteLine(Math.Max(angka1, angka2));
            Console.WriteLine(Math.Min(angka1, angka2));
            Console.WriteLine(Math.Sqrt(81));
            Console.WriteLine(Math.Abs(-55.3));
            Console.WriteLine(Math.Round(-55.5));
        }
    }
}
