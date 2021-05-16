using ApiClienteEasy.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiClienteEasy.Models.Response
{
    public class ClienteResponse
    {

        public ClienteResponse(ClientePosicao clientePosicao) {

            this.Investimentos = clientePosicao.Investimentos;
            this.ValorTotal = clientePosicao.ValorTotal;
        }

        public decimal ValorTotal { get; set; }

        public List<Investimento> Investimentos { get; set; }

      

    }
}
