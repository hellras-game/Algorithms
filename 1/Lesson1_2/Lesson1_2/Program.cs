using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n0 = 0, n1 = 1;
            int c = Convert.ToInt32(Console.ReadLine());
            int o = 0;
            for (int i = 2; i <= c; i++)
            {
                o = n0 + n1;
                n0 = n1;
                n1 = o;
            }
            Console.WriteLine(o);
            Console.ReadKey();
        }
    }
}
