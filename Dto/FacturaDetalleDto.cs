namespace ExamenApi
{
    public class FacturaDetalleDto
    {
        public string? NombreCliente { get; set; }
        public string? Folio { get; set; }
        public decimal Cantidad { get; set; }
        public string? FechaRegistro { get; set; }
        public string? Concepto { get; set; }

    }

}