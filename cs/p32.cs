/*
*****
****
***
**
*
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
namespace p32
{
	public class Program
	{
		public static void Main()
		{
			for (int i=1; i<=15; i++)
			{
				for(int j=0; j <=15-i; j++)
				{
					Console.Write("*");
				}
				
				Console.WriteLine();
			}
			for (int i=0; i<=9; i++)

			{
				for(int j=0; j <=i; j++)
				{
					Console.Write("#");
				}
				
				Console.WriteLine();
			}
			for (int i=1; i<=9; i++)
			{
				for(int j=0; j <=9-i; j++)
				{
					Console.Write("*");
				}
				
				Console.WriteLine();
			}
			char someChar = (char)(67);
			Console.WriteLine(someChar);
			
			
			int length = 4;
			char ch = 'A';
			for (int i=1; i<=length; i++)
			{
				for(int j=1; j <=length; j++)
				{
					Console.Write(ch);
				}
				Console.WriteLine();
				ch = (char)(ch + 1); // A ==> B, b ==> C, and so on.
			}
			
		}
	}
}