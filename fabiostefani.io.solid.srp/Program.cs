using System.Drawing;
// See https://aka.ms/new-console-template for more information
using fabiostefani.io.solid.srp;

Console.WriteLine("Hello, World!");
var funcionario = new FuncionarioViolacao("Funcionario", 1000);
var imposto = funcionario.CalcularImposto();
Console.WriteLine(imposto);
