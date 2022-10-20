using System;
namespace p22
{
	public class Program
	{
		public static void Main()
		{
			Console.WriteLine("Enter a Number");
			int number = int.Parse(Console.ReadLine());
			
			for( int i=1; i<=number; i++)
			{
				Console.WriteLine("@= " +i);
			}
		}
		
	}
	
}
