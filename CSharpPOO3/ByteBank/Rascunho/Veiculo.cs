namespace Rascunho
{
    public class Veiculo
    {
        private string tipo;

        public string Tipo { get; set; }

        public Veiculo(string tipoVeiculo)
        {
            tipo = tipoVeiculo;
        }

        public virtual void Mover() { }
        public virtual void Parar() { }
    }
}
