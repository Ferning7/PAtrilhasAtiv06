
using System;

namespace exF
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Quantos números deseja inserir: ");
			int qntNum = int.Parse(Console.ReadLine());
			
			Console.WriteLine(" ");
			
			int num = 0;
			int maior = 0;
			
			for (int i = 0; i < qntNum ; i++) {
				num = int.Parse(Console.ReadLine());
				if (num > maior) {
					maior = num;
				}
			}

			Console.WriteLine(maior);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}