﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] pole = new int[10];
           pole[0] = 1;

           for (int i = 0; i < 10; i++)
           {
               pole[i] = i + 1;
           }

           for (int i = 0; i < 10; i++)
           {
               Console.Write(pole[i] + ",");
           }
           Console.WriteLine();


               string[] jmena = { "Tomas", "Dan", "Honza" };
           Array.Sort(jmena); //seradi podle abecedy 
           Array.Reverse(jmena); //seradi zezadu

           foreach(string j in jmena) // se k psani pole
           {
               Console.Write("{0} ", j);
           } 

            Console.Write("Zadejte kolik chcete zapsat znamek: ");
            int pocet = Convert.ToInt32(Console.ReadLine()); // int32 convertuje na int
            int max = 0;
            int min = 1000000000;
            int[] znamky = new int[pocet];      

            for(int i = 0; i < pocet; i++)
            {
                Console.Write("zadejte " + (i + 1) + ". cislo");
                znamky[i] = Convert.ToInt32(Console.ReadLine());

                if (max < znamky[i])
                {
                    max = znamky[i];
                }

                if (min > znamky[i])
                {
                    min = znamky[i];
                }
            }
            Console.WriteLine("Prumer znamek je: {0}", znamky.Average()); //average je prumer
            Console.WriteLine("Nejvet3i cislo je: " + max);
            Console.WriteLine("Nejmensi cislo je: " + min);
            Console.WriteLine("Soucet vsech cisel je: {0}", znamky.Sum()); // Sum je soucet vsech cisel
            Console.WriteLine("Prvni cislo je: " + znamky.First());
            Console.WriteLine("Posledni cislo je: " + znamky.Last());

            Console.ReadLine();
        }
    }
}
