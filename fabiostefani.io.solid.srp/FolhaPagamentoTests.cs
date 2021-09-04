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
            var enviarEmail = new EnviarEmail();
            var exception = Record.Exception(() => enviarEmail.Enviar("fabiostefani@gmail.com", "Este é um simples ,muito simples email", "Este é o corpo do email"));            
            Assert.Null(exception);
        }
    }
}