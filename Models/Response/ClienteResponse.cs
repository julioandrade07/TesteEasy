using ApiClienteEasy.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiClienteEasy.Models.Response
{
    public class ClienteResponse
    {

        public decimal ValorTotal { get; set; }

        public List<Investimento> Investimentos { get; set; }

      

    }
}
