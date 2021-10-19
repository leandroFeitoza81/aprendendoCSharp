using System;

namespace _9_Escopo
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Executando projeto 9 - Escopo");

			int idade = 20;
			bool acompanhado = false;
			string mensagem;

			if (acompanhado == true)
			{
				mensagem = "Seja bem vindo";
			}
			else
			{
				mensagem = "Não pode entrar!";
			}


			if (idade >= 18 && acompanhado)
			{
				Console.WriteLine("Pode entrar");
				Console.WriteLine(mensagem);
			}
			else
			{
				Console.WriteLine(mensagem);
			}
		}
	}
}
