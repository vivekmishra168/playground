using System;

public class Program
{
	int number; // Class level variable
	
	// We have local variables in this case named num, num0, num1, and so on.
	public static void Main(string[] args)
	{
		sbyte num = sbyte.MaxValue;
		Console.WriteLine(num);
		num = sbyte.MinValue;
		Console.WriteLine(num);
		
		byte num0 = byte.MaxValue;
		Console.WriteLine(num0);
		
		int num1 = int.MaxValue;
		Console.WriteLine(num1);
		
		uint num11 = uint.MaxValue;
		Console.WriteLine(num11);
		num11 = 2;
		Console.WriteLine(num11);
		
		long num2 = long.MaxValue;
		Console.WriteLine(num2);
		
		ulong num3 = ulong.MaxValue;
		Console.WriteLine(num3);
		
		
		
		Program p1 = new Program(); // Creating an object of a class named Program.
		p1.number = 20;
		
		Program p2 = new Program(); // Creating an object of a class named Program.
		p2.number = 100;
		
		Console.WriteLine(p1.number);
		Console.WriteLine(p2.number);
	}		
}

