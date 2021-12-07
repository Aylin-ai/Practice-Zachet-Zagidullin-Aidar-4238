using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string k;
            char n1;
            char n2;
            int n = 39;
            string N = Convert.ToString(n);
            n1 = N[0];
            n2 = N[1];
            k = Convert.ToString(N[1]) + Convert.ToString(N[0]);
            n = Convert.ToInt32(k);
            Console.WriteLine(n);
            Console.ReadKey();
        }
    }
}
