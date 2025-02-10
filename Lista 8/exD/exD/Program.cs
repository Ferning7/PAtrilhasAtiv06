
using System;

namespace exD
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Digite um número inteiro: ");
			int num = int.Parse(Console.ReadLine());
			
			int soma = 0;
			
			for (int i = 1; i <= num; i++) {
				
				soma += i;
				
			}
			Console.WriteLine("A soma será: {0} ", soma);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}