// Large fix number array[]


using System;
namespace p47
{
	public class program
	{
		public static void Main()
		{
			int[] num= {10,20,30,40,50,60,70};
			int max = num[0];
			for (int i=1; i<num.Length; i++)
			{
				if(max <num [i])
			{
					max=num[i];
			}
			
			}
			Console.WriteLine("LargeNumber="+max);
		}
	}
}