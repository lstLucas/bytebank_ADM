using bytebank_ADM.Funcionarios;
using bytebank_ADM.SistemaInterno;
using bytebank_ADM.Utilitario;


//CalcularBonificação();
UsarSistema();

void CalcularBonificação() {
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

    Designer pedro = new Designer("833.222.048-39");
    pedro.Nome = "Pedro";

    Diretor paula = new Diretor("159.753.398-04");
    paula.Nome = "Paula";
    paula.Senha = "123";

    Auxiliar igor = new Auxiliar("981.198.778-53");
    igor.Nome = "Igor";

    GerenteDeContas camila = new GerenteDeContas("326.985.628-89");
    camila.Nome = "Camila";
    camila.Senha = "321";

    Desenvolvedor cleiton = new Desenvolvedor("050.392.123-33");
    cleiton.Nome = "Cleiton";

    gerenciador.Registrar(pedro);
    gerenciador.Registrar(paula);
    gerenciador.Registrar(igor);
    gerenciador.Registrar(camila);
    gerenciador.Registrar(cleiton);

    Console.WriteLine($"Total de Bonificação: {gerenciador.getBonificacao()}");
}

void UsarSistema() {
    SistemaInterno sistemainterno = new SistemaInterno();

    Diretor paula = new Diretor("159.753.398-04");
    paula.Nome = "Paula";
    paula.Senha = "123";

    GerenteDeContas camila = new GerenteDeContas("326.985.628-89");
    camila.Nome = "Camila";
    camila.Senha = "321";

    sistemainterno.Login(paula,paula.Senha);
    sistemainterno.Login(camila,camila.Senha);
}