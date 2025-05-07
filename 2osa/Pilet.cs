using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osad
{
    public class Pilet
    {
        public static void OstaPilet(string nimi, int vanus)
        {
            if (nimi.ToLower() == "juku")
            {
                Console.WriteLine("Tule kinno, Juku!");
                if (vanus < 6)
                {
                    Console.WriteLine("Pilet on tasuta.");
                }
                else if (vanus >= 6 && vanus <= 14)
                {
                    Console.WriteLine("Lastepilet.");
                }
                else if (vanus >= 15 && vanus <= 65)
                {
                    Console.WriteLine("Täispilet.");
                }
                else if (vanus > 65)
                {
                    Console.WriteLine("Sooduspilet.");
                }
                else
                {
                    Console.WriteLine("Vale vanus.");
                }
            }
            else
            {
                Console.WriteLine("Täna mind kodus pole.");
            }
        }
    }
}
