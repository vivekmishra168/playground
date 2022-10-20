using System;

public class Program
{
	public static void Main(string[] args)
	{
		if(args.Length < 3)
		{
			Console.WriteLine("By Manish! Minimum 3 arguments needed.");
			return;
		}
		
		int a = 0;
		if(args[0] == "1k")
			a = 1000;
		else
			int.TryParse(args[0], out a);
		
		int.TryParse(args[2], out int b);
		if(b == 0)
		{
			Console.WriteLine("Warning! 3rd argument cannot be zero or a sting.");
			return;
		}
		
		Console.WriteLine(Calculator.Add(a, b));
		Console.WriteLine(Calculator.Substract(a, b));
		Console.WriteLine(Calculator.Multiply(a, b));
		Console.WriteLine(Calculator.Divide(a, b));
		Console.WriteLine(Calculator.Percent(a, b));
	}		
}

public static class Calculator
{
	public static int Add(int a, int b)
	{
		return a + b;
	}
	
	public static int Substract(int a, int b)
	{
		return a - b;
	}
	
	public static int Multiply(int a, int b)
	{
		return a * b;
	}
	public static float Divide(int a, int b)
	{
		if(b == 0)
			return -1;
		return (float)a / (float)b;
	}
	public static int Percent(int a, int b)
	{
		if(b == 0)
			return -1;
		return a % b;
	}
}
