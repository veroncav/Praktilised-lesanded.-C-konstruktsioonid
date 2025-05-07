using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktilised_ülesanded._C__konstruktsioonid._5osa
{
    internal class _5ArvudeStatistika
    {
        class ArvudeStatistika
        {
            public static void Run()
            {
                Console.WriteLine("Sisesta arvud eraldatuna tühikutega:");
                string sisend = Console.ReadLine();
                double[] arvud = sisend.Split(' ').Select(double.Parse).ToArray();

                double max = arvud.Max();
                double min = arvud.Min();
                double keskmine = arvud.Average();
                double summa = arvud.Sum();
                int suuremadKuiKeskmine = arvud.Count(a => a > keskmine);

                Console.WriteLine($"Maksimum: {max}");
                Console.WriteLine($"Miinimum: {min}");
                Console.WriteLine($"Keskmine: {keskmine:F2}");
                Console.WriteLine($"Summa: {summa}");
                Console.WriteLine($"Suuremad kui keskmine: {suuremadKuiKeskmine}");

                Array.Sort(arvud);
                Console.WriteLine("Sorditud arvud: " + string.Join(", ", arvud));
            }
        }

    }
}
