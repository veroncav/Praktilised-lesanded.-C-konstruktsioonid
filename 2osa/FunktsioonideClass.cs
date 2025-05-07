using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Praktilised_ülesanded._C__konstruktsioonid._2osa;

namespace osad
{
    public static class FunktsioonideClass_2osa
    {
        public static List<string> Sõnad()
        {
            return new List<string> { "Tere", "Kuidas", "Sul", "läheb?" };
        }

        public static Isik[] Isikud(int length, string[] nimed, string[] aadressid)
        {
            Isik[] isikud = new Isik[length];
            for (int i = 0; i < length; i++)
            {
                isikud[i] = new Isik(nimed[i], 30, "1234567890", aadressid[i]);
            }
            return isikud;
        }

        public static List<Isik> Isikud2(int length, string[] nimed, string[] aadressid)
        {
            List<Isik> isikud = new List<Isik>();
            for (int i = 0; i < length; i++)
            {
                isikud.Add(new Isik(nimed[i], 30, "1234567890", aadressid[i]));
            }
            return isikud;
        }
    }
}
