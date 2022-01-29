using fabiostefani.io.solid.dip;
using fabiostefani.io.solid.dip.Violacao;

Console.WriteLine("Violação");
var recuperarSenhaViolacao = new RecuperarSenha();
recuperarSenhaViolacao.RecuperarSenhaUsuario("user");

Console.WriteLine("Solução");
var recuperarSenhaSolucacaoSql = new fabiostefani.io.solid.dip.Solucao.RecuperarSenha(new fabiostefani.io.solid.dip.Solucao.SqlServerDbConnection());
recuperarSenhaSolucacaoSql.RecuperarSenhaUsuario("user");
var recuperarSenhaSolucacaoMySql = new fabiostefani.io.solid.dip.Solucao.RecuperarSenha(new fabiostefani.io.solid.dip.Solucao.MySqlDbConnection());
recuperarSenhaSolucacaoMySql.RecuperarSenhaUsuario("user");