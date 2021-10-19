using System;

namespace LacoForAninhado
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Executando o projeto - Calculadora de Multiplicação com Laço For aninhado");
			Console.WriteLine();

			for (int multiplicador = 1; multiplicador <= 10; multiplicador ++)
			{
				Console.WriteLine("Tabuada do " + multiplicador);
				Console.WriteLine();
				for (int contador = 0; contador <= 10; contador ++)
				{
					Console.WriteLine(multiplicador + " * " + contador + " = " + multiplicador * contador);
				}
				Console.WriteLine();
			}
		}
	}
}
