using System.Collections.Generic;

namespace fabiostefani.io.solid.lsp.Violacao
{
    public class Banco
    {
        public List<Conta> Contas { get; set; }
        public Banco()
        {
            Contas = new List<Conta>()
            {
                new ContaCorrente(),
                new ContaSalario()
            };
        }

        public void CalcularRendimentos()
        {
            Contas.ForEach(x => 
            {
                if (x is ContaCorrente) 
                {
                    x.Render();
                }                
            });
        }
    }
}