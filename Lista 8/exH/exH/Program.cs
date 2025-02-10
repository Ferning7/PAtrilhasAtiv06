
using System;

namespace exH
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Insira um número inteiro positivo: ");
			int num = int.Parse(Console.ReadLine());
			
			for (int i = 1; i < num; i++) {
				
				if (num % i == 0) {	
					Console.WriteLine(i);
				}	
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}