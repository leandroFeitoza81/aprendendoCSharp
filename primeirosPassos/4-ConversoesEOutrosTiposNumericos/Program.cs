using System;

namespace _4_ConversoesEOutrosTiposNumericos
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Executando o projeto 4");

			double salario = 1200.50;

			int salarioEmInteiro = (int)salario; // Converterdouble para inteiro tem que fazer cast.
			Console.WriteLine(salarioEmInteiro);

			float altura = 1.75f; // para o tipo float deve haver um sufixo f -
			Console.WriteLine(altura);

			long idadeDouniverso = 13000000000; // long suporta numeros de 64bits
			Console.WriteLine(idadeDouniverso);

			short quantidade = 15000; // short suporta numeros de 16bits
			Console.WriteLine(quantidade);
			
		}
	}
}
