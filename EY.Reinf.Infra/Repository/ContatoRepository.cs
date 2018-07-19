using EY.Reinf.Infra.Context;
using EY.Reinf.Object.Model;

namespace EY.Reinf.Infra.Repository
{
    public class ContatoRepository
    {
        private ContextDB _context = new ContextDB();

        private RepositoryBase<ContatoModel> _contatoRepository;

        public RepositoryBase<ContatoModel> Contato
        {
            get
            {
                if (this._contatoRepository == null)
                {
                    this._contatoRepository = new RepositoryBase<ContatoModel>(_context);
                }

                return _contatoRepository;
            }
        }
    }
}
