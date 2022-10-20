/* WAP print the series
*
**
***
****
*****
******
*******
********
*********
*/

using System;
namespace p31
{
	public class Program
	{
		public static void Main()
		{
			for (int i=0; i<=9; i++)

			{
				for(int j=0; j <=i; j++)
				{
					Console.Write("*");
				}
				
				Console.WriteLine();
			}
		}
	}
}