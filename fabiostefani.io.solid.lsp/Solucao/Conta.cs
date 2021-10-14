using System;

namespace fabiostefani.io.solid.lsp.Solucao
{
    public abstract class Conta
    {
        
        public decimal Saldo { get; set; }
        public Conta()
        {
            Saldo = 0;
        }
        public void Depositar(decimal valor)
        {
            Saldo += valor;
        }

        public void Sacar(decimal valor)
        {
            if (valor > ObterSaldo()) throw new Exception("Saldo insuficiente");            
            Saldo -= valor;
        }

        public decimal ObterSaldo()
        {
            return Saldo;
        }
    }
}