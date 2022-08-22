// See https://aka.ms/new-console-template for more information
using Cadastro.Classes;

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

List<PessoaFisica> listaPf = new List<PessoaFisica>();
List<PessoaJuridica> listaPj = new List<PessoaJuridica>();

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
        string? blocoPf;
          do
          {
              //Contador de carregando a aplicação
        BarraCarregamento("Carregando ", 50);
        Console.Clear();
            PessoaFisica metodoPf = new PessoaFisica();
                Console.WriteLine($"Digite a opção desejada");
                string? opcaoPf;
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
    
                opcaoPf = Console.ReadLine();
                switch (opcaoPf)
                {
                    case "1":
                     //Contador de carregando a aplicação
                     BarraCarregamento("Carregando ", 50);
                        Console.Clear();

                        PessoaFisica novaPf = new PessoaFisica();
                        Endereco novoEnd = new Endereco();

                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"Digite o nome da pessoa que deseja cadastrar:");
                        Console.ResetColor();
                        novaPf.nome = Console.ReadLine();
                        bool dataValida;

                        // Laço para verificação de data, caso esteja errada usuario fica nessa tela
                        do
                        {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"Data de nascimento que deseja cadastrar Ex.: DD/MM/AAAA");
                        Console.ResetColor();
                            // Processo de validação da data recebida
                                string dataNasc = Console.ReadLine();
                                dataValida = metodoPf.ValidarDataNascimento(dataNasc);

                                if(dataValida){
                                    novaPf.DataNascimento = dataNasc;
                                }else{
                                 Console.ForegroundColor = ConsoleColor.DarkRed;
                                 Console.WriteLine($"Data inválida, por favor digite uma data válida!");
                                 Console.ResetColor();
                             }
                        } while (dataValida == false);

                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"Digite o CPF:");
                        Console.ResetColor();
                        novaPf.cpf = Console.ReadLine();
                        
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"Rendimento mensal (apenas número):");
                        Console.ResetColor();
                        novaPf.rendimento = float.Parse(Console.ReadLine());

                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"Endereço:");
                        Console.ResetColor();
                        novoEnd.logradouro = Console.ReadLine();

                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"Nnumero da residência:");
                        Console.ResetColor();
                        novoEnd.numero = int.Parse(Console.ReadLine());

                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"Complemento? (aperte ENTER caso não tiver)");
                        Console.ResetColor();
                        novoEnd.complemento = Console.ReadLine();
                        
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"Seu endereço é comercial? S ou N");
                        Console.ResetColor();
                        string endCom = Console.ReadLine().ToUpper();

                       if(endCom == "S" && endCom == "SIM" ){
                            novoEnd.EndComercial = true;
                       }else{
                            novoEnd.EndComercial = false;
                       }
                        novaPf.endereco = novoEnd;

                        listaPf.Add(novaPf);
                        
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"Cadastro realizado com sucesso!");
                        Thread.Sleep(4000);
                        Console.ResetColor();
                        Console.Clear();
                                
                        break;
                    case "2":
                        //Contador de carregando a aplicação
                        BarraCarregamento("Carregando ", 50);
                        Console.Clear();

                        if(listaPf.Count >0){
                            foreach(PessoaFisica cadaPessoa in listaPf){
                                Console.Clear();

                                Console.WriteLine(@$"
                                Nome: {cadaPessoa.nome}
                                CPF: {cadaPessoa.cpf}
                                Data de Nascimento: {cadaPessoa.DataNascimento}
                                rendimento: {cadaPessoa.rendimento}
                                Endereço: {cadaPessoa.endereco.logradouro}, {cadaPessoa.endereco.numero}
                                Data de nascimento: {cadaPessoa.DataNascimento} 
                                Taxa de imposto: {metodoPf.PagarImposto(cadaPessoa.rendimento).ToString("c")}
                                ");
                            Console.WriteLine($"Aperte 'Enter' para continuar.");
                            Console.ReadLine();
                            }
                        }else{
                            Console.WriteLine($"Lista vazia!");
                            Thread.Sleep(3000);
                        }
                        break;
                    case "0":
                        Console.WriteLine($"Você realmente deseja sair? '0' para sim:");
                        break;
                    default:
                        Console.WriteLine($"Opção inválida, por favor digite outra opção!");
                        break;
                }
            blocoPf = Console.ReadLine();
          } while (blocoPf != "0");
            break;
        case "2":
            string? blocoPj;
           do
           {
             //Contador de carregando a aplicação
            BarraCarregamento("Carregando ", 50);
                Console.Clear();

                PessoaJuridica metodoPj = new PessoaJuridica();
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

                        PessoaJuridica novaPj = new PessoaJuridica();
                        Endereco novoEnd = new Endereco();

                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"Digite o nome da pessoa que deseja cadastrar:");
                        Console.ResetColor();
                        novaPj.nome = Console.ReadLine();

                        bool cnpjVal;

                        // Laço para verificação de data, caso esteja errada usuario fica nessa tela
                        do
                        {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"CNPJ que deseja cadastrar Ex.: xx.xxx.xxx/000x-xx");
                        Console.ResetColor();
                            // Processo de validação do CNPJ recebida
                                string cnpjValido = Console.ReadLine();
                                cnpjVal = metodoPj.ValidarCnpj(cnpjValido);

                                if(cnpjVal){
                                    novaPj.cnpj = cnpjValido;
                                }else{
                                 Console.ForegroundColor = ConsoleColor.DarkRed;
                                 Console.WriteLine($"CNPJ inválido, por favor digite um CNPJ válido!");
                                 Console.ResetColor();
                             }
                        } while (cnpjVal == false);

                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"Digite a Razão social:");
                        Console.ResetColor();
                        novaPj.RazaoSocial = Console.ReadLine();
                        
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"Rendimento mensal (apenas número):");
                        Console.ResetColor();
                        novaPj.rendimento = float.Parse(Console.ReadLine());

                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"Endereço:");
                        Console.ResetColor();
                        novoEnd.logradouro = Console.ReadLine();

                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"Nnumero da residência:");
                        Console.ResetColor();
                        novoEnd.numero = int.Parse(Console.ReadLine());

                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"Complemento? (aperte ENTER caso não tiver)");
                        Console.ResetColor();
                        novoEnd.complemento = Console.ReadLine();
                        
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"Seu endereço é comercial? S ou N");
                        Console.ResetColor();
                        string endCom = Console.ReadLine().ToUpper();

                       if(endCom == "S" && endCom == "SIM" ){
                            novoEnd.EndComercial = true;
                       }else{
                            novoEnd.EndComercial = false;
                       }
                        novaPj.endereco = novoEnd;

                        listaPj.Add(novaPj);
                        
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"Cadastro realizado com sucesso!");
                        Thread.Sleep(4000);
                        Console.ResetColor();
                        Console.Clear();
                        break;
                    case "2":
                    //Contador de carregando a aplicação
                    BarraCarregamento("Carregando ", 50);
                    Console.Clear();

                    Console.WriteLine($"Pessoa encontrada em nossos dados: ");

                        if(listaPj.Count >0){
                            foreach(PessoaJuridica cadaPessoa in listaPj){
                                Console.Clear();
                                Console.WriteLine(@$"
                                    Nome: {cadaPessoa.nome}
                                    Razão Social: {cadaPessoa.RazaoSocial}
                                    CNPJ: {cadaPessoa.cnpj}
                                    CNPJ é válido: {cadaPessoa.cnpj}
                                    Taxa de imposto: {metodoPj.PagarImposto(cadaPessoa.rendimento).ToString("c")}
                                    ");
                                Console.WriteLine($"Aperte 'Enter' para continuar.");
                                Console.ReadLine();
                        }
                        }else{
                            Console.WriteLine($"Lista vazia!");
                            Thread.Sleep(3000);
                        }
                        break;
                    case "0":
                        Console.WriteLine($"Você realmente deseja sair? '0' para sim:");
                        break;
                    default:
                        Console.WriteLine($"Opção inválida, por favor digite outra opção!");
                        break;
                }
            blocoPj = Console.ReadLine();
           } while (blocoPj != "0");
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