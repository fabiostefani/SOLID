namespace fabiostefani.io.solid.srp
{
    public class CalcularImpostoFuncionario
    {
        private readonly FuncionarioSolucao funcionario;
        public CalcularImpostoFuncionario(FuncionarioSolucao funcionario)
        {
            this.funcionario = funcionario;

        }
        public double Calcular()
        {
            return (funcionario.Salario * 10) / 100;
        }
    }
}