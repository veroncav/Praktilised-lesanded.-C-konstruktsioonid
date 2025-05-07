using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktilised_ülesanded._C__konstruktsioonid._3osa
{
    internal class PosNegNull
    {
        public static void Loenda()
        {
            int[] arvud = { 5, -3, 0, 8, -1, 4, -7, 2, 0, -5, 6, 9 };
            int pos = 0, neg = 0, nullid = 0;

            foreach (int arv in arvud)
            {
                if (arv > 0) pos++;
                else if (arv < 0) neg++;
                else nullid++;
            }

            Console.WriteLine($"Positiivseid: {pos}, Negatiivseid: {neg}, Nullid: {nullid}");
        }
    }
}