using ApiClienteEasy.Models.Data;
using System.Threading.Tasks;

namespace ApiClienteEasy.Services
{
    public interface ICliente
    {
        Task<ClientePosicao> GetCliente(int ClientId);
    }
}
