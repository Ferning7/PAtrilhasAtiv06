/*
 * Criado por SharpDevelop.
 * Usuário: Kenia Teixeira
 * Data: 10/02/2025
 * Hora: 10:48
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;

namespace exJ
{
	class Program
	{
		public static void Main(string[] args)
		{
			int soma = 0;
			
			for (int i = 1; i <= 100; i++) {
				if (i % 2 == 0) {
					soma += i;
				}
			}
			Console.WriteLine(soma);
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}