namespace ExamenApi.Service
{
    public interface IClienteService
    {
        Task<IEnumerable<Cliente>> GetAllAsync();
    }
}