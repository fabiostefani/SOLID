namespace fabiostefani.io.solid.dip.Solucao;
public class RecuperarSenha
{
    private readonly IDbConnection connection;
    public RecuperarSenha(IDbConnection connection)
    {
        this.connection = connection;
    }

    public void RecuperarSenhaUsuario(string user)
    {
        var userDb = this.connection.RecuperarUsuario(user);
        //Continua...
    }
}