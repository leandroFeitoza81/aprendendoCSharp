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
        }
    }
}
