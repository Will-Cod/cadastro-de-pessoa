using Cadastro.Interfaces;

namespace Cadastro.Classes
{
    public class PessoaFisica : Pessoa, IPessoaFisica
    {
        public string ?cpf { get; set; }
        public string ?DataNascimento { get; set; }
        public string caminho { get; private set; } = "Database/PessoaFisica.csv";
        
        
        public override float PagarImposto(float rendimento)
        {
            if(rendimento <= 1500){
                return 0;
            }
            else if(rendimento > 1500 && rendimento <= 3500){
                return (rendimento / 100) *2;
            }
            else if(rendimento > 3500 && rendimento <= 6000){
                return (rendimento / 100) * 3.5f;
            }
            else{
                return (rendimento / 100) *5;
            }
        }

        public bool ValidarDataNascimento(DateTime DataNasc)
        {
            DateTime DataAtual = DateTime.Today;
            double anos = (DataAtual - DataNasc).TotalDays /365;
            if(anos >= 18){
            return true;
            }
            else
            return false;
        }
        public bool ValidarDataNascimento(string DataNasc)
        {
            DateTime DataConvertida;
            // verificar se a string está valida
            if(DateTime.TryParse(DataNasc, out DataConvertida)){ //TryParse tenta converter e colocar na said out
                // Console.WriteLine($"{DataConvertida}");
                DateTime DataAtual = DateTime.Today;
            double anos = (DataAtual - DataConvertida).TotalDays /365;
             if(anos >= 18)
                 return true;
             else
                return false;
            }
            return false;
        }
                   //Processo de criar csv
        public void inserir(PessoaFisica pf){
        
        verificarPastaArquivo(caminho);

        string[] pfString = {$"{pf.nome},{pf.cpf},{pf.DataNascimento}"};//Dados que vão ser salvos no arey
        File.AppendAllLines(caminho, pfString);//Os dados salvos no arey estão sendo enviados para o arquivo
        }  

        public List<PessoaFisica> ler(){ //Criei a lista
            List<PessoaFisica> listaPf = new List<PessoaFisica>();//Lendo o arquivo

            String[] linhas = File.ReadAllLines(caminho);//Arey que le o arquivo e salva em "linhas"

            foreach (string cadalinha in linhas){
                string[] atributos = cadalinha.Split(",");//Separa cada atributo por ","

                PessoaFisica cadaPf = new PessoaFisica();//Novo objeto
                //Ordenação dos atributos que vão ser salvos
                cadaPf.nome = atributos[0];
                cadaPf.cpf = atributos[1];
                cadaPf.DataNascimento = atributos[2];

                listaPf.Add(cadaPf);//adiciona os dados na lista
            }
            return listaPf;
        }
    }
}