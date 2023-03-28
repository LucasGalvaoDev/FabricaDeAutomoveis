using Fabrica_de_automóveis.Classes;
using System;

namespace Fabrica_de_automóveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("##BEM VINDO A FÁBRICA DE AUTOMÓVEIS##");

            CarroFlex carroFlex = new CarroFlex
            {
                NumeroChassi = "156156",
                NumeroMotor = "ABC123",
                Cilindrada = 2500,
                NumeroPortas = 4,
                CustoProducao = 40000
            };

            decimal custoVendaFlex = carroFlex.CalcularCustoVenda();

            Console.WriteLine($"O custo de venda de um carro flex nas condições abaixo é: R${custoVendaFlex}");
            Console.WriteLine($"Numero do Chassi: {carroFlex.NumeroChassi}");
            Console.WriteLine($"Numero do Motor: {carroFlex.NumeroMotor}");
            Console.WriteLine($"Volume da Cacamba: {carroFlex.Cilindrada}");
            Console.WriteLine($"Custo de Produção: {carroFlex.NumeroPortas}");
            Console.WriteLine($"Custo de Produção: {carroFlex.CustoProducao}");

            Console.WriteLine();


            CarroDiesel carroDiesel = new CarroDiesel
            {
                NumeroChassi = "655987",
                NumeroMotor = "DEF456",
                CapacidadeCarga = 1200,
                VolumeCacamba = 10,
                CustoProducao = 100000
            };

            decimal custoVendaDiesel = carroDiesel.CalcularCustoVenda();

            Console.WriteLine($"O custo de venda de um carro dízel nas condições abaixo é: R${custoVendaDiesel}");
            Console.WriteLine($"Numero do Chassi: {carroDiesel.NumeroChassi}");
            Console.WriteLine($"Numero do Motor: {carroDiesel.NumeroMotor}");
            Console.WriteLine($"Capacidade de Carga: {carroDiesel.CapacidadeCarga}");
            Console.WriteLine($"Volume da Cacamba: {carroDiesel.VolumeCacamba}");
            Console.WriteLine($"Custo de Produção: {carroDiesel.CustoProducao}");
        }
    }
}
