namespace fabiostefani.io.solid.ocp.Solucao
{
    public class GratificacaoCargoPleno : IGratificacaoCargo
    {
        public double Calcular(double salario)
        {
            return (salario * 12) / 100;
        }
    }
}