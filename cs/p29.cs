using System;
namespace p29
{
	public class Program
	{
		public static void Main()
		{
			for (int i=1; i<=9; i++)

			{
				for(int j=0; j <=9-i; j++)
				{
					Console.Write("*");
				}
				
				Console.WriteLine();
			}
		}
	}
}