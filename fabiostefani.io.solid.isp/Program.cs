using fabiostefani.io.solid.isp.Violacao;
// See https://aka.ms/new-console-template for more information

Console.WriteLine("Violação");
var vendedor = new Vendedor() { Salario = 1000, TotalVendas = 1000 };
Console.WriteLine(vendedor.ObterSalario().ToString());
Console.WriteLine(vendedor.ObterComissao().ToString());

var dev = new Desenvolvedor() { Salario = 2000 };
Console.WriteLine(dev.ObterSalario().ToString());
Console.WriteLine(dev.ObterComissao().ToString());

Console.WriteLine("Solucao");
var vendedorSol = new fabiostefani.io.solid.isp.Solucao.Vendedor() { Salario = 1000, TotalVendas = 1000 };
Console.WriteLine(vendedorSol.ObterSalario().ToString());
Console.WriteLine(vendedorSol.ObterComissao().ToString());

var devSol = new fabiostefani.io.solid.isp.Solucao.Desenvolvedor() { Salario = 2000 };
Console.WriteLine(devSol.ObterSalario().ToString());

Console.WriteLine("Hello, World!");
