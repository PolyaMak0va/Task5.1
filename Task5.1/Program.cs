using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 7 любых чисел:");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());
            int n3 = Convert.ToInt32(Console.ReadLine());
            int n4 = Convert.ToInt32(Console.ReadLine());
            int n5 = Convert.ToInt32(Console.ReadLine());
            int n6 = Convert.ToInt32(Console.ReadLine());
            int n7 = Convert.ToInt32(Console.ReadLine());
            int[] m = new int[7] { n1, n2, n3, n4, n5, n6, n7 };
            float sum = 0;
            for (int i = 0; i < 7; i++)
            {
                sum += m[i];
            }
            Console.Write("Среднее арифметическое значение всех чисел равно {0:f2} ", sum / 7);
            Console.ReadKey();
        }
    }
}
