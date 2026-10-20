namespace ParqueoApp.Modelos
{
    public class Espacio
    {
        public int IdEspacio { get; set; }
        public int Numero { get; set; }
        public string TipoVehiculo { get; set; } = string.Empty;
        public string Estado { get; set; } = "Disponible";
    }
}
