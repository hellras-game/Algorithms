using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int d = 0, i = 2;
            int n = Convert.ToInt32(Console.ReadLine());
            while (i < n)
            {
                if (n % i == 0)
                {
                    d++;
                    i++;
                }
                else
                {
                    i++;
                }
            }

            if (d == 0 && n > 1)
            {
                Console.WriteLine("Простое");
            }
            else
            {
                Console.WriteLine("Не простое");
            }
            Console.ReadKey();
        }
    }
}
