using EY.Reinf.Object.Model;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace EY.Reinf.Validation
{
    public class ValidaR1000
    {
        private R1000Model r1000;

        public List<string> Validar(R1000Model r1000)
        {
            this.r1000 = r1000;

            List<string> erros = new List<string>();

            addErro(erros, tpAmb(r1000.tpAmb));
            addErro(erros, procEmi(r1000.procEmi));
            addErro(erros, verProc(r1000.verProc));
            addErro(erros, tpInsc(r1000.tpInsc));
            addErro(erros, nrInsc(r1000.tpInsc, r1000.nrInsc));
            addErro(erros, iniValid(r1000.iniValid));
            addErro(erros, fimValid(r1000.iniValid, r1000.fimValid));
            addErro(erros, classTrib(r1000.tpInsc, r1000.classTrib));
            addErro(erros, indEscrituracao(r1000.indEscrituracao));
            addErro(erros, indDesoneracao(r1000.indDesoneracao));
            addErro(erros, indAcordoIsenMulta(r1000.tpInsc, r1000.classTrib, r1000.indAcordoIsenMulta));
            addErro(erros, indSitPJ(r1000.tpInsc, r1000.indSitPJ));

            // CONTATO
            addErro(erros, nmCtt(r1000.contato.nmCtt));
            addErro(erros, cpfCtt(r1000.contato.cpfCtt));

            if(foneCel(r1000.contato.foneCel) != null && foneFixo(r1000.contato.foneFixo) != null)
                addErro(erros, foneCel(r1000.contato.foneCel) + " ou " + foneFixo(r1000.contato.foneFixo));
            else if(foneCel(r1000.contato.foneCel) != null)
                addErro(erros, foneFixo(r1000.contato.foneFixo));
            else
                addErro(erros, foneCel(r1000.contato.foneCel));

            addErro(erros, email(r1000.contato.email));

            //SOFTHOUSE

            if(r1000.softwareHouse != null)
            {
                for (int i = 0; i < r1000.softwareHouse.Count; i++)
                {
                    string reg = "SoftHouse - Linha " + (i + 1) + ": ";

                    SoftHouseModel softwareHouse = r1000.softwareHouse[i];

                    ValidaSoftHouse validaSoftHouse = new ValidaSoftHouse();

                    List<string> errosSoftHouse = validaSoftHouse.Validar(softwareHouse);

                    foreach (string erro in errosSoftHouse)
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
                r1000.tpAmb = value;

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
                r1000.procEmi = value;

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
                r1000.tpInsc = value;

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

        private string iniValid(DateTime value) // COMO VALIDAR?
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

        private string fimValid(DateTime iniValidvalue, DateTime value)
        {
            if(iniValid(iniValidvalue) == null)
            {
                string msg = "Término da validade";
                try
                {
                    if(DateTime.Compare(iniValidvalue, value) >= 0)
                        return msg;
                }
                catch(Exception)
                {
                    return msg;
                }
            }
            return null;
        }

        private string classTrib(string tpInscvalue, string value)
        {
            if(tpInsc(tpInscvalue) == null)
            {
                string msg = "Classificação Tributária";

                

                List<string> CnpjValues = new List<string>
                {
                    "01", "02", "03", "04", "06", "07", "08", "09", "10", "11", "13", "14", "60", "70", "80", "85", "99"
                };

                List<string> CpfValues = new List<string>
                {
                    "21", "22"
                };

                bool achou = false;

                try
                {
                    value = value.Substring(0, 2);
                    r1000.classTrib = value;

                    if(tpInscvalue.Equals("1")) // CNPJ
                    {
                        int count = 0;

                        while(!achou)
                        {
                            string CnpjValue = CnpjValues[count];

                            if(CnpjValue.Equals(value))
                                achou = true;
                            count++;
                        }
                    }
                    else if(tpInscvalue.Equals("2")) // CPF
                    {
                        int count = 0;

                        while(!achou)
                        {
                            string CpfValue = CpfValues[count];

                            if(CpfValue.Equals(value))
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

        private string indEscrituracao(string value)
        {
            string msg = "Obrigatoriedade do ECD";

            try
            {
                value = value.Substring(0, 1);
                r1000.indEscrituracao = value;

                if(!value.Equals("0") && !value.Equals("1"))
                    return msg;
            }
            catch(Exception)
            {
                return msg;
            }

            return null;
        }

        private string indDesoneracao(string value)
        {
            string msg = "Desoneração da folha pela CPRB";

            try
            {
                value = value.Substring(0, 1);
                r1000.indDesoneracao = value;

                if(!value.Equals("0") && !value.Equals("1"))
                    return msg;
            }
            catch(Exception)
            {
                return msg;
            }

            return null;
        }

        private string indAcordoIsenMulta(string tpInsc, string classTribX, string value)
        {
            if(classTrib(tpInsc, classTribX) == null)
            {
                string msg = "Acordo da isenção de multa";

                try
                {
                    value = value.Substring(0, 1);
                    r1000.indAcordoIsenMulta = value;

                    bool c1 = value.Equals("1");
                    bool c2 = !classTribX.Equals("60");
                    bool c3 = !value.Equals("0");

                    if(c1)
                    {
                        if(c2)
                            return msg;
                    }
                    else if(c3)
                        return msg;
                }
                catch(Exception)
                {
                    return msg;
                }
            }

            return null;
        }

        private string indSitPJ(string tpInscX, string value)
        {
            if(tpInsc(tpInscX) == null)
            {
                string msg = "Situação da Pessoa Jurídica";

                try
                {
                    if(tpInscX.Equals("1"))
                    {
                        value = value.Substring(0, 1);
                        r1000.indSitPJ = value;

                        if(!value.Equals("0") && !value.Equals("1") && !value.Equals("2") && !value.Equals("3") && !value.Equals("4"))
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

        private string nmCtt(string value)
        {
            string msg = "Nome do contato";

            if(string.IsNullOrWhiteSpace(value))
                return msg;

            return null;
        }

        private string cpfCtt(string value)
        {
            string msg = "CPF do contato";

            try
            {
                if(value.Length != 11 || !long.TryParse(value, out long n))
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

        private string foneFixo(string value)
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

        private string foneCel(string value)
        {
            string msg = "Telefone celular";

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

        private string ideEFR(string value)
        {
            string msg = "É o EFR";

            try
            {
                value = value.Substring(0, 1);
                r1000.ideEFR = value;

                if(!value.Equals("S") && !value.Equals("N"))
                    return msg;
            }
            catch(Exception)
            {
                return msg;
            }

            return null;
        }

        private string cnpjEFR(string ideEFRX, string value)
        {
            if(ideEFR(ideEFRX) == null)
            {
                if(ideEFRX.Equals("N"))
                {
                    string msg = "CNPJ do EFR";

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
                }
            }

            return null;
        }

        private string TipoOperacao(string value)
        {
            string msg = "Tipo de Operação";

            try
            {
                value = value.Substring(0, 1);
                r1000.TipoOperacao = value;

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
