using System;

namespace Examples
{

    public abstract class Conta
    {
        public int Numero { get; private set; }
        public int Agencia { get; private set; }

        public Conta(int numero, int agencia)
        {
            Numero = numero;
            Agencia = agencia;
        }
    }

    public class ContaCorrente : Conta
    {
        public ContaCorrente(int numero, int agencia) : base(numero, agencia)
        {
        }
    }
    public class Program
    {
        static void Main() => Hello();
        public static void Hello()
        {
            int x = 50;

            if(x > 100)
                Console.WriteLine("x maior que 100");
            Console.WriteLine("Não é maior que 100");
        }
    }

}
