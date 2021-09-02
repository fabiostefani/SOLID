using Xunit;

namespace fabiostefani.io.solid.srp
{
    public class FuncionariosViolacaoTests
    {
        [Fact]
        public void Funcionario_DeveCalcularImposto()
        {
            var funcionario = new FuncionarioViolacao("Funcionario", 1000);
            var imposto = funcionario.CalcularImposto();
            Assert.Equal(100, imposto);
        }

        [Fact]
        public void Funcionario_DeveEnviarEmailDeCadastro()
        {
            var funcionario = new FuncionarioViolacao("Funcionario", 1000);            
            var exception = Record.Exception(() => funcionario.EnviarEmail());            
            Assert.Null(exception);
        }
    }
}