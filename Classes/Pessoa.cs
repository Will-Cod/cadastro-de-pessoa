using Cadastro.Interfaces;

namespace Cadastro.Classes
{
    public abstract class Pessoa : IPessoa
    {
        public string ?nome {get;set;}
        public Endereco ?endereco { get; set; }
        public float rendimento { get; set; }
        
        
        
        
        public abstract float PagarImposto(float rendimento);
       
       public void verificarPastaArquivo(string caminho){
         string pasta = caminho.Split("/")[0];//função que pega a primeira parte da variavel que foi cadastrada em PessoaJuridica, 'Database/PessoaJuridica.csv', 'Database' ficou armazenada na string pasta.
        
         if(!Directory.Exists(pasta)){
            Directory.CreateDirectory(pasta);//Esse if verifica se existe a pasta, caso não ele cria uma, regra de negação apilcada quando adicionado !.
         }
         if(!File.Exists(caminho)){
            using (File.Create(caminho)){}//Esse if verifica se existe o arquivo, caso não ele cria uma, regra de negação apilcada quando adicionado !
         }
       }
    }
}