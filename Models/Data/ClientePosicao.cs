using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiClienteEasy.Models.Data
{
    public class ClientePosicao
    {
        public ClientePosicao() {

            Investimentos = new List<Investimento>();
        }

        public decimal ValorTotal { get { return Investimentos.Sum(x => x.ValorTotal); }}

        public List<Investimento> Investimentos { get; set; }

    }
}
