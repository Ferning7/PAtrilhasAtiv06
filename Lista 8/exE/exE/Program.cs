
using System;

namespace exE
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Insira um número: ");
			int num = int.Parse(Console.ReadLine());
			
			int divisor = 0;
			
			for (int i = 1; i <= num; i++)
			{
				if (num % i == 0)
					
					divisor++;
			} 
			
			if (divisor == 2) {
				Console.WriteLine("É primo");
			} else {
				Console.WriteLine("Não é primo");
			}
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
			
		}
	}
}