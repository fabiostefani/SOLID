using System;

namespace fabiostefani.io.solid.lsp.Solucao
{
    public class ContaInvestimento : ContaRentavel
    {
        const decimal Juros = 0.01m;
        public override void Render()
        {
            Saldo = (ObterSaldo() * Juros) + ObterSaldo();
        }
    }
}