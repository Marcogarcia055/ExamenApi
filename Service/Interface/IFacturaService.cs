namespace ExamenApi.Service
{
    public interface IFacturaService
    {
        Task<IEnumerable<Factura>> GetAllAsync();
        Task<IEnumerable<FacturaDetalleDto>> GetByFecha(FacturaFechaDto fechaDto);
        Task<int> AddAsync(Factura factura);

    }
}