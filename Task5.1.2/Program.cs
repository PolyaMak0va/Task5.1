using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] m = new int[15];
            Random random = new Random();
            for (int i = 0; i < 15; i++)
            {
                m[i] = random.Next(0, 50);
                Console.Write("{0} ", m[i]);
            }
            Console.WriteLine();
            int max = m[0];
            int min = m[0];
            foreach (int a in m)
            {
                if (a > max)            
                    max = a;
            }
            Console.Write("Максимальное значение = {0,2} ", max);
            Console.WriteLine();
            foreach (int b in m)
            {
                if (b < min)
                    min = b;
            }
            Console.Write("Минимальное значение = {0,2} ", min);
            Console.WriteLine();
            Console.WriteLine("Сумма max и min = {0,8} ", max + min);
            Console.ReadKey();
        }
    }
}
