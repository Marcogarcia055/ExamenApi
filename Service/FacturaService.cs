using ExamenApi.Repositories;

namespace ExamenApi.Service{
    public class FacturaService : IFacturaService{

        private readonly IFacturaRepository _facturaRepository;
        public FacturaService(IFacturaRepository facturaRepository){
            _facturaRepository = facturaRepository;
        }

        public async Task<int> AddAsync(Factura factura)
        {
            return await _facturaRepository.AddAsync(factura);
        }

        public async Task<IEnumerable<Factura>> GetAllAsync()
        {
            return await _facturaRepository.GetAllAsync();
        }

        public async Task<IEnumerable<FacturaDetalleDto>> GetByFecha(FacturaFechaDto fechaDto)
        {
            return await _facturaRepository.GetByFecha(fechaDto);
        }
    }
}