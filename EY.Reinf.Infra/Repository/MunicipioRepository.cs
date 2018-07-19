using EY.Reinf.Infra.Context;
using EY.Reinf.Object.Model;

namespace EY.Reinf.Infra.Repository
{
    public class MunicipioRepository
    {
        private ContextDB _context = new ContextDB();

        private RepositoryBase<MunicipioModel> _municipiosRepository;

        public RepositoryBase<MunicipioModel> Municipios
        {
            get
            {
                if(this._municipiosRepository == null)
                {
                    this._municipiosRepository = new RepositoryBase<MunicipioModel>(_context);
                }

                return _municipiosRepository;
            }
        }
    }
}
