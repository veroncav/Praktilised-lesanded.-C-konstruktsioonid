using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktilised_ülesanded._C__konstruktsioonid._2osa
{
    namespace Juku.Osa2
    {
        internal class Pood
    {
    }
}
   
        public static void TeostaOst()
        {
            double summa = 0;

            Console.WriteLine("Kas soovite osta piima (jah/ei)?");
            if (Console.ReadLine().ToLower() == "jah")
            {
                summa += 1.5;
            }

            Console.WriteLine("Kas soovite osta saia (jah/ei)?");
            if (Console.ReadLine().ToLower() == "jah")
            {
                summa += 0.8;
            }

            Console.WriteLine("Kas soovite osta leiba (jah/ei)?");
            if (Console.ReadLine().ToLower() == "jah")
            {
                summa += 1.2;
            }

            Console.WriteLine($"Teie ostude kogusumma on: {summa} eurot.");
        }
    }
}
