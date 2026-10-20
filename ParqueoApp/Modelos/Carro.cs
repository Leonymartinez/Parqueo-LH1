using System;

namespace ParqueoApp.Modelos
{
    public class Carro : Vehiculo
    {
        private const decimal TarifaPorHora = 1000m;

        public Carro()
        {
            Tipo = "Carro";
        }

        public override decimal CalcularPago(decimal horas)
        {
            if (horas <= 0)
            {
                return 0m;
            }

            return Math.Ceiling(horas) * TarifaPorHora;
        }
    }
}