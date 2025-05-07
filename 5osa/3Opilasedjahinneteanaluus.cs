using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktilised_ülesanded._C__konstruktsioonid._5osa
{
    internal class _3Opilasedjahinneteanaluus
    {
        class Opilane
        {
            public string Nimi { get; set; }
            public List<int> Hinded { get; set; }

            public double KeskmineHinne()
            {
                return Hinded.Average();
            }
        }

        class OpilasedTest
        {
            public static void Run()
            {
                List<Opilane> opilased = new List<Opilane>
            {
                new Opilane { Nimi = "Kati", Hinded = new List<int>{5, 4, 5, 3} },
                new Opilane { Nimi = "Mati", Hinded = new List<int>{3, 4, 2, 5} },
                new Opilane { Nimi = "Liis", Hinded = new List<int>{4, 5, 4, 5} }
            };

                double maxKeskmine = 0;
                string parim = "";

                Console.WriteLine("Õpilaste keskmised hinded:");
                foreach (var opilane in opilased)
                {
                    double keskmine = opilane.KeskmineHinne();
                    Console.WriteLine($"{opilane.Nimi}: {keskmine:F2}");
                    if (keskmine > maxKeskmine)
                    {
                        maxKeskmine = keskmine;
                        parim = opilane.Nimi;
                    }
                }

                Console.WriteLine($"Kõrgeim keskmine hinne: {parim} - {maxKeskmine:F2}");
            }
        }

    }
}
