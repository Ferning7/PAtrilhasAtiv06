
using System;

namespace exG
{
	class Program
	{
		public static void Main(string[] args)
		{
			int j;
			for (int i = 5; i <= 10 ; i++) {
				Console.WriteLine("\n------------- TABUADA DO {0} -------------", i);
				for (j = 1; j <= 10 ; j++) {
					Console.WriteLine("{0} x {1} = {2}", i, j, i * j);
				}
				
			}
			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}