using EY.Reinf.Object.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EY.Reinf.Validation
{
    public class ValidaR2010
    {
        private R2010Model r2010;

        public List<string> Validar(R2010Model r2010)
        {
            this.r2010 = r2010;
            // nrInscEstab : ATENTAR ÀS REGRAS

            List<string> erros = new List<string>();


            //// INFO SUSP

            //if (r2010.infoSusp != null)
            //{
            //    for (int i = 0; i < r2010.infoSusp.Count; i++)
            //    {
            //        string reg = "Informações de Suspensão - Linha " + (i + 1) + ": ";

            //        InfoSuspModel InfoSusp = r2010.infoSusp[i];

            //        ValidaInfoSusp ValidaInfoSusp = new ValidaInfoSusp();

            //        List<string> errosInfoSusp = new List<string>();

            //        addErro(errosInfoSusp, codSusp(r2010.infoSusp[i].codSusp));
            //        addErro(errosInfoSusp, indSusp(r2010.tpProc, r2010.infoSusp[i]));
            //        addErro(errosInfoSusp, dtDecisao(r2010.infoSusp[i].dtDecisao));
            //        addErro(errosInfoSusp, indDeposito(r2010.tpProc, r2010.infoSusp[i]));

            //        foreach (string erro in errosInfoSusp)
            //            addErro(erros, reg + erro);
            //    }
            //}

            return erros;
        }

        private void addErro(List<string> lista, string erro)
        {
            if (erro != null)
                lista.Add(erro);
        }

        private string indRetif(string value)
        {
            string msg = "Indicativo de Retificação";
            try
            {
                value = value.Substring(0, 1);
                r1000.indRetif = value;

                if (!value.Equals("1") && !value.Equals("2"))
                    return msg;
            }
            catch (Exception)
            {
                return msg;
            }

            return null;
        }

        private string nrRecibo(string indRetifX, string value)
        {
            string msg = "Número do Recibo";

            if (indRetif(indRetifX) != null)
                return null;

            bool obrigatorio = indRetifX.Equals("2");

            if (obrigatorio && string.IsNullOrWhiteSpace(value))
                return msg;

            return null;
        }

        private string perApur(string value)
        {
            string msg = "Período de Apuração";

            if (value == null)
                return msg;

            return null;
        }

        private string tpAmb(string value)
        {
            string msg = "Identificação do ambiente";
            try
            {
                value = value.Substring(0, 1);
                r1000.tpAmb = value;

                if (!value.Equals("1") && !value.Equals("2"))
                    return msg;
            }
            catch (Exception)
            {
                return msg;
            }

            return null;
        }

        private string procEmi(string value)
        {
            string msg = "Processo de emissão do evento";
            try
            {
                value = value.Substring(0, 1);
                r1000.procEmi = value;

                if (!value.Equals("1") && !value.Equals("2"))
                    return msg;
            }
            catch (Exception)
            {
                return msg;
            }

            return null;
        }

        private string verProc(string value)
        {
            string msg = "Versão do processo de emissão do evento";

            if (string.IsNullOrWhiteSpace(value))
                return msg;

            return null;
        }

        private string tpInsc(string value)
        {
            string msg = "Tipo de inscrição";
            try
            {
                value = value.Substring(0, 1);
                r1000.tpInsc = value;

                if (!value.Equals("1") && !value.Equals("2"))
                    return msg;
            }
            catch (Exception)
            {
                return msg;
            }

            return null;
        }

        private string nrInsc(string tpInscX, string value)
        {
            if (tpInsc(tpInscX) == null)
            {
                string msg = "Número da inscrição";

                try
                {
                    if (tpInscX.Equals("1")) // CNPJ
                    {
                        if (value.Length != 14 || !long.TryParse(value, out long n))
                        {
                            return msg;
                        }
                    }
                    else if (tpInscX.Equals("2")) // CPF
                    {
                        if (value.Length != 11 || !long.TryParse(value, out long n))
                        {
                            return msg;
                        }
                    }
                }
                catch (Exception)
                {
                    return msg;
                }
            }

            return null;
        }

        private string tpInscEstab(string value)
        {
            string msg = "Tipo de inscrição";
            try
            {
                value = value.Substring(0, 1);

                if (!value.Equals("1") && !value.Equals("2"))
                    return msg;

                r1000.tpInscEstab = value;
            }
            catch (Exception)
            {
                return msg;
            }

            return null;
        }

        private string nrInscEstab(R2010Model r2010, string value)
        {
            string msg = "Número de inscrição";

            if (tpInscEstab(r2010.tpInscEstab) != null)
                return null;

            if (indObra(r2010.indObra) != null)
                return null;

            if (r2010.indObra.Equals("0"))
                r2010.nrInscEstab = r2010.nrInsc; // E SE FOR CPF?

            if (r2010.indObra.Equals("1") || r2010.indObra.Equals("2"))
                if (string.IsNullOrWhiteSpace(value))
                    return msg;

           return null;
        }

        private string indObra(string value)
        {
            string msg = "Indicativo de obra";

            try
            {
                value = value.Substring(0, 1);

                if(value.Equals("0") || value.Equals("1") || value.Equals("2"))

                r1070.indObra = value;
            }
            catch (Exception)
            {
                return msg;
            }

            return null;
        }

        private string cnpjPrestador(string value)
        {
            string msg = "Indicativo de obra";

            if (value.Length != 14 || !long.TryParse(value, out long n))
                return msg;

            return null;
        }

        private string vlrTotalBruto(R2010Model r2010)
        {
            string msg = "Valor bruto da(s) nota(s) fiscal(is) ";

            if (r2010.nfsModel.Count == 0)
                return null;

            List<NfsModel> notas = r2010.nfsModel;

            double soma = 0.0;

            try
            {
                foreach (NfsModel nota in notas)
                    soma += Convert.ToDouble(nota.vlrBruto);

                r2010.vlrTotalBruto = soma.ToString();
            }
            catch (Exception)
            {
                return msg;
            }

            return null;
        }

        private string vlrTotalBaseRet(string value)
        {
            string msg = "Soma da base de cálculo da retenção da contribuição " +
                "previdenciária das notas fiscais emitidas para o contratante";

            if (r2010.infoTpServ.Count == 0)
                return null;

            List<InfoTpServModel> infos = r2010.infoTpServ;

            double soma = 0.0;

            try
            {
                foreach (InfoTpServModel info in infos)
                    soma += Convert.ToDouble(info.vlrBaseRet);

                r2010.vlrTotalBruto = soma.ToString();
            }
            catch (Exception)
            {
                return msg;
            }

            return null;
        }

        private string vlrTotalRetPrinc(string value)
        {
            string msg = "Soma do valor da retenção das notas fiscais " +
                "de serviço emitidas para o contratante";

            if (r2010.nfsModel.Count == 0)
                return null;

            List<InfoTpServModel> notas = r2010.infoTpServ;

            double soma = 0.0;

            try
            {
                InfoTpServModel info;

                for (int i = 0; i < notas.Count; i++)
                {
                    info = notas[i];
                    soma += Convert.ToDouble(info.vlrRetencao);
                }

                if()

                r2010.vlrTotalBruto = soma.ToString();
            }
            catch (Exception)
            {
                return msg;
            }

            return null;
        }
        

        // DAQUI PRA BAIXO RETORNA NULL

        private string vlrTotalRetAdic(string value)
        {
            return null;
        }

        private string vlrTotalNRetPrinc(string value)
        {
            return null;
        }

        private string vlrTotalNRetAdic(string value)
        {
            return null;
        }

        private string indCPRB(string value)
        {
            return null;
        }

        private string serie(string value)
        {
            return null;
        }

        private string numDocto(string value)
        {
            return null;
        }

        private string dtEmissaoNF(string value)
        {
            return null;
        }

        private string vlrBruto(string value)
        {
            return null;
        }

        private string obs(string value)
        {
            return null;
        }

        private string tpServico(string value)
        {
            return null;
        }

        private string vlrBaseRet(string value)
        {
            return null;
        }

        private string vlrRetencao(string value)
        {
            return null;
        }

        private string vlrRetSub(string value)
        {
            return null;
        }

        private string vlrNRetPrinc(string value)
        {
            return null;
        }

        private string vlrServicos15(string value)
        {
            return null;
        }

        private string vlrServicos20(string value)
        {
            return null;
        }

        private string vlrServicos25(string value)
        {
            return null;
        }

        private string vlrAdicional(string value)
        {
            return null;
        }

        private string vlrNRetAdic(string value)
        {
            return null;
        }

        private string tpProcRetPrinc(string value)
        {
            return null;
        }

        private string nrProcRetPrinc(string value)
        {
            return null;
        }

        private string codSuspPrinc(string value)
        {
            return null;
        }

        private string valorPrinc(string value)
        {
            return null;
        }

        private string tpProcRetAdic(string value)
        {
            return null;
        }

        private string nrProcRetAdic(string value)
        {
            return null;
        }

        private string codSuspAdic(string value)
        {
            return null;
        }

        private string valorAdic(string value)
        {
            return null;
        }
    }
}
