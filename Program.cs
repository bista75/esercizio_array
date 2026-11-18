using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercizio_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[100];
            Random rand = new Random();
            int somma=0, min, max;

            for (int i = 0; i<100; i++)
            {
                a[i] = rand.Next(1, 101); 
            }

            min = a[0];
            max = a[0];
            somma = a[0];

            for (int i = 1; i < 100; i++)
            {
                somma += a[i];

                if (a[i] > max)
                {
                    max = a[i];
                }
                if (a[i] < min)
                {
                    min = a[i];
                }
            }

            double media = (double)somma / a.Length;

            Console.WriteLine("La somma è " + somma);
            Console.WriteLine("Il max è " + max);
            Console.WriteLine("il minimo è " + min);
            Console.WriteLine("La media è " + media);

        }

    }
}
