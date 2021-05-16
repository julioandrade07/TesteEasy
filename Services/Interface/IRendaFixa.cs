using ApiClienteEasy.Models.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiClienteEasy.Services
{
    public interface IRendaFixa
    {
        Task<List<RendaFixa>> GetRendaFixa(int ClientId);

    }
}
