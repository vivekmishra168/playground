/*
	WAP to calculate average of numbers given by user on command prompt.
	Program will keep on adding and will given the answer only when user entrs an n at the end.
*/

using System;

namespace p44
{
	public class Program
	{
		public static void Main()
		{
			int sum=0;
			int num1;
			int counter = 0;
			
			Console.WriteLine("Enter a number until you enter(n):");
			
			while(true)
			{
				string input = Console.ReadLine();
				if (input == "n")
					break;
				
				num1 = int.Parse(input);
				sum = sum + num1;   
				counter++;
			}
			Console.WriteLine($"sum = {sum} and counter = {counter}");
			
			double avg = (double)sum/(double)counter;
			Console.WriteLine(avg);
		}
	}	
}
