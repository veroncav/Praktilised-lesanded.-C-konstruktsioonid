using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktilised_ülesanded._C__konstruktsioonid._3osa
{
    internal class Korrutustabel
    {
        public static int[,] GenereeriKorrutustabel(int read, int veerud)
        {
            int[,] tabel = new int[read, veerud];

            for (int i = 0; i < read; i++)
            {
                for (int j = 0; j < veerud; j++)
                {
                    tabel[i, j] = (i + 1) * (j + 1);
                    Console.Write(tabel[i, j].ToString().PadLeft(4));
                }
                Console.WriteLine();
            }
            return tabel;
        }
    }
}