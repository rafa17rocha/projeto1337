using EY.Reinf.Object.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EY.Reinf.Validation
{
    public class ValidaInfoSusp
    {
        private InfoSuspModel infoSuspModel;

        public List<string> Validar(InfoSuspModel infoSuspModel)
        {
            this.infoSuspModel = infoSuspModel;

            List<string> erros = new List<string>();

            addErro(erros, codSusp(infoSuspModel.codSusp));
            addErro(erros, indSusp(infoSuspModel.indSusp));
            addErro(erros, dtDecisao(infoSuspModel.dtDecisao));
            addErro(erros, indDeposito(infoSuspModel.indDeposito));

            return erros;
        }

        private void addErro(List<string> lista, string erro)
        {
            if (erro != null)
                lista.Add(erro);
        }

        private string codSusp(string value) // COMO VALIDAR?
        {
            string msg = "Código da Suspensão";

            if (value == null)
                return msg;

            return null;
        }


        private string dtDecisao(DateTime value)
        {
            string msg = "Início da validade";
            try
            {
                if (value == null)
                    return msg;
            }
            catch (Exception)
            {
                return msg;
            }

            return null;
        }

        private string indDeposito(string value)
        {
            string msg = "Depósito do Montante Integral";

            try
            {
                value = value.Substring(0, 1);
                infoSuspModel.indDeposito = value;

                if (!value.Equals("N") && !value.Equals("S"))
                    return msg;
            }
            catch (Exception)
            {
                return msg;
            }
            return null;
        }

        private string indSusp(string value)
        {
                string msg = "Indicativo de suspensão";

                List<string> tpProc = new List<string>
                {
                    "01", "02", "03", "04", "05", "08", "09", "10", "11", "12", "13", "90", "92"
                };

                bool achou = false;

                try
                {
                    value = value.Substring(0, 2);
                    infoSuspModel.indSusp = value;

                    int count = 0;

                    while (!achou)
                    {
                        string CnpjValue = tpProc[count];

                        if (CnpjValue.Equals(value))
                            achou = true;
                        count++;
                    }
                }
                catch (Exception)
                {
                    return msg;
                }

            return null;
        }
    }
}
