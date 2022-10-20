using System;
namespace p51
{
	public class program
	{
		public static void Main()
		{
			int num, factorial;
			Console.WriteLine ("Please enter number");
			num= Convert.ToInt32(Console.RealLine());
			factorial = Calfactorial (num);
			Console.WriteLine("Factorial no" + factorial);
			Console.ReadLine();
			{
				static int Calfactorial (int num)
				{
					if (num <=1)
					{
						return 1;
					}
					else
					{
						return num * Calfactorial (num-1);
						{
							static int Calfactorial(int num)
							{
								if (num <=1)
									return 1;
								return num * Calfactorial (num - d);
							}
						}
					}
				}
			}
		}
	}
}