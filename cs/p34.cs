/* WAP print the series

    *
   **
  ***
 ****
*****
 ****
  ***
   **
    *   
*/
using System;
namespace p34
{
	public class Program
	{
		public static void Main()
		{
			for (int i=1; i<=5; i++)
			{
				for(int j=1; j<=5-i; j++)
				{
					Console.Write(" ");
				}
				
				for(int k=1; k<=i; k++)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}
			
			for(int i=1; i<=5; i++)
			{
				
				for(int l=1; l<=i; l++)
				{
					Console.Write(" ");
				}
				
				for(int m=1; m<=5-i; m++)
				{
					Console.Write("*");
				}
					
				Console.WriteLine();
			}
		}	
	}
}
