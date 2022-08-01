using System;

namespace Challenge
{
	public class Program
	{
		public static void Main()
		{
			Console.WriteLine(SayHello("Vivek"));
			Console.WriteLine(SayHello(null));
		}
		
		public static string SayHello(string name) 
		{
			// You can print to STDOUT for debugging like you normally would:
			Console.WriteLine(name);
			
			// but you need to return the value in order to complete the challenge
			return "Hello" + (!string.IsNullOrEmpty(name)? $", {name}!" : " there!");
		}
	}
	
}