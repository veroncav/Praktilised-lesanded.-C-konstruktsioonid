using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktilised_ülesanded._C__konstruktsioonid._3osa
{
    internal class MaxNeljarv
    {
        public static int SuurimNeljarv(double[] arvud)
        {
            List<int> digits = arvud.Select(Convert.ToInt32).ToList();
            digits.Sort();
            digits.Reverse();
            string result = string.Join("", digits);
            return int.Parse(result);
        }
    }
}