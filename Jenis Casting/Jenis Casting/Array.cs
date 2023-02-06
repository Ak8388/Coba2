using System;
using System.Collections.Generic;
using System.Text;

namespace Jenis_Casting
{
    class Array222
    {
        public static void Arrayyy(string[] args)
        {
            Console.Write("Masukan Kata :"); string kata = Console.ReadLine();
            char[] tampVokal = new char[kata.Length];
            char[] tampNonVokal = new char[kata.Length];
            int cekVokal = 0,spasi = 0,cekNonVokal=0;
            
            for(int a=0; a<kata.Length; a++)
            {
                if (kata[a] == 'a' || kata[a] == 'A' || kata[a] == 'i' || kata[a] == 'I' || kata[a] == 'u' || kata[a] == 'U' || kata[a] == 'e' || kata[a] == 'E' || kata[a] == 'o' || kata[a] == 'O')
                {
                    tampVokal[cekVokal] = kata[a];
                    cekVokal++;
                }
                else if (kata[a] == ' ')
                {
                    spasi++;
                }
                else
                {
                    tampNonVokal[cekNonVokal] = kata[a];
                    cekNonVokal++;
                }
            }

            string tampVokalNext = new string(tampVokal);
            string tampNonVokalNext = new string(tampNonVokal);

            Console.WriteLine($"Huruf Vokal :{tampVokalNext}");
            Console.WriteLine($"Huruf Non Vokal :{tampNonVokalNext}");
        }
    }
}
