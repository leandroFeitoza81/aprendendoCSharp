using System;

namespace p10_CalculaPoupanca
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Executando projeto 10 - laço while");

			double valorInvestido = 1000;
			double taxaDeJuros = 0.0036;
			int contadorMes = 1;

			while (contadorMes <= 12)
			{
				valorInvestido += valorInvestido * taxaDeJuros;
				Console.WriteLine($"Após {contadorMes} meses, você terá R${valorInvestido}");
				contadorMes++;
			}
		}
	}
}
