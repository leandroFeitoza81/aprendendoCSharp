using System;

namespace LacoDeRepeticaoWhile
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Executando projeto Laço de repetição while");

			int contador = 0;

			while (contador < 10)
			{
				Console.WriteLine("O valor do contador é " + contador);
				contador++;
			}
		}
	}
}
