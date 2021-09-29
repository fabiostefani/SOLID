namespace fabiostefani.io.solid.ocp.Solucao
{
    public class GratificacaoCargoEngenheiro : IGratificacaoCargo
    {
        public double Calcular(double salario)
        {
            return (salario * 20) / 100;
        }
    }
}