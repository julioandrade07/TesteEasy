using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiClienteEasy.Models.Data
{
    public class Investimento
    {

        public Investimento(RendaFixa investimento) {

            Nome = investimento.nome;
        
        }

        public Investimento(TesouroDireto investimento)
        {
            Nome = investimento.nome;

        }

        public Investimento(Fundos investimento)
        {
            Nome = investimento.nome;

        }

        public string Nome { get; set; }
        public decimal ValorInvestido { get; set; }
        public decimal ValorTotal { get; set; }
        public DateTime Vencimento { get; set; }
        public decimal Ir { get; set; } 
        public decimal ValorResgate { get; set; }


    }
}
