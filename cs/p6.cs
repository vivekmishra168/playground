using System;

public class Program
{
	public static void Main(string[] args)
	{
		System.Console.WriteLine("Hello ...");
		string msg = Greeting.SayHello();
		System.Console.WriteLine(msg);
		
		int a = System.Convert.ToInt32(args[0]);
		int b = System.Convert.ToInt32(args[1]);
		
		System.Console.WriteLine(Calculator.Substract(a, b));
	}
}

public class Greeting
{
	public static string SayHello()
	{
		return Calculator.Add().ToString();
	}
}

public static class Calculator
{
	public static int Add()
	{
		return 25 + 10;
	}
	
	public static int Substract(int a, int b)
	{
		return a - b;
	}
}
