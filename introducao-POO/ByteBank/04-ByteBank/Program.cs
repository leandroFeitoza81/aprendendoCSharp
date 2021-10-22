using System;

namespace _04_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mensagemPositivo = "Saque efetuado! Saldo atual é: ";
            string mensagemNegativo = "Saque NÃO efetuado! Saldo atual é: ";

            ContaCorrente ContaDoJoao = new ContaCorrente();

            Console.WriteLine(ContaDoJoao.saldo);
            bool resultadoDoSaque = ContaDoJoao.Sacar(500);
            if (resultadoDoSaque)
            {
                Console.WriteLine(mensagemPositivo + ContaDoJoao.saldo); 
            }
            else
            {
                Console.WriteLine(mensagemNegativo + ContaDoJoao.saldo);
            }

            Console.WriteLine(ContaDoJoao.saldo);
            ContaDoJoao.Depositar(150);
            Console.WriteLine(ContaDoJoao.saldo);

            ContaCorrente contadaMaria = new ContaCorrente();
            Console.WriteLine(contadaMaria.saldo);

            ContaDoJoao.Depositar(1000);
            ContaDoJoao.Transferir(800, contadaMaria);

            contadaMaria.Sacar(700);

            Console.WriteLine("Saldo do Joao " + ContaDoJoao.saldo);
            Console.WriteLine("Saldo da Maria " + contadaMaria.saldo);
        }
    }
}
