using System;

namespace LacoForMultiploDeTres
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Executando o projeto - Multiplo de 3 usando for");

			for (int contador = 0; contador <= 100; contador +=3)
			{
				Console.WriteLine(contador);
			}
		}
	}
}
