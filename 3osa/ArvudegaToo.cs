using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktilised_ülesanded._C__konstruktsioonid._3osa
{
    internal class ArvudegaToo
    {
            public static void RuududKahekordsedJaguvad3()
            {
                int[] arvud = { 2, 4, 6, 8, 10, 12 };

                for (int i = 0; i < arvud.Length; i++)
                {
                    Console.WriteLine($"{arvud[i]}^2 = {arvud[i] * arvud[i]}");
                }

                foreach (var arv in arvud)
                {
                    Console.WriteLine($"{arv} x 2 = {arv * 2}");
                }

                int count = 0;
                int j = 0;
                while (j < arvud.Length)
                {
                    if (arvud[j] % 3 == 0) count++;
                    j++;
                }
                Console.WriteLine($"Jaguvad 3-ga: {count}");
            }
        }

    }
}
