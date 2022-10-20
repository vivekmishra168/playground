/*
	WAP to calculate average of numbers given by user on command prompt as command line arguments.
*/

using System;

namespace p43
{
	public class Program
	{
		public static void Main(string[] args)
		{
			int sum=0;
			
			for(int i=0; i< args.Length; i++)
			{
				sum = sum + int.Parse(args[i]);
			}
			
			double avg = (double)sum/(double)args.Length;
			Console.WriteLine(avg);
		}
	}	
}
