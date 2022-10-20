using System;

namespace p25
{
	public class Program
	{
		public static void Main()
		{
			Console.WriteLine("Enter a number");
			int number = int.Parse(Console.ReadLine());
			Console.WriteLine();
			
			for (int i=2; i<=number; i = i + 2)
			{
				Console.WriteLine(i);
			}
		}
	}
}