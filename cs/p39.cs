//Find the sum of first 10 natural numbers
using System;  
public class Exercise2  
{  
    public static void Main() 
	{
		Console.WriteLine("Enter the Numbers");
		int number;
		int	sum=0;	
		number= Convert.ToInt32(Console.ReadLine());
			
		for(int i=1; i<=number; i++)
		{
			sum= sum + i;
			if(i != number)
				Console.Write(i + "+");
			else
				Console.Write(i);
		}
		Console.WriteLine(" = " + sum);
	}
}