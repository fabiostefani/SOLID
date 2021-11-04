namespace fabiostefani.io.solid.isp.Violacao;
public abstract class Funcionario
{
    public string Nome { get; set; }
    public double Salario { get; set; }

    public double ObterSalario() => Salario;

    public abstract double ObterComissao();
}