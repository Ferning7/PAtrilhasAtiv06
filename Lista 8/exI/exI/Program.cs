
using System;

namespace exI
{
	class Program
	{
		public static void Main(string[] args)
		{
			int numPrimos = 0;
			int j = 0;
			for (int i = 2; i <= 100; i++) {
				
				for (j = 1; j <= i; j++) {
					
					if (i % j == 0 || i % j == i) {
						numPrimos++;
					}
				}
				
				if (numPrimos > 2) {
					Console.WriteLine("{0} Não é primo", i);
				} else {
					Console.WriteLine("{0} é primo", i);
				}
				numPrimos = 0;
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}