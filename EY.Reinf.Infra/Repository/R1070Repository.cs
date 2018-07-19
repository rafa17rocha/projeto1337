using EY.Reinf.Infra.Context;
using EY.Reinf.Object.Model;

namespace EY.Reinf.Infra.Repository
{
    public class R1070Repository
    {
        private ContextDB _context = new ContextDB();

        private RepositoryBase<R1070Model> _R1070Repository;

        public RepositoryBase<R1070Model> R1070
        {
            get
            {
                if(this._R1070Repository == null)
                {
                    this._R1070Repository = new RepositoryBase<R1070Model>(_context);
                }

                return _R1070Repository;
            }
        }
    }
}
