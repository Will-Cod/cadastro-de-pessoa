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
           if(Regex.IsMatch(cnpj,@"(^(\d{2}.\d{3}.\d{3}/\d{4}-\d{2}) | (\d{14})$)")){
            if(cnpj.Length == 18){
                if(cnpj.Substring(11,4) == "0001"){ //ele vai iniciar no caracter 11 e pagar os proximos 4
                    return true;
                }
            }
            else if(cnpj.Length == 14){
                if(cnpj.Substring(8,4) == "0001"){ //ele vai iniciar no caracter 8 e pegar os proximos 4
                return true;
                }
            }
            return true;
           }
            return false;
        }
    }
}