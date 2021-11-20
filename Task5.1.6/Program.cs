using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._1._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите любое число:");
            int N = Convert.ToInt32(Console.ReadLine());
            int[,] t = new int[N, N];
            int magicSum = 0;

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.WriteLine("Y: " + i + " X: " + j);
                    t[i, j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }
            Console.WriteLine("Вывод массива: ");

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(t[i, j] + "\t");
                }
                Console.WriteLine();
            }
            
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    //magicSum += t[i, j];
                    Console.WriteLine("Магическая сумма: {0} ", magicSum += t[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            int magicConst = N * (N * N + 1) / 2;
            if (magicConst == (magicSum/N))
            {
                Console.WriteLine("Квадрат магический");
            }
            else
            {
                Console.WriteLine("Квадрат, увы, простой!");
            }
            Console.ReadKey();
        }
    }
}
