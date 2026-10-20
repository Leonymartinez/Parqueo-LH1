namespace ParqueoApp.Modelos
{
    public abstract class Vehiculo
    {
        public int IdVehiculo { get; set; }
        public string Placa { get; set; } = string.Empty;
        public string Tipo { get; set; } = string.Empty;
        public string Marca { get; set; } = string.Empty;
        public string Color { get; set; } = string.Empty;
        public int IdCliente { get; set; }

        public abstract decimal CalcularPago(decimal horas);
    }
}
