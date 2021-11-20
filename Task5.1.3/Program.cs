using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            int[] m = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                m[i] = random.Next(-50, 50);
                Console.Write("{0} ", m[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++) // внешний цикл
            {
                for (int j = i; j < n - 5; j++) // внутр. цикл
                {
                    if (m[i] > m[j])
                    {
                        int t2 = m[i];
                        m[i] = m[j];
                        m[j] = t2;
                    }
                }
            }
            for (int i = 5; i < n; i++) // внешний цикл
            {
                for (int j = i + 1; j < n; j++) // внутр. цикл
                {
                    if (m[i] < m[j])
                    {
                        int t1 = m[i];
                        m[i] = m[j];
                        m[j] = t1;
                    }
                }
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", m[i]);
            }
            Console.ReadKey();
        }
    }
}
