using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrica_de_automóveis.Classes
{
    class CarroDiesel : Carro
    {
        public decimal CapacidadeCarga { get; set; }
        public decimal VolumeCacamba { get; set; }

        public override decimal CalcularImposto()
        {
            return CustoProducao * 0.3m; // imposto de 30% para carros a diesel
        }
    }
}
