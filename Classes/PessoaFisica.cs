using Cadastro.Interfaces;

namespace Cadastro.Classes
{
    public class PessoaFisica : Pessoa, IPessoaFisica
    {
        public string ?cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        
        
        public override float PagarImposto(float rendimento)
        {
            throw new NotImplementedException();
        }

        public bool ValidarDataNascimento(DateTime DataNasc)
        {
            throw new NotImplementedException();
        }
    }
}