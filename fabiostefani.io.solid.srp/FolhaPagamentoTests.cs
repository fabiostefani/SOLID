using Xunit;

namespace fabiostefani.io.solid.srp
{
    public class FolhaPagamentoTests
    {
        [Fact]
        public void FolhaPagamento_DeveCalcularImposto()
        {
            var funcionario = new FuncionarioSolucao("Funcionario", 1000);
            var calculadoraImposto = new CalcularImpostoFuncionario(funcionario);
            var imposto = calculadoraImposto.Calcular();
            Assert.Equal(100, imposto);
        }

        [Fact]
        public void FolhaPagamento_DeveEnviarEmail()
        {
            var funcionario = new FuncionarioSolucao("Funcionario", 1000);
            var enviarEmailFuncionario = new EnviarEmailFuncionario(funcionario);
            var exception = Record.Exception(() => enviarEmailFuncionario.Enviar());            
            Assert.Null(exception);
        }
    }
}