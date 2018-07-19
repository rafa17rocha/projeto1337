using EY.Reinf.Business;
using EY.Reinf.Object.Model;
using System.Collections.Generic;

namespace EY.Reinf.Facede
{
    public class R1000Facede
    {
        private R1000Business _business;
        public R1000Facede()
        {
            _business = new R1000Business();
        }

        public void AdicionarR1000Facede(R1000Model r1000)
        {
            _business.AdicionarR1000Business(r1000);
        }

        public R1000Model RetornaDadosR1000Facede(int Id)
        {
            R1000Model r1000 = new R1000Model();
            r1000.Id = Id;

            r1000 = _business.GetOneR1000(r1000);

            ContatoModel contato = new ContatoModel();
            //contato.IdR1000 = r1000.Id;
            contato = _business.GetOneContato(r1000.Id);
            r1000.contato = contato;

            List<SoftHouseModel> softHouses;
            //softHouse.Id = r1000.IdSoftwareHouse;
            softHouses = _business.GetSoftHouses(r1000.Id);
            r1000.softwareHouse = softHouses;

            return r1000;
        }
    }
}
