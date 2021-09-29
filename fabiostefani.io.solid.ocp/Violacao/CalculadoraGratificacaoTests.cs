using Xunit;
using fabiostefani.io.solid.ocp;

namespace fabiostefani.io.solid.ocp.Violacao
{
    public class CalculadoraGratificacaoTests
    {
        [Fact]
        public void Calcular_DeveCalcularImposto_ParadevJunior()
        {
            var funcionario = new Funcionario("Funcionario", 1000, EnumCargo.Junior);
            var calculadora = new CalculadoraGratificacao();
            var gratificacao = calculadora.Calcular(funcionario.Salario, funcionario.Cargo);
            Assert.Equal(100, gratificacao);

        }

        [Fact]
        public void Calcular_DeveCalcularImposto_ParaDevePleno()
        {
            var funcionario = new Funcionario("Funcionario", 1000, EnumCargo.Pleno);
            var calculadora = new CalculadoraGratificacao();
            var gratificacao = calculadora.Calcular(funcionario.Salario, funcionario.Cargo);
            Assert.Equal(120, gratificacao);

        }

        [Fact]
        public void Calcular_DeveCalcularImposto_ParaDeveSenior()
        {
            var funcionario = new Funcionario("Funcionario", 1000, EnumCargo.Senior);
            var calculadora = new CalculadoraGratificacao();
            var gratificacao = calculadora.Calcular(funcionario.Salario, funcionario.Cargo);
            Assert.Equal(150, gratificacao);

        }

        [Fact]
        public void Calcular_DeveCalcularImposto_ParaDeveEngenheuri()
        {
            var funcionario = new Funcionario("Funcionario", 1000, EnumCargo.Engenheiro);
            var calculadora = new CalculadoraGratificacao();
            var gratificacao = calculadora.Calcular(funcionario.Salario, funcionario.Cargo);
            Assert.Equal(200, gratificacao);

        }
    }
}