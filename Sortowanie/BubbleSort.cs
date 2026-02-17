using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortowanie
{
    internal class BubbleSort
    {
        static void Sort(int[] tablica)
        {
            int temporary;

            for (int j = 0; j < tablica.Length - 1; j++)
            {
                for (int i = 0; i < tablica.Length - j - 1; i++)
                {
                    if (tablica[i] > tablica[i + 1])
                    {
                        temporary = tablica[i + 1];
                        tablica[i + 1] = tablica[i];
                        tablica[i] = temporary;
                    }
                }
            }

            foreach (int n in tablica)
            {
                Console.Write($"{n} ");
            }
        }
    }
}
