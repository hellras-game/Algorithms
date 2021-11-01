using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n0 = 0, n1 = 1;
            int c = Convert.ToInt32(Console.ReadLine());
            int o = F(c);
            Console.WriteLine(o);
            Console.ReadKey();
        }
        static int F(int c)
        {
            if (c == 0 || c == 1)
            {
                return c;
            }
            else
            {
                return F(c - 1) + F(c - 2);
            }
        }
    }
}
