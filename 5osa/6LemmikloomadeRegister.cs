using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktilised_ülesanded._C__konstruktsioonid._5osa
{
    internal class _6LemmikloomadeRegister
    {
        class Lemmikloom
        {
            public string Nimi { get; set; }
            public string Liik { get; set; }
            public int Vanus { get; set; }
        }

        class LemmikloomRegister
        {
            public static void Run()
            {
                List<Lemmikloom> loomad = new List<Lemmikloom>();

                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"Sisesta looma {i + 1} nimi:");
                    string nimi = Console.ReadLine();
                    Console.WriteLine("Liik:");
                    string liik = Console.ReadLine();
                    Console.WriteLine("Vanus:");
                    int vanus = int.Parse(Console.ReadLine());
                    loomad.Add(new Lemmikloom { Nimi = nimi, Liik = liik, Vanus = vanus });
                }

                Console.WriteLine("Kõik kassid:");
                foreach (var loom in loomad.Where(l => l.Liik.ToLower() == "kass"))
                {
                    Console.WriteLine($"{loom.Nimi}, {loom.Vanus} a");
                }

                double keskmineVanus = loomad.Average(l => l.Vanus);
                var vanim = loomad.OrderByDescending(l => l.Vanus).First();

                Console.WriteLine($"Keskmine vanus: {keskmineVanus:F2}");
                Console.WriteLine($"Vanim loom: {vanim.Nimi} ({vanim.Vanus} a)");

                Console.WriteLine("Sisesta looma nimi otsimiseks:");
                string otsing = Console.ReadLine();
                var leitud = loomad.FirstOrDefault(l => l.Nimi.Equals(otsing, StringComparison.OrdinalIgnoreCase));

                if (leitud != null)
                    Console.WriteLine($"{leitud.Nimi} on {leitud.Liik}, {leitud.Vanus} aastat vana.");
                else
                    Console.WriteLine("Looma ei leitud.");
            }
        }
    }

}

