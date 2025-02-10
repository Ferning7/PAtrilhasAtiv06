
using System;

namespace exC
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Digite uma palavra: ");
			string palavra = Console.ReadLine();
			
			
			Console.WriteLine(" ");
			for (int i = 0; i < palavra.Length ; i++) {
				
				Console.WriteLine(palavra[i]);
				
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}