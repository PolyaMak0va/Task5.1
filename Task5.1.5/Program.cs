using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите любое число:");
            int N = Convert.ToInt32(Console.ReadLine());
            int[,] t = new int[N, N];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    t[i, j] = (1 + (i + j)) % 2;
                    Console.Write("{0} ", t[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
