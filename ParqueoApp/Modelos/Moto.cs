using System;

namespace ParqueoApp.Modelos
{
    public class Moto : Vehiculo
    {
        private const decimal TarifaPorHora = 500m;

        public Moto()
        {
            Tipo = "Moto";
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