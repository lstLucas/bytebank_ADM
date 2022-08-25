using bytebank_ADM.Funcionarios;
using bytebank_ADM.Utilitario;

Console.WriteLine("Boas Vindas, ao ByteBank Administração");

GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

Funcionario pedro = new Funcionario("12345678");
pedro.Nome = "Pedro";
pedro.Salario = 2000;

Diretor paula = new Diretor("1241661613");
paula.Nome = "Paula";
paula.Salario = 5000;

Funcionario andre = new Diretor("9876554122");
andre.Nome = "André";
andre.Salario = 3500;

Console.WriteLine($"Bonificação Pedro: {pedro.getBonificacao()}");
Console.WriteLine($"Bonificação Paula: {paula.getBonificacao()} ");
Console.WriteLine($"Bonificação André: {andre.getBonificacao()}");


gerenciador.Registrar(pedro);
gerenciador.Registrar(paula);
gerenciador.Registrar(andre);
Console.WriteLine(Funcionario.totalFuncionarios);
Console.WriteLine($"Total de Bonificação: {gerenciador.getBonificacao()}");