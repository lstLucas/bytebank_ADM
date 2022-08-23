using bytebank_ADM.Funcionarios;

Console.WriteLine("Boas Vindas, ao ByteBank Administração");

Funcionario pedro = new Funcionario(1);
pedro.nome = "Pedro";
pedro.cpf = "12345698";
pedro.salario = 2000;

Console.WriteLine($"Bonificação: {pedro.getBonificacao()}");