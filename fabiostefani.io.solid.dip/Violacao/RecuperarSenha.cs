namespace fabiostefani.io.solid.dip.Violacao;
public class RecuperarSenha
{
    private readonly SqlServerDbConnection connection;
    public RecuperarSenha()
    {
        this.connection = new SqlServerDbConnection();
    }

    public void RecuperarSenhaUsuario(string user)
    {
        var userDb = this.connection.RecuperarUsuario(user);
        //Continua...
    }
}