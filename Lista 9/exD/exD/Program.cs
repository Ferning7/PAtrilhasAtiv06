
using System;

namespace exD
{
	class Program
	{
		public static void Main(string[] args)
		{
			int maior = 0;
			
			int[] numeros = {4, 2, 8, 10, 15, 7};
			for (int i = 0; i < numeros.Length; i++) {
				Console.Write("{0}, ",numeros[i]);
				
				
				if (numeros[i] > maior) {
					maior = numeros[i];
				}
			}
			Console.WriteLine("\nO maior é: {0}",maior);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}