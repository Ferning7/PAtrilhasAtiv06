
using System;

namespace exB
{
	class Program
	{
		public static void Main(string[] args)
		{
			string[] nomes = new string[6];
			double[,] notas = new double [6, 2];
			double [] medias = new double[6];
			
			
			for (int i = 1; i < nomes.Length; i++) {
				Console.WriteLine("\nDigite o nome do {0}° aluno(a): ", i);
				nomes[i] = Console.ReadLine();
				
				Console.WriteLine("Digite a 1° nota de {0}: ", nomes[i]);
				notas [i, 0] = int.Parse(Console.ReadLine());
				Console.WriteLine("Digite a 2° nota de {0}: ", nomes[i]);
				notas [i, 1] = int.Parse(Console.ReadLine());
				
				
				medias[i] = (notas[i, 0] + notas[i, 1])/2;	
			}
			
			for (int i = 1; i < nomes.Length; i++) {
				Console.WriteLine("\nAluno: {0} \nNota 1: {1} \nNota 2: {2} \nMedia: {3}", nomes[i], notas[i, 0], notas[i, 1], medias[i]);
			}
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}