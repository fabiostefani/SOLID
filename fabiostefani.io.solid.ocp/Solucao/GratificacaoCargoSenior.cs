namespace fabiostefani.io.solid.ocp.Solucao
{
    public class GratificacaoCargoSenior : IGratificacaoCargo
    {
        public double Calcular(double salario)
        {
            return (salario * 15) / 100;
        }
    }
}