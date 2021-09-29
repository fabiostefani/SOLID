namespace fabiostefani.io.solid.srp
{
    public class FolhaPagamentoViolacao
    {
        private readonly FuncionarioViolacao funcionario;
        public FolhaPagamentoViolacao(FuncionarioViolacao funcionario)
        {
            this.funcionario = funcionario;

        }
        public double Calcular()
        {
            return this.funcionario.CalcularImposto();
        }      

        public void EnvairEmail()
        {
            this.funcionario.EnviarEmail();
        }  
    }
}