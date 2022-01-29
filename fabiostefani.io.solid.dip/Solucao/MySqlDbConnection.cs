namespace fabiostefani.io.solid.dip.Solucao
{
    public class MySqlDbConnection : IDbConnection
    {
        public string RecuperarUsuario(string user)
        {
            Console.WriteLine("Busca o usuário no banco MySql");
            return user;
        }
    }
}