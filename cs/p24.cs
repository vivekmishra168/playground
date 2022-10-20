using System;
namespace p24
{
	public class Program
	{
		public static void Main()
		{
			Console.WriteLine("Enter a number");
			int number = int.Parse(Console.ReadLine());
			Console.WriteLine();
			
			for (int i=1; i<=number; i++)
			{
				if(i%2 != 0) // It runs only when number is even.
				{
					Console.WriteLine(i);
				}
			}
		}
	}
}