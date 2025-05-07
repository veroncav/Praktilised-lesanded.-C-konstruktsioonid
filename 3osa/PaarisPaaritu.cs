using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktilised_ülesanded._C__konstruktsioonid._3osa
{
    internal class PaarisPaaritu
    {
        public static void Loenda()
        {
            Random rnd = new Random();
            List<int> arvud = new List<int>();

            for (int i = 0; i < 20; i++)
            {
                arvud.Add(rnd.Next(1, 101));
            }

            int paarisSumma = 0;
            int paarituSumma = 0;
            int paarituCount = 0;
            int suuremad = 0;

            foreach (int arv in arvud)
            {
                if (arv % 2 == 0) paarisSumma += arv;
                else
                {
                    paarituSumma += arv;
                    paarituCount++;
                }

                if (arv > 50) suuremad++;
            }

            Console.WriteLine($"Paarisarvude summa: {paarisSumma}");
            Console.WriteLine($"Paaritute keskmine: {(double)paarituSumma / paarituCount}");
            Console.WriteLine($"Suuremad kui 50: {suuremad}");
        }
    }
}
