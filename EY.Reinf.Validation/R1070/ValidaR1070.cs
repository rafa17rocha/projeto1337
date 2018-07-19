using EY.Reinf.Facede;
using EY.Reinf.Object.Model;
using System;
using System.Collections.Generic;

namespace EY.Reinf.Validation
{
    public class ValidaR1070
    {
        private R1070Model r1070;

        public List<string> Validar(R1070Model r1070)
        {
            this.r1070 = r1070;

            List<string> erros = new List<string>();

            addErro(erros, tpAmb(r1070.tpAmb));
            addErro(erros, procEmi(r1070.procEmi));
            addErro(erros, verProc(r1070.verProc));
            addErro(erros, tpInsc(r1070.tpInsc));
            addErro(erros, nrInsc(r1070.tpInsc, r1070.nrInsc));
            addErro(erros, tpProc(r1070.tpProc));
            addErro(erros, nrProc(r1070.nrProc));
            addErro(erros, iniValid(r1070.iniValid));
            addErro(erros, fimValid(r1070.fimValid, r1070.fimValid));
            addErro(erros, indAutoria(r1070.indAutoria));

            addErro(erros, ufVara(r1070.ufVara));
            addErro(erros, codMunic(r1070.ufVara, r1070.codMunic));
            addErro(erros, idVara(r1070.idVara));
            addErro(erros, TipoOperacao(r1070.TipoOperacao));

            // INFO SUSP

            if(r1070.infoSusp != null)
            {
                for (int i = 0; i < r1070.infoSusp.Count; i++)
                {
                    string reg = "Informações de Suspensão - Linha " + (i + 1) + ": ";

                    InfoSuspModel InfoSusp = r1070.infoSusp[i];

                    ValidaInfoSusp ValidaInfoSusp = new ValidaInfoSusp();

                    List<string> errosInfoSusp = new List<string>();

                    addErro(errosInfoSusp, codSusp(r1070.infoSusp[i].codSusp));
                    addErro(errosInfoSusp, indSusp(r1070.tpProc, r1070.infoSusp[i]));
                    addErro(errosInfoSusp, dtDecisao(r1070.infoSusp[i].dtDecisao));
                    addErro(errosInfoSusp, indDeposito(r1070.tpProc, r1070.infoSusp[i]));

                    foreach (string erro in errosInfoSusp)
                        addErro(erros, reg + erro);
                }
            }

            return erros;
        }

        private void addErro(List<string> lista, string erro)
        {
            if(erro != null)
                lista.Add(erro);
        }

        private string tpAmb(string value)
        {
            string msg = "Identificação do ambiente";
            try
            {
                value = value.Substring(0, 1);
                r1070.tpAmb = value;

                if(!value.Equals("1") && !value.Equals("2"))
                    return msg;
            }
            catch(Exception)
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
                r1070.procEmi = value;

                if(!value.Equals("1") && !value.Equals("2"))
                    return msg;
            }
            catch(Exception)
            {
                return msg;
            }

            return null;
        }

        private string verProc(string value)
        {
            string msg = "Versão do processo de emissão do evento";

            if(string.IsNullOrWhiteSpace(value))
                return msg;

            return null;
        }

        private string tpInsc(string value)
        {
            string msg = "Tipo de inscrição";
            try
            {
                value = value.Substring(0, 1);
                r1070.tpInsc = value;

                if(!value.Equals("1") && !value.Equals("2"))
                    return msg;
            }
            catch(Exception)
            {
                return msg;
            }

            return null;
        }

        private string nrInsc(string tpInscX, string value)
        {
            if(tpInsc(tpInscX) == null)
            {
                string msg = "Número da inscrição";

                try
                {
                    if(tpInscX.Equals("1")) // CNPJ
                    {
                        if(value.Length != 14 || !long.TryParse(value, out long n))
                        {
                            return msg;
                        }
                    }
                    else if(tpInscX.Equals("2")) // CPF
                    {
                        if(value.Length != 11 || !long.TryParse(value, out long n))
                        {
                            return msg;
                        }
                    }
                }
                catch(Exception)
                {
                    return msg;
                }
            }

            return null;
        }

        private string tpProc(string value)
        {
            string msg = "Tipo de processo";
            try
            {
                value = value.Substring(0, 1);
                r1070.tpProc = value;

                if(!value.Equals("1") && !value.Equals("2"))
                    return msg;
            }
            catch(Exception)
            {
                return msg;
            }

            return null;
        }

        private string nrProc(string value) // COMO VALIDAR ?
        {
            string msg = "Número do processo";

            if(!long.TryParse(value, out long n))
            {
                return msg;
            }

            return null;
        }

        private string iniValid(DateTime value) // COMO VALIDAR?
        {
            string msg = "Início da validade";

            if(value == null)
                return msg;

            return null;
        }

        private string fimValid(DateTime iniValidX, DateTime value)
        {
            if(iniValid(iniValidX) == null)
            {
                string msg = "Término da validade";

                if(value == null)
                    return msg;

                return null;
            }
            return null;
        }

        private string indAutoria(string value)
        {
            string msg = "Autoria da ação";
            try
            {
                value = value.Substring(0, 1);
                r1070.indAutoria = value;

                if(!value.Equals("1") && !value.Equals("2"))
                    return msg;
            }
            catch(Exception)
            {
                return msg;
            }

            return null;
        }

        private string codSusp(string value) // COMO VALIDAR?
        {
            string msg = "Código da Suspensão";

            if(value == null)
                return msg;

            return null;
        }

        private string indSusp(string tpProcX, InfoSuspModel value)
        {
            if(tpProc(tpProcX) == null)
            {
                string msg = "Indicativo de suspensão";

                List<string> tpProc1 = new List<string>
                {
                    "03", "90", "92"
                };

                List<string> tpProc2 = new List<string>
                {
                    "01", "02", "04", "05", "08", "09", "10", "11", "12", "13", "90", "92"
                };

                bool achou = false;

                try
                {
                    value.indSusp = value.indSusp.Substring(0, 2);

                    if(tpProcX.Equals("1"))
                    {
                        int count = 0;

                        while(!achou)
                        {
                            string CnpjValue = tpProc1[count];

                            if(CnpjValue.Equals(value.indSusp))
                                achou = true;
                            count++;
                        }
                    }
                    else if(tpProcX.Equals("2"))
                    {
                        int count = 0;

                        while(!achou)
                        {
                            string CpfValue = tpProc2[count];

                            if(CpfValue.Equals(value.indSusp))
                                achou = true;
                            count++;
                        }
                    }
                }
                catch(Exception)
                {
                    return msg;
                }
            }

            return null;
        }

        private string dtDecisao(DateTime value)
        {
            string msg = "Início da validade";
            try
            {
                if(value == null)
                    return msg;
            }
            catch(Exception)
            {
                return msg;
            }

            return null;
        }

        private string indDeposito(string tpProc, InfoSuspModel infoSuspModel)
        {
            if(indSusp(tpProc, infoSuspModel) == null)
            {
                string msg = "Depósito do Montante Integral";

                try
                {
                    infoSuspModel.indDeposito = infoSuspModel.indDeposito.Substring(0, 1);

                    if(infoSuspModel.indSusp.Equals("90"))
                    {
                        if(!infoSuspModel.indDeposito.Equals("N"))
                            return msg;
                    }
                    else if(infoSuspModel.indSusp.Equals("02") || infoSuspModel.indSusp.Equals("03"))
                    {
                        if(!infoSuspModel.indDeposito.Equals("S"))
                            return msg;
                    }
                }
                catch(Exception)
                {
                    return msg;
                }
            }
            return null;
        }

        private string ufVara(string value)
        {
            string msg = "Unidade Federativa";

            List<string> ufs = new List<string>
            {
                "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA",
                "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO", "EX"
            };

            try
            {
                bool achou = false;

                int count = 0;

                while(!achou)
                {
                    string uf = ufs[count];

                    if(uf.Equals(value))
                        achou = true;
                    count++;
                }
            }
            catch(Exception)
            {
                return msg;
            }

            return null;
        }

        private string codMunic(string ufVaraX, string value)
        {
            if(ufVara(ufVaraX) == null)
            {
                string msg = "Município";

                List<string> ufSigla = new List<string>
                {
                    "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA",
                    "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO", "EX",
                };

                List<int> ufCod = new List<int>
                {
                    12, 27, 16, 13, 29, 23, 53, 32, 52, 21, 51, 50, 31, 15,
                    25, 41, 26, 22, 33, 24, 43, 11, 14, 42, 35, 28, 17, 99
                };

                int cod = 0;

                for(int i = 0; i < ufSigla.Count; i++)
                {
                    if(ufSigla[i].Equals(ufVaraX))
                    {
                        cod = ufCod[i];
                        break;
                    }
                }

                MunicipioFacede facede = new MunicipioFacede();

                MunicipioModel model = facede.RetornaDadosMunicipioFacede(value);

                if(model == null)
                    return msg;

                if(model.uf != cod)
                    return msg;
            }

            return null;
        }

        private string idVara(string value)
        {
            string msg = "Identificação da Vara";

            if(string.IsNullOrWhiteSpace(value))
                return msg;

            return null;
        }

        private string TipoOperacao(string value)
        {
            string msg = "Tipo de Operação";

            try
            {
                value = value.Substring(0, 1);
                r1070.TipoOperacao = value;

                if(!value.Equals("1") && !value.Equals("2") && !value.Equals("3"))
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
    }
}
