using Xunit;

namespace fabiostefani.io.solid.lsp.Violacao
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