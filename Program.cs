// See https://aka.ms/new-console-template for more information
using Cadastro.Classes;

/*
PessoaFisica novaPf = new PessoaFisica();
Endereco novoEnd = new Endereco();

// novaPf.nome = "William";
// novaPf.DataNascimento = "13/12/1995";
// novaPf.cpf = "12345678900";
// novaPf.rendimento = 500.0f;

novoEnd.logradouro = "Dolores Alcaras Caldas";
novoEnd.numero = 8975;
novoEnd.complemento = "Apto 50";
novoEnd.EndComercial = false;

// novaPf.endereco = novoEnd;

// Console.WriteLine(@$"
// Nome: {novaPf.nome}
// Endereço: {novaPf.endereco.logradouro}, {novaPf.endereco.numero}
// Maior de idade: {novaPf.ValidarDataNascimento(novaPf.DataNascimento)} 
// ");


novaPf.nome = "William";
Console.WriteLine(novaPf.nome);



// Console.WriteLine(novaPf.ValidarDataNascimento("01/01/2000"));
// Console.WriteLine(novaPf.ValidarDataNascimento(new DateTime(2000,01,01)));

PessoaJuridica metodoPj = new PessoaJuridica();
PessoaJuridica novaPj = new PessoaJuridica();

novaPj.endereco = novoEnd;

novaPj.nome = "NomePj";
novaPj.cnpj = "00.000.000/0001-00";
novaPj.RazaoSocial = "Razão Barão de Limeira";
novaPj.rendimento = 5000.5f;

Console.WriteLine(@$"
Nome: {novaPj.nome}
Razão Social:{novaPj.RazaoSocial}
CNPJ: {novaPj.cnpj}
CNPJ é válido: {metodoPj.ValidarCnpj(novaPj.cnpj)}
");
*/
//Tela de boas vindas
Console.BackgroundColor = ConsoleColor.Green;
Console.WriteLine(@$"
===========================================================================
==                Bem vindo ao sistema de cadastro de                    ==
==                    Pessoas Físicas e Jurídicas                        ==
===========================================================================
");
Console.ResetColor();

//Contador de carregando a aplicação
BarraCarregamento("Carregando ", 150);

string? opcao;
do
{
    Console.Clear();

    // Tela de seleção de tipo de pessoa
    Console.BackgroundColor = ConsoleColor.Green;
    Console.WriteLine(@$"
===========================================================================
==                Escolha uma das opções a seguir:                       ==
===========================================================================
==                    1 - Pessoa Física                                  ==
==                    2 - Pessoa Jurídica                                ==
==                                                                       ==
==                    0 - Sair                                           ==
===========================================================================
");
    Console.ResetColor();

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            //Contador de carregando a aplicação
            BarraCarregamento("Carregando ", 50);
            Console.Clear();

                Console.WriteLine($"Digite a opção desejada");
                string ?opcaofisica;
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine(@$"
===========================================================================
==                    1 - Cadastrar Pessoa Física                        ==
==                    2 - Consultar Pessoa Física                        ==
==                                                                       ==
==                    0 - Sair                                           ==
===========================================================================
");
                Console.ResetColor();
    
                opcaofisica = Console.ReadLine();
                switch (opcaofisica)
                {
                    case "1":
                     //Contador de carregando a aplicação
                     BarraCarregamento("Carregando ", 50);
                        Console.Clear();

                        Console.WriteLine($"Tela em construção.");
                        Console.WriteLine($"Aperte 'Enter' para continuar");
                                Console.ReadLine();
                        break;
                    case "2":
                        //Contador de carregando a aplicação
                        BarraCarregamento("Carregando ", 50);
                            Console.Clear();

                    Console.WriteLine($"Pessoa encontrada em nossos dados: ");
                        PessoaFisica novaPf = new PessoaFisica();
                        Endereco novoEnd = new Endereco();
                        PessoaFisica metodoPf = new PessoaFisica();
                            novaPf.nome = "William";
                            novaPf.DataNascimento = "13/12/2019";
                            novaPf.cpf = "12345678900";
                            novaPf.rendimento = 1800.0f;
                            novoEnd.logradouro = "Dolores Alcaras Caldas";
                            novoEnd.numero = 8975;
                            novoEnd.complemento = "Apto 50";
                            novoEnd.EndComercial = false;
                            novaPf.endereco = novoEnd;
                                Console.WriteLine(@$"
                                Nome: {novaPf.nome}
                                CPF: {novaPf.cpf}
                                Data de Nascimento: {novaPf.DataNascimento}
                                rendimento: {novaPf.rendimento}
                                Endereço: {novaPf.endereco.logradouro}, {novaPf.endereco.numero}
                                Maior de idade: {(novaPf.ValidarDataNascimento(novaPf.DataNascimento)? "Sim": "Não")} 
                                Taxa de imposto: {metodoPf.PagarImposto(novaPf.rendimento).ToString("c")}
                                ");
                                Console.WriteLine($"Aperte 'Enter' para continuar.");
                                Console.ReadLine();
                        break;
                    case "0":
                        Console.WriteLine($"Você digitou 0, aperte 'Enter' para continuar");
                        break;
                    default:
                        Console.WriteLine($"Opção inválida, por favor digite outra opção!");
                        break;
                }
                
            break;
        case "2":
            //Contador de carregando a aplicação
            BarraCarregamento("Carregando ", 50);
                Console.Clear();

                Console.WriteLine($"Digite a opção desejada");
                string ?opcaojuridica;
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine(@$"
===========================================================================
==                    1 - Cadastrar Pessoa Jurídica                      ==
==                    2 - Consultar Pessoa Jurídica                      ==
==                                                                       ==
==                    0 - Sair                                           ==
===========================================================================
");
                Console.ResetColor();
    
                opcaojuridica = Console.ReadLine();
                switch (opcaojuridica)
                {
                    case "1":
                    //Contador de carregando a aplicação
                    BarraCarregamento("Carregando ", 50);
                        Console.Clear();

                        Console.WriteLine($"Tela em construção.");

                        Console.WriteLine($"Aperte 'Enter' para continuar");
                                Console.ReadLine();
                        break;
                    case "2":
                    //Contador de carregando a aplicação
                    BarraCarregamento("Carregando ", 50);
                        Console.Clear();

                    Console.WriteLine($"Pessoa encontrada em nossos dados: ");
                        PessoaJuridica metodoPj = new PessoaJuridica();
                        PessoaJuridica novaPj = new PessoaJuridica();
                        Endereco novoEnd = new Endereco();
                        novaPj.nome = "NomePj";
                        novaPj.cnpj = "00.000.000/0001-00";
                        novaPj.RazaoSocial = "Razão Barão de Limeira";
                        novaPj.rendimento = 5000.5f;
                        novoEnd.logradouro = "Dolores Alcaras Caldas";
                        novoEnd.numero = 8975;
                        novoEnd.complemento = "Apto 50";
                        novoEnd.EndComercial = false;
                            Console.WriteLine(@$"
                                Nome: {novaPj.nome}
                                Razão Social: {novaPj.RazaoSocial}
                                CNPJ: {novaPj.cnpj}
                                CNPJ é válido: {(metodoPj.ValidarCnpj(novaPj.cnpj)? "Sim": "Não")}
                                Taxa de imposto: {metodoPj.PagarImposto(novaPj.rendimento).ToString("c")}
                                ");
                                Console.WriteLine($"Aperte 'Enter' para continuar.");
                                Console.ReadLine();
                        break;
                    case "0":
                        Console.WriteLine($"Você digitou 0, aperte 'Enter' para continuar");
                        break;
                    default:
                        Console.WriteLine($"Opção inválida, por favor digite outra opção!");
                        break;
                }
            break;
        case "0":
            
            //Contador de carregando a aplicação
            Console.WriteLine($"Obrigado por utilizar nosso sistema!");
                BarraCarregamento("Saindo ", 150);
                Console.Clear();
            break;
        default:
            Console.WriteLine($"Opção inválida, por favor digite uma opção listada a cima!");

            Console.ReadLine();
            break;
    }

} while (opcao != "0");

//Metodo que aparece o carregamento das opções.
static void BarraCarregamento(string texto, int tempo){
Console.BackgroundColor = ConsoleColor.Black;
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write($"{texto}");
        for (var contador = 0; contador < 20; contador++){
          Console.Write(". ");
          Thread.Sleep(tempo);}
         Console.ResetColor();
}