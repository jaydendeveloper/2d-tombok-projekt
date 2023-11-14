using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iktprojekt2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            void elso()
            {
                Console.WriteLine("kerületek száma:");
                int keruletek = Convert.ToInt32(Console.ReadLine());

                int i = 0;

                int[,] adatok = new int[keruletek, 7];

                while (i <keruletek)
                {
                    Console.WriteLine($"{i+1}.kerület:");

                    int nap = 0;

                    while (nap < 7)
                    {
                        int elszallitott = Convert.ToInt32(Console.ReadLine());

                        adatok[i, nap] = elszallitott;
                        nap++;
                    }

                    i++;
                    
                    for (int x = 0; x < adatok.GetLength(0); x++)
                    {
                        int ossz_elszallitott = 0;
                        for (int j = 0; j < adatok.GetLength(1); j++)
                        {
                            ossz_elszallitott += adatok[x, j];
                        }


                         string elszallitott_output = (ossz_elszallitott > 0) ? $"Az {x + 1}. kerületben {ossz_elszallitott} autót szállítottak el a héten." : $"";

                        string[] napok = { "Hétfő", "Kedd", "Szerda", "Csütörtök", "Péntek", "Szombat", "Vasárnap" };


                        for

                        Console.WriteLine (elszallitott_output);
                    }
                }
            }
            elso();
        }
    }
}
