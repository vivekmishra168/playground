using System;

public class Program
{
	public static void Main()
	{
		Console.WriteLine("Enter a number from 1-7");
		string number = Console.ReadLine();
		
		if(number == "1")
			Console.WriteLine("Mon");
		else if(number == "2")
			Console.WriteLine("Tues");
		else if(number == "3")
			Console.WriteLine("Wed");
		else if(number == "4")
			Console.WriteLine("Thur");
		else if(number == "5")
			Console.WriteLine("Fri 
		else if(number == "6")
			Console.WriteLine("Sat");
		else if(number == "7")
			Console.WriteLine("Sun");
		else
			Console.WriteLine("Manna De....");
	}
}
