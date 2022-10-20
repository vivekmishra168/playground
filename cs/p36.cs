// WAP a program to fil the table 2 to 10
using System;
namespace p36

{
	public class Program
	{
		public static void Main()
		{
			int num;
			for (int i=2; i<=10; i++)
			{
				num = i;
				for(int k=1; k<=10; k++)
				{
					Console.Write(num + "   ");
					num = num + i; 
				}
				Console.WriteLine();
			}
		}
	}
}	