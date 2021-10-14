using System;
using Xunit;

namespace fabiostefani.io.solid.lsp.Solucao
{
    public class ContaInvestimentoTests
    {
        [Fact]
        public void Depositar_DeveAdicionarValorAoSaldo()
        {
            var conta = new ContaInvestimento();
            conta.Depositar(10);
            Assert.Equal(10, conta.ObterSaldo());
        }

        [Fact]
        public void Sacar_DeveRetirarOValorDoSaldo()
        {
            var conta = new ContaInvestimento();
            conta.Depositar(10);
            conta.Sacar(5);
            Assert.Equal(5, conta.ObterSaldo());
        }

        [Fact]
        public void Sacar_DeveGerarExcecaoQuandoSaldoIndisponivel()
        {
            var conta = new ContaInvestimento();
            conta.Depositar(10);
            Assert.Throws<Exception>(() => conta.Sacar(15));
        }

        [Fact]
        public void Render_DeveAdicionarAoSaldoORendimento()
        {
            var conta = new ContaInvestimento();
            conta.Depositar(1000);
            conta.Render();
            Assert.Equal(1010, conta.ObterSaldo());
        }
    }
}