
using System;

namespace exA
{
	class Program
	{
		public static void Main(string[] args)
		{
			int[] inteiros = {2, 4, 6, 8, 10, 12};
			
			for (int i = 0; i < inteiros.Length; i++) {
				Console.WriteLine(inteiros[i]);
			}
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}