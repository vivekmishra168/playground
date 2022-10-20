//WAP using 1 to 100 numbers with use loops  
using System;
namespace p35
{
	public class Program
	{
		public static void Main()
		{
			int num;
			for (int i=1; i<=10; i++)
			{
				num = i;
				for(int k=1; k<=10; k++)
				{
					Console.Write(num + "   ");
					num = num + 10; 
				}
				Console.WriteLine();
			}
			
			// for(int i=1; i<=5; i++)
			// {
				
				// for(int l=1; l<=i; l++)
				// {
					// Console.Write(" ");
				// }
				
				// for(int m=1; m<=5-i; m++)
				// {
					// Console.Write("*");
				// }
					
				// Console.WriteLine();
			// }
		}	
	}
}
