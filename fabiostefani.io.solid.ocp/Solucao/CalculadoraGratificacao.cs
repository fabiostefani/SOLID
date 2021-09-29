namespace fabiostefani.io.solid.ocp.Solucao
{
    public class CalculadoraGratificacao
    {
        private readonly IGratificacaoCargo _cargo;
        public CalculadoraGratificacao(IGratificacaoCargo cargo)
        {
            _cargo = cargo;
        }
        public double Calcular(double salario)
        {
            return _cargo.Calcular(salario);
        }
    }
}