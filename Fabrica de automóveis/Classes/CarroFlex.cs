using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrica_de_automóveis.Classes
{
    class CarroFlex : Carro
    {
        public int NumeroPortas { get; set; }
        public int Cilindrada { get; set; }

        public override decimal CalcularImposto()
        {
            return CustoProducao * 0.2m; // imposto padrão de 20%
        }
    }
}
