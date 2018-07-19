using EY.Reinf.Infra.Repository;
using EY.Reinf.Object.Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace EY.Reinf.Business
{
    public class R1070Business
    {
        R1070Repository _R1070Repository = new R1070Repository();
        InfoSupRepository _infoSupRepository = new InfoSupRepository();

        public void AdicionarR1070Business(R1070Model r1070)
        {
            r1070 = _R1070Repository.R1070.AddReturn(r1070);


            foreach (InfoSuspModel item in r1070.infoSusp)
            {
                item.IdR1070 = r1070.Id;
            }

            var softHouse = AdicionarSoftHouses(r1070.infoSusp);
        }

        public List<InfoSuspModel> AdicionarSoftHouses(List<InfoSuspModel> infoSusps)
        {
            return _infoSupRepository.InfoSusp.AddAllReturn(infoSusps);
        }

        public R1070Model GetOneR1070(R1070Model model)
        {
            var obj = _R1070Repository.R1070.GetOne(model);
            return obj;
        }

        public List<InfoSuspModel> GetInfoSusps(int r1070Id)
        {
            Expression<Func<InfoSuspModel, bool>> expression = x => x.IdR1070 == r1070Id;

            var obj = _infoSupRepository.InfoSusp.Get(expression);
            return obj;
        }
    }
}
