namespace ByteBank.Funcionarios
{
    public class Diretor : Funcionario
    {

        public Diretor(double salario, string cpf) : base(salario, cpf)
        {
            System.Console.WriteLine("Criando Diretor");
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }
        public override double GetBonificacao()
        {
            return Salario + base.GetBonificacao();
        }
    }
}
