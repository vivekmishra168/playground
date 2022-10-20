using System;
namespace p27
{
	public class Program
	{
		public static void Main()
		{
			char someChar = (char)(67);
			Console.WriteLine(someChar);
			
			
			int length = 10;
			char ch = '1';
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