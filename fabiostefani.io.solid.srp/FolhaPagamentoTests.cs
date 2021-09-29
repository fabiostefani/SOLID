using Xunit;

namespace fabiostefani.io.solid.srp
{
    public class FolhaPagamentoTests
    {
        [Fact]
        public void FolhaPagamento_DeveCalcularImposto()
        {
            var funcionario = new FuncionarioViolacao("Funcionario", 1000);
            var calculadoraImposto = new FolhaPagamentoViolacao(funcionario);
            var imposto = calculadoraImposto.Calcular();
            Assert.Equal(100, imposto);
        }

        [Fact]
        public void FolhaPagamento_DeveEnviarEmail()
        {
            var funcionario = new FuncionarioViolacao("Funcionario", 1000);
            var enviarEmail = new FolhaPagamentoViolacao(funcionario);
            var exception = Record.Exception(() => enviarEmail.EnvairEmail());            
            Assert.Null(exception);
        }

        [Fact]
        public void FolhaPagamentoSolucao_DeveCalcularImposto()
        {
            var funcionario = new FuncionarioSolucao("Funcionario", 1000);
            var calculadoraImposto = new FolhaPagamentoSolucao(funcionario);
            var imposto = calculadoraImposto.Calcular();
            Assert.Equal(100, imposto);
        }

        [Fact]
        public void FolhaPagamentoSolucao_DeveEnviarEmail()
        {
            var funcionario = new FuncionarioSolucao("Funcionario", 1000);
            var enviarEmail = new FolhaPagamentoSolucao(funcionario);
            var exception = Record.Exception(() => enviarEmail.EnviarEmail());            
            Assert.Null(exception);
        }
    }
}