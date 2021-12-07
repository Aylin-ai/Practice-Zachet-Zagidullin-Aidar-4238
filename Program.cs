using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int n = 4;
            int m = 8;
            int max = 0;
            int min = 0;
            int[,] arrA = new int[n, m];
            int[] maxarr = new int[n];
            for (int i = 0; i < n; i++) 
            {
                for (int j = 0; j < m; j++) 
                {
                    arrA[i, j] = rand.Next(-19, 31);
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(arrA[i, j]);
                    Console.Write(' ');
                }
                Console.WriteLine();
            }

            Console.WriteLine("Максимальные элементы");
            for (int i = 0; i < n; i++) 
            {
                max = arrA[i, 0];
                for (int j = 0; j < m; j++) 
                {
                    if (arrA[i, j] > max)
                    {
                        max = arrA[i, j];
                    }
                }
                maxarr[i] = max;
            }
            for (int k = 0; k < n; k++) 
            {
                Console.Write(maxarr[k]);
                Console.Write(" ");
            }
            Console.WriteLine();
            Console.WriteLine("Минимальные элементы");
            for (int j = 0; j < m; j++)
            {
                min = arrA[0, j];
                for (int i = 0; i < n; i++)
                {
                    if (arrA[i, j] < min)
                    {
                        min = arrA[i, j];
                    }
                }
                Console.Write(min);
                Console.Write(' ');
            }
            Console.ReadKey();
        }
    }
}
