using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrica_de_automóveis.Classes
{
    class CarroEletrico : Carro
    {
        public decimal Potencia { get; set; }
        public decimal DuracaoBateria { get; set; }

        public override decimal CalcularImposto()
        {
            return CustoProducao * 0.1m; // imposto de 10% para carros elétricos
        }
    }
}
