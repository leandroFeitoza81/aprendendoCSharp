using System;

namespace _07_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(800, 123456);

            conta.Agencia = 0;

            Console.WriteLine(conta.Agencia);
        }
    }
}
