namespace fabiostefani.io.solid.ocp
{
    public class Funcionario
    {
        public string Nome { get; private set; }
        public EnumCargo Cargo { get; private set; }
        public double Salario { get; private set; }

        public Funcionario(string nome, double salario, EnumCargo cargo)
        {
            Nome = nome;
            Cargo = cargo;
            Salario = salario;
        }

    }
}