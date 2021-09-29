namespace fabiostefani.io.solid.ocp.Violacao
{
    public class CalculadoraGratificacao
    {
        public double Calcular(double salario, EnumCargo cargo)
        {
            if (cargo == EnumCargo.Junior)
            {
                return (salario * 10) / 100;
            }
            if (cargo == EnumCargo.Pleno)
            {
                return (salario * 12) / 100;
            }
            if (cargo == EnumCargo.Senior)
            {
                return (salario * 15) / 100;
            }
            if (cargo == EnumCargo.Engenheiro)
            {
                return (salario * 20) / 100;
            }
            return 0;
        }
    }
}