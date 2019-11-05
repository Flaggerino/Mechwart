using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feladat11
{
	class Program
	{
		static void Main(string[] args)
		{
			string szoveg = Console.ReadLine();
			int szam = Convert.ToInt32(szoveg);


			if (1 <= szam && szam <= 7)
			{
				if (szam == 1)
				{
					Console.WriteLine("Hétfő");
				}
				if (szam == 2)
				{
					Console.WriteLine("Kedd");
				}
				if (szam == 3)
				{
					Console.WriteLine("Szerda");
				}
				if (szam == 4)
				{
					Console.WriteLine("Csütörtök");
				}
				if (szam == 5)
				{
					Console.WriteLine("Péntek");
				}
				if (szam == 6)
				{
					Console.WriteLine("Szombat");
				}
				if (szam == 7)
				{
					Console.WriteLine("Vasárnap");
				}
			}
			else
			{
				Console.WriteLine("Ilyen nap nincs!");

			}

			
		}
	}
}
