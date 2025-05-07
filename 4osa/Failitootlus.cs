using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktilised_ülesanded._C__konstruktsioonid._4osa
{

    namespace osa4
    {
        internal class KuudFailitoo
        {
            public static void Run()
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Kuud.txt");

                // Kontrolli, kas fail eksisteerib, kui ei, siis loo algsed kuud
                if (!File.Exists(path))
                {
                    File.WriteAllLines(path, new string[] { "Jaanuar", "Veebruar", "Märts" });
                }

                // Loe failist kuud listi
                List<string> kuudeList = new List<string>();
                try
                {
                    foreach (string rida in File.ReadAllLines(path))
                    {
                        kuudeList.Add(rida);
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Viga failist lugemisel!");
                    return;
                }

                // Eemalda "Juuni" kui on olemas
                kuudeList.Remove("Juuni");

                // Muuda esimest elementi
                if (kuudeList.Count > 0)
                {
                    kuudeList[0] = "Veeel kuuu";
                }

                // Kuvame kõik kuud
                Console.WriteLine("--- Kuud pärast muutmist ---");
                foreach (string kuu in kuudeList)
                {
                    Console.WriteLine(kuu);
                }

                // Otsing kasutajalt
                Console.WriteLine("Sisesta kuu nimi, mida otsida:");
                string otsitav = Console.ReadLine();
                if (kuudeList.Contains(otsitav))
                {
                    Console.WriteLine("Kuu " + otsitav + " on olemas.");
                }
                else
                {
                    Console.WriteLine("Sellist kuud pole.");
                }

                // Salvesta uuesti faili
                try
                {
                    File.WriteAllLines(path, kuudeList);
                    Console.WriteLine("Andmed on salvestatud.");
                }
                catch (Exception)
                {
                    Console.WriteLine("Viga failile kirjutamisel!");
                }
            }
        }
    }
}


