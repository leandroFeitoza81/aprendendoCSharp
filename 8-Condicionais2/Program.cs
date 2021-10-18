using System;

namespace _8_Condicionais2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Executando projeto 8 - Condicionais 2");

			int idade = 20;
			// int quantidadeDePessoas = 2;
			bool acompanhado = true;	
		

			if (idade >= 18 && acompanhado)
			{
				Console.WriteLine("Pode entrar");
				Console.WriteLine("Seja bem vindo!");
			}
			else
			{
				Console.WriteLine("Inelizemente você não pode entrar");
			}
		}
	}
}
