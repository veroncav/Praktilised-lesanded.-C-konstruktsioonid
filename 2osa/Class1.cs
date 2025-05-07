using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using osad;
using Praktilised_ülesanded._C__konstruktsioonid._2osa.osad;

namespace osad
{

    internal class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Tere tulemast!");
            string eesnimi = Console.ReadLine();
            Console.WriteLine("Tere, " + eesnimi);

            Pilet.OstaPilet(eesnimi, 65); // Пример с "Juku" и возрастом 65
            ToaRemont.ArvutaPindalaJaKulu();
            Temperatuur.KontrolliTemperatuur();
            Pikkus.KontrolliPikkus();
            PoestOst.TeostaOst();
        }
    }
}

