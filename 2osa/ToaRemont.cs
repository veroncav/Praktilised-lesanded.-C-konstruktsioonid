using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktilised_ülesanded._C__konstruktsioonid._2osa
{
    namespace osad
    {
        public class ToaRemont
        {
            public static void ArvutaPindalaJaKulu()
            {
                Console.WriteLine("Sisesta toa pikkus: ");
                double pikkus = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Sisesta toa laius: ");
                double laius = Convert.ToDouble(Console.ReadLine());

                double pindala = pikkus * laius;
                Console.WriteLine($"Põranda pindala on: {pindala} m²");

                Console.WriteLine("Kas soovid remonditööd teha? (jah/ei)");
                string soov = Console.ReadLine().ToLower();
                if (soov == "jah")
                {
                    Console.WriteLine("Sisesta ruutmeetri hind: ");
                    double hind = Convert.ToDouble(Console.ReadLine());
                    double koguhind = hind * pindala;
                    Console.WriteLine($"Põranda vahetamise hind on: {koguhind} eurot.");
                }
                else
                {
                    Console.WriteLine("Remondist loobuti.");
                }
            }
        }
    }
}

