using System;

namespace _01_ByteBank
{
	class Program
	{
		static void Main(string[] args)
		{
			ContaCorrente contaDaMaria = new ContaCorrente();

			contaDaMaria.titular = "Maria";
			contaDaMaria.agencia = 3084;
			contaDaMaria.numero = 12346;
			contaDaMaria.saldo = 1000;
		}
	}
}
