using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feladat5
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1501; i < 1800; i++)
            {
                if (i % 2 == 0 && (i % 8 == 0))

                    {
                    if(i%10!=6)
                        Console.WriteLine(i);
                   }
            }

        }
    }
}
