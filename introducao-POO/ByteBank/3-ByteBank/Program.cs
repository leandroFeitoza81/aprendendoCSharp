using System;

namespace _3_ByteBank
{
	class Program
	{
		static void Main(string[] args)
		{
			ContaCorrente contaDoJoao = new ContaCorrente();
			contaDoJoao.titular = "Joao";
			contaDoJoao.agencia = 3084;
			contaDoJoao.numero = 123456;
			contaDoJoao.saldo = 200;

			ContaCorrente contaDaMaria = new ContaCorrente();
			contaDaMaria.titular = "Joao";
			contaDaMaria.agencia = 3084;
			contaDaMaria.numero = 123456;
			contaDaMaria.saldo = 200;

			Console.WriteLine("Igualdade de tipo de referencia");
			Console.WriteLine(contaDoJoao == contaDaMaria);

			Console.WriteLine("Igualdade de tipo de valor ");
			int idade = 40;
			int idade2 = 40;
			Console.WriteLine(idade == idade2);
		}
	}
}
