using System;
namespace p18

public class Program
{
	public static void Main()
	{
		Console.WriteLine("Enter a number");
		string number1 = Console.ReadLine();
		Console.WriteLine("Enter Second number");
		string number2 = Console.ReadLine();
		bool result = number1 == number2;
		if (result == true)
			Console.WriteLine("equal");
		else
			Console.WriteLine("Not equal");
		}
}
