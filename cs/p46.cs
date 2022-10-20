/* WAP print a series
1
12
123
1234
12345
*/
using System;
public class program
{
	public static void Main()
	{
		for( int i=0; i<=5; i++)
		{
			for (int j=0; j<=i; j++)
			{
				Console.Write(j);
			}	
			Console.WriteLine();
				
		}
	}
}