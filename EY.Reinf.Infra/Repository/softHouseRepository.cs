using EY.Reinf.Infra.Context;
using EY.Reinf.Object.Model;

namespace EY.Reinf.Infra.Repository
{
    public class softHouseRepository
    {
        private ContextDB _context = new ContextDB();

        private RepositoryBase<SoftHouseModel> _softHouseRepository;

        public RepositoryBase<SoftHouseModel> SoftHouse
        {
            get
            {
                if (this._softHouseRepository == null)
                {
                    this._softHouseRepository = new RepositoryBase<SoftHouseModel>(_context);
                }

                return _softHouseRepository;
            }
        }
    }
}
