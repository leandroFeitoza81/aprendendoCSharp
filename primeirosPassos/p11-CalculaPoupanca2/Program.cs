using System;

namespace p11_CalculaPoupanca2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Executando o projeto 11 - laço for");

			double valorInvestido = 1000;
			double taxaDeJuros = 0.0036;

			for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
			{
				valorInvestido += valorInvestido * taxaDeJuros;
				Console.WriteLine($"Após {contadorMes} meses, você terá R${valorInvestido}");
			}
		}
	}
}
