namespace EY.Reinf.Object.Model
{
    public class Contato
    {
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        private string _nome;

        public string RazaoSocial
        {
            get { return _razaoSocial; }
            set { _razaoSocial = value; }
        }
        private string _razaoSocial;

        public string CPF
        {
            get { return _cpf; }
            set { _cpf = value; }
        }
        private string _cpf;

        public string CNPJ
        {
            get { return _cnpj; }
            set { _cnpj = value; }
        }
        private string _cnpj;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        private string _email;

        public string TelefoneFixo
        {
            get { return _telefoneFixo; }
            set { _telefoneFixo = value; }
        }
        private string _telefoneFixo;

        public string TelefoneMovel
        {
            get { return _telefoneMovel; }
            set { _telefoneMovel = value; }
        }
        private string _telefoneMovel;
    }
}
