using System;

namespace feladat12
{
    class Program
    {
        static void Main(string[] args)
        {
            int z = 0;
            int atlag;
            int legdragabb = 0;
            int osszeg = 0;
            int szam = 0;
            string x;
                for (int n=1; n != 0; z++)
            {
                x= Console.ReadLine();
                n = Convert.ToInt32(x);
                if (legdragabb < n)
                {
                    legdragabb = n;
                }
                if (n < 500)
                {
                    szam++;
                }
                osszeg = osszeg + n;
            }
            atlag = osszeg /(z-1);
            Console.WriteLine(osszeg);
            Console.WriteLine(atlag);
            Console.WriteLine(legdragabb);
            Console.WriteLine(szam-1);
        }
    }
}
