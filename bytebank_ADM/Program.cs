using bytebank_ADM.Funcionarios;
using bytebank_ADM.Utilitario;

Console.WriteLine("Boas Vindas, ao ByteBank Administração");

GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

Funcionario pedro = new Funcionario("12345678",2000);
pedro.Nome = "Pedro";

Diretor paula = new Diretor("1241661613", 5000);
paula.Nome = "Paula";


Funcionario andre = new Diretor("9876554122", 3500);
andre.Nome = "André";

Console.WriteLine($"Bonificação Pedro: {pedro.getBonificacao()}");
Console.WriteLine($"Bonificação Paula: {paula.getBonificacao()} ");
Console.WriteLine($"Bonificação André: {andre.getBonificacao()}");


gerenciador.Registrar(pedro);
gerenciador.Registrar(paula);
gerenciador.Registrar(andre);

Console.WriteLine(Funcionario.totalFuncionarios);

andre.aumentarSalario();
pedro.aumentarSalario();

Console.WriteLine("Novo salário do André: "+ andre.Salario);
Console.WriteLine($"Total de Bonificação: {gerenciador.getBonificacao()}");