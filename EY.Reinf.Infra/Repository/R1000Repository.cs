using EY.Reinf.Infra.Context;
using EY.Reinf.Object.Model;

namespace EY.Reinf.Infra.Repository
{
    public class R1000Repository
    {
        private ContextDB _context = new ContextDB();

        private RepositoryBase<R1000Model> _r1000Repository;

        public RepositoryBase<R1000Model> R1000
        {
            get
            {
                if (this._r1000Repository == null)
                {
                    this._r1000Repository = new RepositoryBase<R1000Model>(_context);
                }

                return _r1000Repository;
            }
        }
    }
}
