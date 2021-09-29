namespace fabiostefani.io.solid.srp
{
    public class FolhaPagamentoSolucao
    {
        private readonly FuncionarioSolucao funcionario;
        public FolhaPagamentoSolucao(FuncionarioSolucao funcionario)
        {
            this.funcionario = funcionario;

        }
        public double Calcular()
        {
            var calculoImposto = new CalcularImpostoFuncionario(funcionario);
            return calculoImposto.Calcular();
        }      

        public void EnviarEmail()
        {
            var enviarEmail = new EnviarEmail();
            enviarEmail.Enviar("fabiostefani@gmail.com", "Folha de Pagamento", "Corpo do E-mail");
        }  
    }
}