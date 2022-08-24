using bytebank_ADM.Funcionarios;
using bytebank_ADM.Utilitario;

Console.WriteLine("Boas Vindas, ao ByteBank Administração");

GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

Funcionario pedro = new Funcionario();
pedro.Nome = "Pedro";
pedro.Cpf = "12345698";
pedro.Salario = 2000;

Diretor paula = new Diretor();
paula.Nome = "Paula";
paula.Cpf = "1241661613";
paula.Salario = 5000;

Funcionario andre = new Diretor();
andre.Nome = "André";
andre.Cpf = "9876554122";
andre.Salario = 3500;

Console.WriteLine($"Bonificação Pedro: {pedro.getBonificacao()}");
Console.WriteLine($"Bonificação Paula: {paula.getBonificacao()} ");
Console.WriteLine($"Bonificação André: {andre.getBonificacao()}");


gerenciador.Registrar(pedro);
gerenciador.Registrar(paula);
gerenciador.Registrar(andre);

Console.WriteLine($"Total de Bonificação: {gerenciador.getBonificacao()}");