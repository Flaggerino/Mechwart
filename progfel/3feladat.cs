using System;

namespace _3.feladat
{
	class Program
	{
		static void Main(string[] args)
		{
			int a;
			string b;
			Console.WriteLine("Hány x-et szeretne látni?");
			b = Console.ReadLine();
			a = Convert.ToInt32(b);
			for (int i = 0; i < a; i++)
			{
				Console.Write("x");
			}
		}
	}
}

