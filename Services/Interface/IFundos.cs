using ApiClienteEasy.Models.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiClienteEasy.Services
{
    public interface IFundos
    {
        Task<List<Fundos>> GetFundos(int ClientId);

        //Get FUNDOS 
    }
}
