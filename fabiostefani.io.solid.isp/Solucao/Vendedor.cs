namespace fabiostefani.io.solid.isp.Solucao;
public class Vendedor : Funcionario, IComissao
{
    const double COMISSAO = 0.2;
    public double TotalVendas { get; set; }

    public double ObterComissao() => TotalVendas * COMISSAO;
}