/* Fibonacci series program */
using System;
namespace p49
{
	public class program
	{
		public static void Main()
		{
			Console.WriteLine("Please enter a number");
			int a=0, b=1, num, sum;
			num= Convert.ToInt32(Console.ReadLine());
			Console.Write("{0} {1}", a, b);
			for (int i=1; i <= num -2; i++)
			{
				sum = a+b;
				a=b;
				b=sum;
				Console.Write(" " + sum);
			}
		}
	}
}