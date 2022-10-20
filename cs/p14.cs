using System;

public class Program
{
	public static void Main()
	{
		Console.WriteLine("Enter a vowel");
		string number = Console.ReadLine();
		
		switch (number)
		{
			case "a":
			case "e":
			case "i":
			case "o":
			case "u":
			case "A":
			case "E":
			case "I":
			case "O":
			case "U":
				Console.WriteLine("Vowel");
				break;
			default:
				Console.WriteLine("Consonant");
				break;
		}
	}
}
