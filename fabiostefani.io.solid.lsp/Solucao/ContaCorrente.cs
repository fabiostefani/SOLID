using System;

namespace fabiostefani.io.solid.lsp.Solucao
{
    public class ContaCorrente : ContaRentavel
    {
        const decimal Juros = 0.006m;
        public override void Render()
        {
            Saldo = (ObterSaldo() * Juros) + ObterSaldo();
        }
    }
}