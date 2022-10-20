using System;

namespace P21
{
	public class Program
	{
		public static void Main()
		{
			int first = 37;
			int second = 40;
			if (first == second)
			{
				Console.WriteLine("These two numbers are equal.");
			}
			else
			{
				if (first > second)
				{
					Console.WriteLine("The first number is greater.");
				}
				else
				{
					Console.WriteLine("The second number is greater.");
				}
			}
		}
	}
}

/*
Define the Function

public returntype FunctionName()
{
	.....
	.....
	!= not equal to 
}


Call the function

FunctionName();

*/