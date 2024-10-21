using System.Data;
using Dapper;
using ExamenApi.Repositories;
using Microsoft.Data.SqlClient;

namespace ExamenApi
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;

        public ClienteRepository(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("DefaultConnection");
        }
        public async Task<IEnumerable<Cliente>> GetAllAsync()
        {
            using var connection = new SqlConnection(_connectionString);
            return await connection.QueryAsync<Cliente>("spGetAllCliente",
            commandType: CommandType.StoredProcedure);
        }
    }
}