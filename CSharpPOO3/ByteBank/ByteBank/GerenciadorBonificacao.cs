using ByteBank.Funcionarios;

namespace ByteBank
{
    public class GerenciadorBonificacao
    {
        private double _totalBonificacao;
        public void Registrar(Funcionario funcionario)
        {
            _totalBonificacao += funcionario.GetBonificacao();
        }

        public double GetTotalBoinificacao()
        {
            return _totalBonificacao;
        }
    }
}
