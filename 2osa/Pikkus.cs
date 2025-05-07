using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Praktilised_ülesanded._C__konstruktsioonid._2osa;

namespace Praktilised_ülesanded._C__konstruktsioonid._2osa
{
    internal class Pikkus
    {
    }
}
namespace osad
{
    public class Pikkus
    {
        public static void KontrolliPikkus()
        {
            Console.WriteLine("Sisesta pikkus (cm): ");
            double pikkus = Convert.ToDouble(Console.ReadLine());

            if (pikkus < 160)
            {
                Console.WriteLine("Lühike.");
            }
            else if (pikkus >= 160 && pikkus <= 175)
            {
                Console.WriteLine("Keskmine.");
            }
            else
            {
                Console.WriteLine("Pikk.");
            }
        }
    }
}
