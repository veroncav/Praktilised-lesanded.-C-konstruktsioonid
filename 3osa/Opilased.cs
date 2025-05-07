using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktilised_ülesanded._C__konstruktsioonid._3osa
{
    internal class Opilased
    {
        public static void MängiOpilastega()
        {
            string[] nimed = { "Anna", "Peeter", "Mari", "Juhan", "Kristi", "Marko", "Liis", "Mart", "Karin", "Toomas" };
            nimed[2] = "Kati";
            nimed[5] = "Mati";

            int i = 0;
            while (i < nimed.Length)
            {
                if (nimed[i].StartsWith("A"))
                {
                    Console.WriteLine("Tere, " + nimed[i]);
                }
                i++;
            }

            for (int j = 0; j < nimed.Length; j++)
            {
                Console.WriteLine($"{j}: {nimed[j]}");
            }

            foreach (var nimi in nimed)
            {
                Console.WriteLine(nimi.ToLower());
            }

            int k = 0;
            do
            {
                Console.WriteLine("Tere, " + nimed[k]);
                if (nimed[k] == "Mati") break;
                k++;
            } while (k < nimed.Length);
        }
    }
}