using ApiClienteEasy.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiClienteEasy.Services
{
    public class ClienteRepositorio : ICliente
    {

        private FundosRepository _repositorioFundo { get; set; }
        private TesouroDiretoRepository _repositorioTesouroDireto { get; set; }
        private RendaFixaRepository _repositorioRendaFixa { get; set; }


        public ClienteRepositorio()
        {
            _repositorioFundo = new FundosRepository();

            _repositorioTesouroDireto = new TesouroDiretoRepository();

            _repositorioRendaFixa = new RendaFixaRepository();
        }


        public ClientePosicao GetCliente(int ClientId)
        {

          List<Task> s = new List<Task>();

          Task<List<Fundos>> z =  _repositorioFundo.GetFundos(ClientId);

          Task<List<TesouroDireto>> b =  _repositorioTesouroDireto.GetTesouro(ClientId);

          Task<List<RendaFixa>> r =  _repositorioRendaFixa.GetRendaFixa(ClientId);


            s.Add(z);

            Task.WhenAll(s);

         
            return new ClientePosicao(z.Result,b.Result,r.Result);
        
        }
    }
}
