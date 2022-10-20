using System;

public class Program
{
	public static void Main(string[] args)
	{
		if(args.Length >= 3)
		{
			int a = System.Convert.ToInt32(args[0]);
			int b = System.Convert.ToInt32(args[2]);
			
			Console.WriteLine(Calculator.Add(a, b));
			Console.WriteLine(Calculator.Substract(a, b));
			Console.WriteLine(Calculator.Multiply(a, b));
			Console.WriteLine(Calculator.Divide(a, b));
			Console.WriteLine(Calculator.Percent(a, b));
		}
		else
		{
			Console.WriteLine("By Manish! Minimum 3 arguments needed.");
		}
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
		return (float)a / (float)b;
	}
	public static int Percent(int a, int b)
	{
		return a % b;
	}
}
