using System;
using System.Linq;

namespace Mishraji
{
	public class Program
	{
		public static void Main()
		{
			string[] arr1 = { "aaa.frx", "bbb.TXT", "xyz.dbf","abc.pdf", "aaaa.PDF","xyz.frt", "abc.xml", "ccc.txt", "zzz.txt" };
			
			var exts = arr1.Select(s => s.Split('.')[1]).GroupBy(s => s);
			foreach(var s in exts)
			{
				Console.WriteLine($"Key: {s.Key}, Value: {s.Count()}");
			}
		}
	}
}