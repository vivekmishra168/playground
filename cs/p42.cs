using System;
namespace p37
{
public class Program
{
	public static void Main()
	{
		int number1, number3;
		int sum=0;
		Console.WriteLine("Enter first number ");
		number1 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine();
		while(true)
		{
			Console.WriteLine("Would you like to add one monre numbers (Y/N)?");
			char choice = Convert.ToChar(Console.ReadLine().ToLower());
			if(choice == 'n')
				break;
			Console.WriteLine("Enter number ");
			number3 = Convert.ToInt32(Console.ReadLine());
			sum= number1 + number3;
			Console.WriteLine();
		}
		
		sum=number1 + number3;
		int i=1; i<=sum; i++;
		Console.WriteLine("thank you");
			
	}
}	
 }
 // using System;

// namespace myApp
// {
 // class Program
 // {
  // static void Main(string[] args)
  // {
   // int start = 1;
   // int end = 10;
   // int total = 0;
   // int count = (end - start) + 1;
   // float average = 0;

   // Console.WriteLine("Average of numbers between {0} and {1}:\n", start, end);
   // for(start=start; start<=end; start++)
    // total += start;

   // Console.WriteLine("Total = " +total);
   // Console.WriteLine("Count = " +count);
   // average = (float) total / count;
   // Console.WriteLine("Average is " +average);
  // }
 // }
// }
