using EY.Reinf.Infra.Repository;
using EY.Reinf.Object.Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace EY.Reinf.Business
{
    public class R1000Business
    {
        R1000Repository _R1000Repository = new R1000Repository();
        ContatoRepository _contatoRepository = new ContatoRepository();
        softHouseRepository _softHouseRepository = new softHouseRepository();

        public ContatoModel AdicionarContato(ContatoModel contato)
        {
            return _contatoRepository.Contato.AddReturn(contato);
        }

        public List<SoftHouseModel> AdicionarSoftHouses(List<SoftHouseModel> softHouses)
        {
            return _softHouseRepository.SoftHouse.AddAllReturn(softHouses);
        }

        public void AdicionarR1000Business(R1000Model r1000)
        {
            r1000 = _R1000Repository.R1000.AddReturn(r1000);

            r1000.contato.IdR1000 = r1000.Id;
            ContatoModel contato = AdicionarContato(r1000.contato);
            //r1000.IdContato = contato.Id;

            foreach(SoftHouseModel item in r1000.softwareHouse)
            {
                item.IdR1000 = r1000.Id;
            }

            var softHouse = AdicionarSoftHouses(r1000.softwareHouse);
            //r1000.IdSoftwareHouse = softHouse.Id;

        }

        public R1000Model GetOneR1000(R1000Model model)
        {
            var obj = _R1000Repository.R1000.GetOne(model);
            return obj;
        }

        //public ContatoModel GetOneContato(ContatoModel model)
        //{
        //    string id = nameof(model.IdR1000);
        //    var obj = _contatoRepository.Contato.GetOne(model, id);
        //    return obj;
        //}

        public ContatoModel GetOneContato(int r1000Id)
        {
            Expression<Func<ContatoModel, bool>> expression = x => x.IdR1000 == r1000Id;

            var obj = _contatoRepository.Contato.Get(expression);

            if(obj != null)
                return obj[0];

            return null;
        }

        public List<SoftHouseModel> GetSoftHouses(int r1000Id)
        {
            Expression<Func<SoftHouseModel, bool>> expression = x => x.IdR1000 == r1000Id;

            var obj = _softHouseRepository.SoftHouse.Get(expression);
            return obj;
        }

    }
}
