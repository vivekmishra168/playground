using System;

public class Program
{
	public static void Main()
	{
		int i = 55;
		int j = 15;
		
		Console.WriteLine("i =  " + i);
		Console.WriteLine("j = " + j);
		
		//bool result = i > j;
		if(i > j)
		{
			Console.WriteLine("I is bigger");
		}
		else
		{
			Console.WriteLine("J is bigger");
		}
	}	
}