 using ByteBank.Funcionarios;
using System;

namespace ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario carlos = new Funcionario(2000, "123.456.789-11");
            carlos.Nome = "Carlos";

            gerenciador.Registrar(carlos);          
            Console.WriteLine(Funcionario.TotalDeFuncionarios);

            carlos.AumentarSalario();
            Console.WriteLine($"Novo salário do Carlos {carlos.Salario}");

            Console.WriteLine("=============================");

            Diretor roberta = new Diretor(5000, "454.658.148-3");
            roberta.Nome = "Roberta";

            gerenciador.Registrar(roberta);
            Console.WriteLine(Funcionario.TotalDeFuncionarios);

            roberta.AumentarSalario();
            Console.WriteLine($"Novo salário da Roberta {roberta.Salario}");

            Console.WriteLine(roberta.Nome);
            Console.WriteLine(roberta.GetBonificacao());

            Console.WriteLine("Total de bonificações " + gerenciador.GetTotalBoinificacao());

        }
    }
}
