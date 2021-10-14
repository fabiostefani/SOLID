namespace fabiostefani.io.solid.lsp.Violacao
{
    public class ContaCorrente : Conta
    {
        const decimal Juros = 0.006m;
        public override void Render()
        {
            Saldo = (ObterSaldo() * Juros) + ObterSaldo();
        }
    }
}