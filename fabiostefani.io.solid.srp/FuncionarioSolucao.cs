namespace fabiostefani.io.solid.srp
{
    public class FuncionarioSolucao
    {
        public string Nome { get; private set; }
        public double Salario { get; private set; }
        public FuncionarioSolucao(string nome, double salario)
        {
            Nome = nome;
            Salario = salario;
        }
    }
}