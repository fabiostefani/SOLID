namespace fabiostefani.io.solid.dip
{
    public class Funcionario
    {
        public int HorasTrabalhadas { get; private set; }
        public double ValorHora { get; private set; }
        
        public Funcionario(int horasTrabalhadas, double valorHora)
        {
            HorasTrabalhadas = horasTrabalhadas;
            ValorHora = valorHora;
        }
    }
}