using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktilised_ülesanded._C__konstruktsioonid._2osa
{
    namespace osad
    {
        public class Temperatuur
        {
            public static void KontrolliTemperatuur()
            {
                Console.WriteLine("Sisesta temperatuur kraadides: ");
                double temperatuur = Convert.ToDouble(Console.ReadLine());

                if (temperatuur > 18)
                {
                    Console.WriteLine("Soovitatav toasoojus talvel.");
                }
                else
                {
                    Console.WriteLine("Temperatuur on madalam kui 18 kraadi.");
                }
            }
        }
    }
}
