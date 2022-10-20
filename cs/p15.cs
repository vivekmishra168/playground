using System;
namespace p15

public class Program
{
	public static void Main()
	{
		Console.WriteLine("Enter a number:");
		string number = Console.ReadLine();
		int a = int.Parse(number);
		int remainder = a % 2;
		
		if(remainder == 0)
		{
			Console.WriteLine("Even number");
		}
		else
		{
			Console.WriteLine("Odd number");
		}
			
	}
}
