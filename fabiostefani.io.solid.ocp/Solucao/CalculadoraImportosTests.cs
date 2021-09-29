using Xunit;

namespace fabiostefani.io.solid.ocp.Solucao
{
    public class CalculadoraImportosTests
    {
        [Fact]
        public void Calcular_DeveCalcularImposto_ParadevJunior()
        {
            var funcionario = new Funcionario("Funcionario", 1000, EnumCargo.Junior);
            var calculadora = new CalculadoraGratificacao(new GratificacaoCargoJunior());
            var gratificacao = calculadora.Calcular(funcionario.Salario);
            Assert.Equal(100, gratificacao);

        }

        [Fact]
        public void Calcular_DeveCalcularImposto_ParaDevePleno()
        {
            var funcionario = new Funcionario("Funcionario", 1000, EnumCargo.Pleno);
            var calculadora = new CalculadoraGratificacao(new GratificacaoCargoPleno());
            var gratificacao = calculadora.Calcular(funcionario.Salario);
            Assert.Equal(120, gratificacao);

        }

        [Fact]
        public void Calcular_DeveCalcularImposto_ParaDeveSenior()
        {
            var funcionario = new Funcionario("Funcionario", 1000, EnumCargo.Senior);
            var calculadora = new CalculadoraGratificacao(new GratificacaoCargoSenior());
            var gratificacao = calculadora.Calcular(funcionario.Salario);
            Assert.Equal(150, gratificacao);

        }

        [Fact]
        public void Calcular_DeveCalcularImposto_ParaDeveEngenheuri()
        {
            var funcionario = new Funcionario("Funcionario", 1000, EnumCargo.Engenheiro);
            var calculadora = new CalculadoraGratificacao(new GratificacaoCargoEngenheiro());
            var gratificacao = calculadora.Calcular(funcionario.Salario);
            Assert.Equal(200, gratificacao);

        }
    }
}