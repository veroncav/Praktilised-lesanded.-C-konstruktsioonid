using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktilised_ülesanded._C__konstruktsioonid._3osa
{
        internal class Inimene
        {
            public string Nimi { get; set; }
            public int Vanus { get; set; }
        }

        internal class StatistikaTöötlus
        {
            public static Tuple<int, double, Inimene, Inimene> Statistika(List<Inimene> inimesed)
            {
                int summa = inimesed.Sum(i => i.Vanus);
                double keskmine = inimesed.Average(i => i.Vanus);
                Inimene vanim = inimesed.OrderByDescending(i => i.Vanus).First();
                Inimene noorim = inimesed.OrderBy(i => i.Vanus).First();

                Console.WriteLine($"Summa: {summa}, Keskmine: {keskmine}");
                Console.WriteLine($"Vanim: {vanim.Nimi}, Noorim: {noorim.Nimi}");
                return Tuple.Create(summa, keskmine, vanim, noorim);
            }
        }
    }
