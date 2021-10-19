using System;

namespace p13_ForEncadeado
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Executandio o projeto 13");

			// Usando o break para desenhar os asteriscos
			for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
			{
				for (int contadorColuna = 0; contadorColuna < 10; contadorColuna++)
				{
					Console.Write("*");
					if (contadorColuna >= contadorLinha)
						break;
				}
				Console.WriteLine();
			}

			Console.WriteLine("==============================");
			Console.WriteLine("Sem o break");

			for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
			{
				for (int contadorColuna = 0; contadorColuna <= contadorLinha; contadorColuna++)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}
		}
	}
}
