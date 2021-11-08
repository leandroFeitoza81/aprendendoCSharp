using System;
using System.Collections.Generic;
using System.Text;

namespace Rascunho
{
    public class Aeronave : Veiculo 
    {
        public Aeronave(string tipoVeiculo) : base(tipoVeiculo)
        { }

        public override void Mover()
        {
            Console.WriteLine("Decolando a aeronave.");
        }

        public override void Parar()
        {
            Console.WriteLine("Aterrisando a aeronave.");
        }
    }
}
