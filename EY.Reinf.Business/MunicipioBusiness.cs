using EY.Reinf.Infra.Repository;
using EY.Reinf.Object.Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace EY.Reinf.Business
{
    public class MunicipioBusiness
    {
        MunicipioRepository _municipiosRepository = new MunicipioRepository();

        public List<MunicipioModel> GetMunicipios(int uf)
        {
            Expression<Func<MunicipioModel, bool>> expression = x => x.uf == uf;

            var obj = _municipiosRepository.Municipios.Get(expression);
            return obj;
        }

        public MunicipioModel GetOneMunicipio(MunicipioModel model)
        {
            var obj = _municipiosRepository.Municipios.GetOneByCodigo(model);
            return obj;
        }

    }
}
