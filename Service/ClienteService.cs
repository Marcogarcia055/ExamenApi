using ExamenApi.Repositories;
using ExamenApi.Service;

namespace ExamenApi.Service{
    public class ClienteService : IClienteService{

        private readonly IClienteRepository _clienteRepository;
        public ClienteService(IClienteRepository clienteRepository){
            _clienteRepository = clienteRepository;
        }

        public async Task<IEnumerable<Cliente>> GetAllAsync()
        {
            return await _clienteRepository.GetAllAsync();
        }
    }
}