using System;

namespace Jenis_Casting
{
    class Program
    {
        public static void Implisit()
        {
            int integer = 20;
            long conLong = integer;
            float conFloat = integer;
            double conDouble = integer;

            Console.WriteLine(integer);
            Console.WriteLine(conLong);
            Console.WriteLine(conFloat);
            Console.WriteLine(conDouble);
        }

        public static void Eksplisit()
        {
            double conDouble = 99.88;
            float conFloat = (float)conDouble;
            long conLong = (long)conFloat;
            int conInt = (int)conLong;

            Console.WriteLine(conDouble);
            Console.WriteLine(conFloat);
            Console.WriteLine(conLong);
            Console.WriteLine(conInt);
        }
        static void Jenis_Casting(string[] args)
        {
            Eksplisit();
/*            Catatan
                int dan long adalah bilangan bulat
                float dan double adalah bilangan pecahan*/
        }
    }
}
