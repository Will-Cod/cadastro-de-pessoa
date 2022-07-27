using Cadastro.Interfaces;

namespace Cadastro.Classes
{
    public class PessoaFisica : Pessoa, IPessoaFisica
    {
        public string ?cpf { get; set; }
        public string ?DataNascimento { get; set; }
        
        
        public override float PagarImposto(float rendimento)
        {
            throw new NotImplementedException();
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
    }
}