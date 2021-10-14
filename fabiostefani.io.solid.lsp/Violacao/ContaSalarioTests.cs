using System;
using Xunit;

namespace fabiostefani.io.solid.lsp.Violacao
{
    public class ContaSalarioTests
    {
        [Fact]
        public void Depositar_DeveAdicionarValorAoSaldo()
        {
            var conta = new ContaSalario();
            conta.Depositar(10);
            Assert.Equal(10, conta.ObterSaldo());
        }

        [Fact]
        public void Sacar_DeveRetirarOValorDoSaldo()
        {
            var conta = new ContaSalario();
            conta.Depositar(10);
            conta.Sacar(5);
            Assert.Equal(5, conta.ObterSaldo());
        }

        [Fact]
        public void Sacar_DeveGerarExcecaoQuandoSaldoIndisponivel()
        {
            var conta = new ContaSalario();
            conta.Depositar(10);
            Assert.Throws<Exception>(() => conta.Sacar(15));
        }

        [Fact]
        public void Render_DeveGerarExcecao()
        {
            var conta = new ContaSalario();
            conta.Depositar(1000);
            Assert.Throws<Exception>(() => conta.Render());            
        }
    }
}