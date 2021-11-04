namespace fabiostefani.io.solid.isp.Violacao;
public class Vendedor : Funcionario
{
    const double COMISSAO = 0.2;
    public double TotalVendas { get; set; }

    public override double ObterComissao() => TotalVendas * COMISSAO;

}