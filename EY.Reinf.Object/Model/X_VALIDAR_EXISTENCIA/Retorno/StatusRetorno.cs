namespace EY.Reinf.Object.Model.VALIDAR.Retorno
{
    public class StatusRetorno
    {
        public string Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }
        private string _codigo;

        public string Descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }
        private string _descricao;
    }
}
