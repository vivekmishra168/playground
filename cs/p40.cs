using System;
namespace p40
{
		public class Program
	{
		public static void Main()
		{
			Console.WriteLine("Enter the numbers");
			int number;
			int sum =0;
			number= Convert.ToInt32(Console.ReadLine());
			for (int i=1; i<=number; i++)
		{
			sum = sum + i;
			if(i!= number)
				Console.Write(i+ "+");
			else
				Console.Write(i);
		}
			Console.WriteLine("= " + sum);
		}
	}
}