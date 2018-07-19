using EY.Reinf.Infra.Context;
using EY.Reinf.Object.Model;

namespace EY.Reinf.Infra.Repository
{
    public class InfoSupRepository
    {
        private ContextDB _context = new ContextDB();

        private RepositoryBase<InfoSuspModel> _infoSupRepository;

        public RepositoryBase<InfoSuspModel> InfoSusp
        {
            get
            {
                if (this._infoSupRepository == null)
                {
                    this._infoSupRepository = new RepositoryBase<InfoSuspModel>(_context);
                }

                return _infoSupRepository;
            }
        }
    }
}
