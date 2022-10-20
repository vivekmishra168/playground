using System;
namespace p26
{
	public class Program
	{
		public static void Main()
		{
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