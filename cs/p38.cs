using System;
namespace p37
{
public class Program
{
	public static void Main()
	{
		int number1, number2, number3;
		Console.WriteLine("Enter first number ");
		number1 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter Second number ");
		number2 = Convert.ToInt32(Console.ReadLine());
		int sum = number1 + number2;
		Console.WriteLine(sum);
		while(true)
		{
			Console.WriteLine("Would you like to add one monre numbers (Y/N)?");
			char choice = Convert.ToChar(Console.ReadLine().ToLower());
			if(choice == 'n')
				break;
			Console.WriteLine("Enter number ");
			number3 = Convert.ToInt32(Console.ReadLine());
			sum = sum + number3;
			Console.WriteLine(sum);
		}
		Console.WriteLine("thank you");
			
	}
}	
 }
// for(int m=1; m<=5-i; m++)
				// {
					// Console.Write("*");
				// }
				
				// while (i<=9)
			// {
				// Console.WriteLine(i);
				// i++;
			// // }