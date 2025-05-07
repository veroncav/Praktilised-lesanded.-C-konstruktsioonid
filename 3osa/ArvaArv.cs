using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktilised_ülesanded._C__konstruktsioonid._3osa
{
    internal class ArvamiseMang
    {
        public static void ArvaArv()
        {
            Random rnd = new Random();
            int arv;
            string vastus;

            do
            {
                arv = rnd.Next(1, 101);
                Console.WriteLine("Arva arv vahemikus 1-100. Sul on 5 katset.");

                for (int i = 0; i < 5; i++)
                {
                    Console.Write($"Katse {i + 1}: ");
                    int pakkumine = int.Parse(Console.ReadLine());

                    if (pakkumine == arv)
                    {
                        Console.WriteLine("Õige!");
                        break;
                    }
                    else if (pakkumine < arv)
                    {
                        Console.WriteLine("Liiga väike");
                    }
                    else
                    {
                        Console.WriteLine("Liiga suur");
                    }
                }

                Console.Write("Kas soovid uuesti mängida? (jah/ei): ");
                vastus = Console.ReadLine();
            }
            while (vastus.ToLower() == "jah");
        }
    }
}