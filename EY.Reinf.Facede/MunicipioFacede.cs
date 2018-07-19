using EY.Reinf.Business;
using EY.Reinf.Object.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EY.Reinf.Facede
{
    public class MunicipioFacede
    {
        private MunicipioBusiness _business;
        public MunicipioFacede()
        {
            _business = new MunicipioBusiness();
        }

        public List<MunicipioModel> RetornaDadosMunicipiosFacede(int uf)
        {
            List<MunicipioModel> municipios;
            //municipios.uf = uf;

            municipios = _business.GetMunicipios(uf);

            return municipios;
        }

        public MunicipioModel RetornaDadosMunicipioFacede(string codigo)
        {
            MunicipioModel model = new MunicipioModel();
            model.codigo = codigo;

            model = _business.GetOneMunicipio(model);

            return model;
        }
    }
}
