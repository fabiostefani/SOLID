using System.Collections.Generic;

namespace fabiostefani.io.solid.lsp.Solucao
{
    public class Banco
    {
        public List<ContaRentavel> Contas { get; set; }
        public Banco()
        {
            Contas = new List<ContaRentavel>()
            {
                new ContaCorrente(),
                new ContaInvestimento()          
            };
        }

        public void CalcularRendimentos()
        {
            Contas.ForEach(x => 
            {
                x.Render();                                
            });
        }
    }
}