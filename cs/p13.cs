using System;

public class Program
{
	public static void Main()
	{
		Console.WriteLine("Enter a number from 1-12");
		string number = Console.ReadLine();
		
		switch (number)
		{
			/*
			case "1":
				Console.WriteLine("Mon");
				break;
			case "2":
				Console.WriteLine("Tues");
				break;
			case "3":
				Console.WriteLine("Wed");
				break;
			case "4":
				Console.WriteLine("Thur");
				break;
			case "5":
				Console.WriteLine("Fri");
				break;
			case "6":
				Console.WriteLine("Sat");
				break;
			case "7":
				Console.WriteLine("Sun");
				break;
			default:
				Console.WriteLine("Manna de...");
				break
				*/
				
				case "1":
				Console.WriteLine("January");
				break;
				case "2":
				Console.WriteLine("Febury");
				break;case "3":
				Console.WriteLine("March");
				break;case "4":
				Console.WriteLine("April");
				break;case "5":
				Console.WriteLine("May");
				break;case "6":
				Console.WriteLine("June");
				break;case "7":
				Console.WriteLine("July");
				break;case "8":
				Console.WriteLine("August");
				break;case "9":
				Console.WriteLine("September");
				break;case "10":
				Console.WriteLine("October");
				break;case "11":
				Console.WriteLine("Novmber");
				break;case "12":
				Console.WriteLine("Decmber");
				break;
				default:
				Console.WriteLine("Manna de...");
				break;
		}
	}
}
