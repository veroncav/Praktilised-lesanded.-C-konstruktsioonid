using System;
using System.Collections.Generic;
using System.Linq;

namespace osa3
{
    internal class SisendKontroll
    {
        public static void KuniMärksõnani(string märksõna, string fraas)
        {
            List<string> sisestused = new List<string>();
            string sisend;

            do
            {
                Console.WriteLine(fraas);
                sisend = Console.ReadLine();
                sisestused.Add(sisend);
            }
            while (sisend != märksõna);

            Console.WriteLine("\nKõik sisestused:");
            foreach (var s in sisestused)
            {
                Console.WriteLine(s);
            }
        }
    }
}