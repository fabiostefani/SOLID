namespace fabiostefani.io.solid.dip.Violacao
{
    public class SqlServerDbConnection
    {
        public string RecuperarUsuario(string user)
        {
            Console.WriteLine("Busca o usuário no banco Sql Server");
            return user;
        }
    }
}