using Cadastro.Interfaces;
using System.Text.RegularExpressions;

namespace Cadastro.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        public string ?cnpj { get; set; }
        public string ?RazaoSocial { get; set; }
        
        public string caminho { get; private set; } = "Database/PessoaJuridica.csv";
        
        
        public override float PagarImposto(float rendimento)
        {
            if(rendimento <= 1500){
                return (rendimento / 100) *3;
            }
            else if(rendimento > 1500 && rendimento <= 3500){
                return (rendimento / 100) *5;
            }
            else if(rendimento > 3500 && rendimento <= 6000){
                return (rendimento / 100) * 7;
            }
            else{
                return (rendimento / 100) *9;
            }
        }
        /*
        xx.xxx.xxx/0001-xx
        \d{}
        */
        public bool ValidarCnpj(string cnpj)
        {
            if(Regex.IsMatch(cnpj, @"(^(\d{2}.\d{3}.\d{3}/\d{4}-\d{2})|(\d{14})$)"))
            {
                if(cnpj.Length == 18)
                {
                    if(cnpj.Substring(11,4) == "0001") // ele vai iniciar no caracteres 11 e pegar os proximos 4
                    {
                        return true;
                    }
                }
                else if(cnpj.Length == 14)
                {
                    if(cnpj.Substring(8,4) == "0001")//ele vai iniciar no caractere 8 e pegar os proximos 4
                    {
                        return true;
                    }
                }
            }
        return false;
        }
                  //Processo de criar csv
        public void inserir(PessoaJuridica pj){
        
        verificarPastaArquivo(caminho);

        string[] pjString = {$"{pj.nome},{pj.cnpj},{pj.RazaoSocial}"};//Dados que vão ser salvos no arey
        File.AppendAllLines(caminho, pjString);//Os dados salvos no arey estão sendo enviados para o arquivo
        }  

        public List<PessoaJuridica> ler(){ //Criei a lista
            List<PessoaJuridica> listaPj = new List<PessoaJuridica>();//Lendo o arquivo

            String[] linhas = File.ReadAllLines(caminho);//Arey que le o arquivo e salva em "linhas"

            foreach (string cadalinha in linhas){
                string[] atributos = cadalinha.Split(",");//Separa cada atributo por ","

                PessoaJuridica cadaPj = new PessoaJuridica();//Novo objeto
                //Ordenação dos atributos que vão ser salvos
                Endereco cadaEnd = new Endereco();

                cadaPj.nome = atributos[0];
                cadaPj.cnpj = atributos[1];
                cadaPj.RazaoSocial = atributos[2];
                cadaPj.rendimento = float.Parse(atributos[3]);
                cadaEnd.logradouro = atributos[4];
                cadaEnd.numero = int.Parse(atributos[5]);
                cadaEnd.complemento = atributos[6];
                cadaEnd.EndComercial = bool.Parse(atributos[7]);
                cadaPj.endereco = cadaEnd;

                listaPj.Add(cadaPj);//adiciona os dados na lista
            }
            return listaPj;
        }
    }
}