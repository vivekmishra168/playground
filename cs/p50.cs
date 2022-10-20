// Lucas Number
using System;
namespace p50
{
	public class program
	{
		public static void Main()
		{
			Console.WriteLine("Please enter a number");
			int a=1, b=3, num, sum;
			num = Convert.ToInt32(Console.ReadLine());
			Console.Write("{0} {1}", a,b);
			for (int i=1; i<=num; i++)
			{
				sum = a+b;
				a=b;
				b=sum;
				Console.Write(" " + sum);
			}
		}
		
	}
}