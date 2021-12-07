using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string w1 = "Я нашел классную сломанную ногу";
            string w2 = "Нога, найденная мной, была ненастоящей";
            Func(w1, w2);
            Console.ReadKey();
        }
        static void Func(string w1, string w2)
        {
            int n = 0;
            foreach (char c in w1)
            {
                if (c == 'н' || c == 'Н')
                    n += 1;
            }

            foreach (char c in w2)
            {
                if (c == 'н' || c == 'Н')
                    n += 1;
            }
            Console.WriteLine(n);
        }
    }
}
