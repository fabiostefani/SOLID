using System;

namespace fabiostefani.io.solid.lsp.Violacao
{
    public class ContaSalario : Conta
    {
        public override void Render()
        {
            throw new Exception("Conta salário não possui rendimento");
        }
    }
}