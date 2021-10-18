using System;

namespace _7_Condicionais
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Executando projeto 7 - Condicionais");

			int idade = 20;
			int quantidadeDePessoas = 2;

			if (idade >= 18)
			{
				Console.WriteLine("Idade maior que 18 anos");
				Console.WriteLine("Seja bem vindo!");
			}
			else
			{
				if (quantidadeDePessoas >= 2)
				{
					Console.WriteLine("Voc~e não posssui 18 anos, mas pode entrar, pois está acompanhado");
				}
				else
				{
					Console.WriteLine("Inelizemente você não pode entrar");
				}
			}
		}
	}
}
