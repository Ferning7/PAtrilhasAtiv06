
using System;

namespace exB
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Insira um número: ");
			int num = int.Parse(Console.ReadLine());
			
			
			for (int i = 0; i <= num; i++) {
				if (i % 2 == 0) {
					Console.Write("{0} , ", i);
				}
			}
			
			
			Console.Write("\nPress any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}