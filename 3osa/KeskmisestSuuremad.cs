using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktilised_ülesanded._C__konstruktsioonid._3osa
{
    internal class KeskmisestSuuremad
    {
    }
}
internal class KeskmisestSuuremad
{
    public static void Leia()
    {
        Random rnd = new Random();
        int[] arvud = new int[15];
        int summa = 0;

        for (int i = 0; i < arvud.Length; i++)
        {
            arvud[i] = rnd.Next(1, 101);
            summa += arvud[i];
        }

        double keskmine = summa / 15.0;
        Console.WriteLine($"Keskmine: {keskmine}");

        foreach (int arv in arvud)
        {
            if (arv > keskmine)
            {
                Console.WriteLine($"> Keskmisest suurem: {arv}");
            }
        }

        int j = 0;
        do
        {
            Console.WriteLine(arvud[j]);
            j++;
        } while (j < arvud.Length && arvud[j - 1] >= 10);
    }
}