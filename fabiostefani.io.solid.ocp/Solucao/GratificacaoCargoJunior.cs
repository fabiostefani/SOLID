namespace fabiostefani.io.solid.ocp.Solucao
{
    public class GratificacaoCargoJunior : IGratificacaoCargo
    {
        public double Calcular(double salario)
        {
            return (salario * 10) / 100;
        }
    }
}