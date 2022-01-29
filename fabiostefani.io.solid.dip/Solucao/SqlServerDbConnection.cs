namespace fabiostefani.io.solid.dip.Solucao
{
    public class SqlServerDbConnection : IDbConnection
    {
        public string RecuperarUsuario(string user)
        {
            Console.WriteLine("Busca o usuário no banco Sql Server");
            return user;
        }
    }
}