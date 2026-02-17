using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortowanie
{
    public class BubbleSort
    {
        public static int[] Sort(int[] tablica)
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
            return tablica;
        }

        public static double[] Sort(double[] tablica)
        {
            double temporary;

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
            return tablica;
        }
    }
}
