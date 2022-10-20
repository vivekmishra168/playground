using System;
namespace p41
{
	public class program
	{
		public static void Main()
		{
			Console.WriteLine("enter the number");
			int number;
			int sum=0; 
			number= Convert.ToInt32(Console.ReadLine());
			for (int i=1; i<=number; i++)
			{
				sum = sum +i;
				if(i!=number)
				Console.Write(i+ "+");
			else
				Console.Write(i);
			}
				Console.WriteLine(" = " + sum);
		}
		
	}
}