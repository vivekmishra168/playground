// Large User number array[]


using System;
namespace p47
{
	public class program
	{
		public static void Main()
		{
			int[] array= new int[10];
			int i, num, largest;
			Console.WriteLine("Enter a number");
			num= Convert.ToInt32(Console.ReadLine());
			num= 10;
			Console.WriteLine("Enter" + num+ "number (5)");
			Console.WriteLine ("Enter Elemnents of array/n");
			for(i=0; i <num; i++)
			{
				array[i]= Convert.ToInt32(Console.ReadLine());
				{
					largest = array [0];
					for(i=1; i <num; i++)
					{
				if(largest < array[i]);
					}
					largest= array [i];
				}
			}
			Console.WriteLine("Large No=" /*+ largest*/);
		}
	}
}