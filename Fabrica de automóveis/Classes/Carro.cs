using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrica_de_automóveis
{
    class Carro
    {
        public string NumeroChassi { get; set; }
        public string NumeroMotor { get; set; }
        public decimal CustoProducao { get; set; }

        public virtual decimal CalcularImposto()
        {
            return CustoProducao * 0.2m; // imposto padrão de 20%
        }

        public decimal CalcularCustoVenda()
        {
            decimal imposto = CalcularImposto();
            decimal lucro = CustoProducao * 0.25m; // lucro de 25%
            return CustoProducao + imposto + lucro;
        }
    }
}
