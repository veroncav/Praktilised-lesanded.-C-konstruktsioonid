
using System;
using System.Collections.Generic;
using osad;

namespace osad
{
    internal class MainClass
    {
        public static void Main(string[] args)
        {
            // II. osa Kordused, Massivid, Listid, Klassid
            List<string> sonad = FunktsioonideClass_2osa.Sõnad();
            foreach (var item in sonad)
            {
                Console.WriteLine(item);
            }

            // Создание объектов класса Isik
            Isik isik1 = new Isik("Juku", 65, "12345678901", "Tallinn");
            isik1.PrindiInfo();
            Isik isik2 = new Isik();
            isik2.Nimi = "Mari";
            isik2.Aadress = "Tartu";
            isik2.Isikukood = "98765432101";
            isik2.Sugu = Sugu.Naine;
            isik2.PrindiInfo();

            // Массивы имен и адресов
            int i;
            string[] nimed = new string[10] { "Juku", "Mari", "Kati", "Peeter", "Mati", "Liina", "Katrin", "Andres", "Marko", "Kristi" };
            string[] aadressid = new string[10] { "Tallinn", "Tartu", "Pärnu", "Narva", "Kohtla-Järve", "Viljandi", "Rakvere", "Paide", "Jõhvi", "Kuressaare" };

            Console.WriteLine("-----for++Massiv-------");
            Isik[] isikud = FunktsioonideClass_2osa.Isikud(nimed.Length, nimed, aadressid);
            for (i = 0; i < nimed.Length; i++)
            {
                isikud[i].PrindiInfo();
            }

            Console.WriteLine("-----for--List-------");
            List<Isik> isikud2 = FunktsioonideClass_2osa.Isikud2(nimed.Length, nimed, aadressid);
            foreach (Isik isik in isikud2)
            {
                isik.PrindiInfo();
            }

            Console.WriteLine("-----while-------");
            i--; // Уменьшаем i, чтобы избежать бесконечного цикла
            while (i >= 0)
            {
                Console.WriteLine(i);
                i--;
            }

            Console.WriteLine("-----do-------");
            ConsoleKeyInfo key;
            do
            {
                Console.WriteLine("Нажмите Backspace для завершения...");
                key = Console.ReadKey();
            }
            while (key.Key != ConsoleKey.Backspace);
        }
    }
}
