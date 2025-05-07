using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktilised_ülesanded._C__konstruktsioonid._3osa
{
    internal class MaxIndeks
    {
        public static void Otsi()
        {
            int[] numbrid = { 12, 56, 78, 2, 90, 43, 88, 67 };
            int max = numbrid[0];
            int indeks = 0;

            for (int i = 1; i < numbrid.Length; i++)
            {
                if (numbrid[i] > max)
                {
                    max = numbrid[i];
                    indeks = i;
                }
            }

            Console.WriteLine($"Suurim arv: {max}, indeks: {indeks}");
        }
    }
}