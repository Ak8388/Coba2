using System;
using System.Collections.Generic;
using System.Text;

namespace Jenis_Casting
{
    class String
    {
        public static void Stringxx(string[] args)
        {
            string kata = "Putri suka Taro";
            string Kata2 = "Dia juga punya lesung pipi";

            Console.WriteLine(kata.Trim());

            Console.WriteLine(kata.Length);

            Console.WriteLine(kata.ToUpper());

            Console.WriteLine(kata.ToLower());

            string tampKata1 = string.Concat(kata," ",Kata2);
            Console.WriteLine(tampKata1);

            Console.WriteLine(kata.IndexOf("a"));

            Console.WriteLine(kata[1]);

            Console.WriteLine(kata.Contains("a"));

            Console.WriteLine(kata.Insert(15, " Juga Andri"));

            Console.WriteLine(kata.Replace("Putri", "Andri"));

            Console.WriteLine(kata.Substring(0, 5));
        }
    }
}
