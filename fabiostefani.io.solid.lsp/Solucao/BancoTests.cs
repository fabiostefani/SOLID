using Xunit;

namespace fabiostefani.io.solid.lsp.Solucao
{
    public class BancoTests
    {
        [Fact]
        public void CalcularRendimentos_DeveCalcularRendimentosDasContas()
        {
            var investimentos = new Banco();
            investimentos.CalcularRendimentos();            
        }
    }
}