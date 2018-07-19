using EY.Reinf.Business;
using EY.Reinf.Object.Model;
using System.Collections.Generic;

namespace EY.Reinf.Facede
{
    public class R1070Facede
    {
        private R1070Business _business;
        public R1070Facede()
        {
            _business = new R1070Business();
        }

        public void AdicionarR1070Facede(R1070Model r1070)
        {
            _business.AdicionarR1070Business(r1070);
        }

        public R1070Model RetornaDadosR1070Facede(int Id)
        {
            R1070Model r1070 = new R1070Model();
            r1070.Id = Id;

            r1070 = _business.GetOneR1070(r1070);

            List<InfoSuspModel> infSusps;
            //softHouse.Id = r1000.IdSoftwareHouse;
            infSusps = _business.GetInfoSusps(r1070.Id);
            r1070.infoSusp = infSusps;

            return r1070;
        }
    }
}
