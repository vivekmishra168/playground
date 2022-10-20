using System;

public class Program
{
	int number; // Class level variable
	// We have local variables in this case named num, num0, num1, and so on.
	public static void Main(string[] args)
	{
		byte centuris = 20;
		ushort years = 2000;
		uint days = 730480;
		ulong hours = 17531520;
		// print the results on the console
		Console.WriteLine (centuris + " centuris are " + years + " years, or " + days + " days, or " + hours + " hours ");
			
		ulong maxIntValue = UInt64.MaxValue;
		Console.WriteLine(maxIntValue);
		// real float-Point Types- Example
		float floatPI = 3.14f;
		Console.WriteLine(floatPI);
		double doublePI = 3.14;
		Console.WriteLine(doublePI);
		double nan = Double.NaN;
		Console.WriteLine(nan);
		double infinity = Double.PositiveInfinity;
		Console.WriteLine(infinity);
		//Declare some veriables
		float floatPII = 3.141592653589793238f;
		double doublePII = 3.141592653589793238;
		// Print the results on the console
		Console.WriteLine("Float PII is :" + floatPII);
		Console.WriteLine("Double PII is :" + doublePII);	
		float f = 0.1f;
		Console.WriteLine(f);
		double d = 0.1f;
		Console.WriteLine(d);
		float ff = 1.0f/3;
		Console.WriteLine(ff);
		double dd = ff;
		Console.WriteLine(dd);
		decimal decimalPI = 3.141592653589793284m;
		Console.WriteLine(decimalPI);	
	}	
}