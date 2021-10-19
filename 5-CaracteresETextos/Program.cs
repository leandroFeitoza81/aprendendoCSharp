using System;

namespace _5_CaracteresETextos
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Executando o projeto 5 - Caracteres e Textos.");

			char primeiraLetra = 'a'; // char um unico caractere - se usa aspa simples
			Console.WriteLine(primeiraLetra);

			primeiraLetra = (char)65;
			Console.WriteLine(primeiraLetra);

			primeiraLetra = (char)(primeiraLetra + 1);
			Console.WriteLine(primeiraLetra);

			string titulo = "Aprendendo C# na Alura " + 2021;

			Console.WriteLine(titulo);
		}
	}
}
