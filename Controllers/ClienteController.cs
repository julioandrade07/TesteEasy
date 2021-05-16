using ApiClienteEasy.Models.Response;
using ApiClienteEasy.Services;
using Microsoft.AspNetCore.Mvc;
using WebApi.OutputCache.V2;

namespace WebApplication5.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        private ICliente _repository;
        private IFundos _repositoryFundos;

        public ClienteController(ICliente repository, IFundos repositoryFundos)
        {
            _repository = repository;
            _repositoryFundos = repositoryFundos;

        }

        [CacheOutput(ServerTimeSpan = 86400)]
        [HttpPost]
        public ClienteResponse Consultar(int clientId)
        {
            var item = _repository.GetCliente(clientId);
            return new ClienteResponse(item);
        }
    }
}
