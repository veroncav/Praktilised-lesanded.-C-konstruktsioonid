using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktilised_ülesanded._C__konstruktsioonid._3osa
{
    internal class ArvuAnalüüs
    {
    
        public static Tuple<double, double, double> AnalüüsiArve(double[] arvud)
        {
            double summa = arvud.Sum();
            double korrutis = 1;
            foreach (double arv in arvud)
                korrutis *= arv;
            double keskmine = summa / arvud.Length;
            Console.WriteLine($"Summa: {summa}, Keskmine: {keskmine}, Korrutis: {korrutis}");
            return Tuple.Create(summa, keskmine, korrutis);
        }

        public static double[] Tekstist_Arvud()
        {
            double[] arvud = new double[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Sisesta arv {i + 1}: ");
                arvud[i] = double.Parse(Console.ReadLine());
            }
            return arvud;
        }
    }
}

