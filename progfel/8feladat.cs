using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feladat8
{
    class Program
    {
        static void Main(string[] args)
        {
            string x;



            int f = 0;
            int z = 0;
            for (int c; f < 12; f++)
            {
                x = Console.ReadLine();
                c = Convert.ToInt32(x);

                z = z + c;
            }
            Console.WriteLine(z);
            Console.WriteLine(z / 12);
        }
    }
    }

