using Cadastro.Interfaces;
using System.Text.RegularExpressions;

namespace Cadastro.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        public string ?cnpj { get; set; }
        public string ?RazaoSocial { get; set; }
        
        
        
        
        public override float PagarImposto(float rendimento)
        {
            throw new NotImplementedException();
        }
        /*
        xx.xxx.xxx/0001-xx
        \d{}
        */
        public bool ValidarCnpj(string cnpj)
        {
           if(Regex.IsMatch(cnpj,@"(^(\d{2}.\d{3}.\d{3}/\d{4}-\d{2})$)")){
            return true;
           }
           else{
            return false;
           }
        }
    }
}