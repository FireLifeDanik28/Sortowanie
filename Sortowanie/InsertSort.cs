using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortowanie
{
    internal class InsertSort
    {
        static int[] Sort(int[] tablica)
        {
            int[] tablica2 = new int[tablica.Length];

            for (int i = 0; i < tablica.Length; i++)
            {
                if (i != 0)
                {
                    tablica2[i] = tablica[i];
                    for (int j = i; j > 0; j--)
                    {
                        if (tablica2[j - 1] > tablica2[j])
                        {
                            int temp = tablica2[j];
                            tablica2[j] = tablica2[j - 1];
                            tablica2[j - 1] = temp;
                        }

                    }
                }
                else
                {
                    //pierwszy element
                    tablica2[i] = tablica[i];
                }
            }
            return tablica2;
        }
    }
}
