using System;

namespace Csharpintroduction
{
	class Program
	{
		static void Main(string[] args)
		{
			int x = 100;
			x += 10;
			for (int i = 0; i < 10; i++)
			{
				Console.WriteLine(i);
				x += i;
			}
			Console.WriteLine("Writing out command line argument");
			foreach (string item in args)
			{
				Console.WriteLine(item);

			}
			
		}
	}
}
