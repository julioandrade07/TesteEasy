using ApiClienteEasy.Models.Data;

namespace ApiClienteEasy.Services
{
    public interface ICliente
    {
        ClientePosicao GetCliente(int ClientId);
    }
}
