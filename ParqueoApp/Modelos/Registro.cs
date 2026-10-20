using System;

namespace ParqueoApp.Modelos
{
    public class Registro
    {
        public int IdRegistro { get; set; }
        public int IdVehiculo { get; set; }
        public int IdEspacio { get; set; }
        public DateTime HoraEntrada { get; set; }
        public DateTime? HoraSalida { get; set; }
        public decimal? MontoPagado { get; set; }
    }
}