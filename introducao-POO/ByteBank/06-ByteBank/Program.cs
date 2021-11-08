using System;

namespace _06_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            Cliente cliente = new Cliente();

            cliente.Nome = "Leandro";
            cliente.CPF = "123465798-11";
            cliente.Profissao = "Piloto";

            //cliente._titular = "jose";

            conta.Saldo = -20;
            Console.WriteLine(conta.Saldo);

            Console.WriteLine(cliente.Nome);


        }
    }
}
