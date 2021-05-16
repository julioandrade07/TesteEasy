using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiClienteEasy.Models.Data
{
    public class ClientePosicao
    {
        public ClientePosicao() { 
        
        
        }

        public ClientePosicao(List<Fundos> fundos, List<TesouroDireto> tesouroDireto, List<RendaFixa> rendaFixa)
        {
            ValorTotal = 120;


        }


        public decimal ValorTotal { get; set; }

        public List<Investimento> Investimentos { get; set; }

    }
}
