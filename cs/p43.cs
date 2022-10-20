/*
	WAP to calculate average of numbers given by user on command prompt.
*/

using System;

namespace p43
{
	public class Program
	{
		public static void Main()
		{
			int sum=0;
			int num1;
			int counter = 0;
			char choice;
			do
			{
				Console.WriteLine("Enter a number:");
				num1 = int.Parse(Console.ReadLine());
				sum = sum + num1;
				counter++;
				Console.WriteLine($"Counter: {counter} would you like to enter more numbers to get average(y/n)");
				choice = Convert.ToChar(Console.ReadLine().ToLower());
			}while(choice == 'y');
			
			double avg = (double)sum/(double)counter;
			Console.WriteLine(avg);
		}
	}	
}
