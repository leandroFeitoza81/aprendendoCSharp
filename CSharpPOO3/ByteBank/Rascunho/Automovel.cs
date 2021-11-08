using System;
using System.Collections.Generic;
using System.Text;

namespace Rascunho
{
    public class Automovel :  Veiculo
    {
        public Automovel(string tipoVeiculo) : base(tipoVeiculo)
        { }

        public override void Mover()
        {
            Console.WriteLine("Acelerando o veiculo.");
        }

        public override void Parar()
        {
            Console.WriteLine("Parando o Veiculo.");
        }
    }
}
