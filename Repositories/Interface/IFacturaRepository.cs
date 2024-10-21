namespace ExamenApi.Repositories
{
    public interface IFacturaRepository
    {
        Task<IEnumerable<Factura>> GetAllAsync();
        Task<IEnumerable<FacturaDetalleDto>> GetByFecha(FacturaFechaDto fechaDto);
        Task<int> AddAsync(Factura factura);

    }
}