using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число А");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число B");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число C");
            int c = Convert.ToInt32(Console.ReadLine());
            int dla=a;
            int dlb = b;
            int i1 = 0;

            while (dlb >= c)

            {
                dla = a;
                while (dla >= c)
                {
                    dla -= c;
                    i1++;
                }
                dlb -= c;
            }
            Console.WriteLine("Число квадратов {0}", i1);
            Console.ReadKey();
        }
    }
}
