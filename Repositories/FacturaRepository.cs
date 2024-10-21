using System.Data;
using Dapper;
using ExamenApi.Repositories;
using Microsoft.Data.SqlClient;

namespace ExamenApi
{
    public class FacturaRepository : IFacturaRepository
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;

        public FacturaRepository(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("DefaultConnection");
        }

        public async Task<int> AddAsync(Factura factura)
        {
            using var connection = new SqlConnection(_connectionString);
            return await connection.ExecuteAsync("spAddFactura",
            new
            {
                factura.Folio,
                factura.IdCliente,
                factura.FechaRegistro,
                factura.Concepto,
                factura.Cantidad,
                factura.Total
            },
            commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<Factura>> GetAllAsync()
        {
            using var connection = new SqlConnection(_connectionString);
            return await connection.QueryAsync<Factura>("spGetAllFactura",
            commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<FacturaDetalleDto>> GetByFecha(FacturaFechaDto fechaDto)
        {
            using var connection = new SqlConnection(_connectionString);
            return await connection.QueryAsync<FacturaDetalleDto>("spGetFacturaByFecha",
            new { fechaDto.FechaInicio, fechaDto.FechaFin },
            commandType: CommandType.StoredProcedure);
        }
    }
}