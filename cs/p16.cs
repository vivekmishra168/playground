using System;

public class Program
{
	public static void Main()
	{
		Console.WriteLine("Enter a Number");
		string number = Console.ReadLine();
		
		switch (number)
		{
			case "2":
			case "4":
			case "6":
			case "8":
			case "10":
			case "12":
			case "14":
			case "16":
			case "18":
			case "20":
			case "22":
			case "24":
				Console.WriteLine("Even Number");
				break;
			case "1":
			case "3":
			case "5":
			case "7":
			case "9":
			case "11":
			case "13":
			case "15":
			case "17":
			case "19":
			case "21":
			case "23":
			Console.WriteLine("Odd number");
				break;
			default:
				Console.WriteLine("Number is Out of range.(1-25)");
				break;
		}
	}
}
