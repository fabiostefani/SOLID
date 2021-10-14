using System;
using Xunit;

namespace fabiostefani.io.solid.lsp.Solucao
{
    public class ContaCorrenteTests
    {
        [Fact]
        public void Depositar_DeveAdicionarValorAoSaldo()
        {
            var conta = new ContaCorrente();
            conta.Depositar(10);
            Assert.Equal(10, conta.ObterSaldo());
        }

        [Fact]
        public void Sacar_DeveRetirarOValorDoSaldo()
        {
            var conta = new ContaCorrente();
            conta.Depositar(10);
            conta.Sacar(5);
            Assert.Equal(5, conta.ObterSaldo());
        }

        [Fact]
        public void Sacar_DeveGerarExcecaoQuandoSaldoIndisponivel()
        {
            var conta = new ContaCorrente();
            conta.Depositar(10);
            Assert.Throws<Exception>(() => conta.Sacar(15));
        }

        [Fact]
        public void Render_DeveAdicionarAoSaldoORendimento()
        {
            var conta = new ContaCorrente();
            conta.Depositar(1000);
            conta.Render();
            Assert.Equal(1006, conta.ObterSaldo());
        }
    }
}