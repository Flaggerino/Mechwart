using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feladat2
{
    class Program
    {
        static void Main(string[] args)
        {
            string y, c, z;
            int d, e, f;
            int x = 1;

            y = Console.ReadLine();
            d = Convert.ToInt32(y);
           
            c = Console.ReadLine();
            e = Convert.ToInt32(c);
           
            z = Console.ReadLine();
            f = Convert.ToInt32(z);

            if (d == e)
            {
                x = x + 1;
            }
            if (d == f)
            {
                x = x + 1;
            }
            if (f == e)
            {
                x = x + 1;
            }
            if (x == 4)
            {
                x = x - 1;
            }
            if (x > 1)
            {
                Console.WriteLine(x);
            }
            if (x == 1)
            {
                x = x - 1;
                Console.WriteLine(x);
            }

        }
    }
}
