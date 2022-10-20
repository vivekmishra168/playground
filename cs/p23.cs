using System;
namespace p23
{
	public class Program
	{
		public static void Main()
		{
			Console.WriteLine("Enter the number");
			int number =int.Parse(Console.ReadLine());
			for (int i=0; i<=number; i++)
			{
				Console.WriteLine(i);
			}
		}
	}
}