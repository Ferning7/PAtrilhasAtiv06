
using System;

namespace exC
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			double[] numeros = {5.2, 6.5, 8.6, 3.2, 1.9};
			double media = 0;
			double soma = 0;
			
			for (int i = 0; i < numeros.Length; i++) {
				Console.WriteLine(numeros[i]);
				soma += numeros[i];
				
			}
			media = soma /numeros.Length;
			Console.WriteLine("A media é: {0}", media);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}