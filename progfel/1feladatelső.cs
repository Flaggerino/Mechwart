using System;

namespace _1.feladat
{
	class Program
	{
		static void Main(string[] args)
		{
			int a;
			string b;
			Console.WriteLine("Írjon be egy árértéket: ");
			b = Console.ReadLine();
			a = Convert.ToInt32(b);
			Console.WriteLine("Az érték áfával:"+a*1.27);
		}
	}
}
