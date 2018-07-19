using EY.Reinf.Object.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EY.Reinf.Validation
{
    public class ValidaSoftHouse
    {
        public List<string> Validar(SoftHouseModel softwareHouse)
        {
            List<string> erros = new List<string>();

            addErro(erros, cnpjSoftHouse(softwareHouse.cnpjSoftHouse));
            addErro(erros, nmRazao(softwareHouse.nmRazao));
            addErro(erros, nmCont(softwareHouse.nmCont));
            addErro(erros, telefone(softwareHouse.telefone));
            addErro(erros, email(softwareHouse.email));

            return erros;
        }

        private void addErro(List<string> lista, string erro)
        {
            if(erro != null)
                lista.Add(erro);
        }

        private string cnpjSoftHouse(string value)
        {
            string msg = "CNPJ do contato";

            try
            {
                if(value.Length != 14 || !long.TryParse(value, out long n))
                {
                    return msg;
                }
            }
            catch(Exception)
            {
                return msg;
            }

            return null;
        }

        private string nmRazao(string value)
        {
            string msg = "Razão Social";

            if(string.IsNullOrWhiteSpace(value))
                return msg;

            return null;
        }

        private string nmCont(string value)
        {
            string msg = "Nome do contato";

            if(string.IsNullOrWhiteSpace(value))
                return msg;

            return null;
        }

        private string telefone(string value)
        {
            string msg = "Telefone Fixo";

            try
            {
                if(value.Length < 10 || !long.TryParse(value, out long n))
                {
                    return msg;
                }
            }
            catch(Exception)
            {
                return msg;
            }

            return null;
        }

        private string email(string value)
        {
            string msg = "Email";

            //Regex rg = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");
            Regex rg = new Regex(@"^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$");

            if(!rg.IsMatch(value))
                return msg;

            return null;
        }

    }
}
