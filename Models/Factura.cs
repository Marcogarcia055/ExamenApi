namespace ExamenApi
{
    public class Factura
    {
        public int IdFactura { get; set; }
        public string? Folio { get; set; }
        public int IdCliente { get; set; }
        public string? FechaRegistro { get; set; }
        public string? Concepto { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Total { get; set; }
    }

}