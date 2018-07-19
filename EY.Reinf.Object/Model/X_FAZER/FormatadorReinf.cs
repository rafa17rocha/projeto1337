using System;
using System.Text.RegularExpressions;

namespace EY.Reinf.Object.Model
{
    public static class FormatadorReinf
    {
        public static string FormatarCPFCNPJCNO(string cpfcnpj)
        {
            return cpfcnpj == null
                ? string.Empty
                : DeixarSomenteDigitos(cpfcnpj);
        }

        public static string FormatarClassificacaoServico(string codigo)
        {
            //temporario para nao ter que mudar o banco de dados (codigo passou de 2 para 9 digitos)
            if(codigo == null)
                return string.Empty;
            if(codigo.Length == 9)
                return codigo;
            return "1" + codigo.PadLeft(8, '0');
        }

        public static string FormatarTelefone(string telefone)
        {
            return telefone == null
                ? string.Empty
                : DeixarSomenteDigitos(telefone);
        }

        private static string DeixarSomenteDigitos(string cpfcnpj)
        {
            return Regex.Replace(cpfcnpj, "[^0-9]", string.Empty);
        }

        public static string FormatarMesAno(DateTime mesAno)
        {
            return mesAno > DateTime.MinValue
                ? mesAno.ToString("yyyy-MM")
                : string.Empty;
        }

        public static string FormatarData(DateTime mesAno)
        {
            return mesAno > DateTime.MinValue
                ? mesAno.ToString("yyyy-MM-dd")
                : string.Empty;
        }

        public static string FormatarInteiro(int numeroInteiro)
        {
            return numeroInteiro.ToString();
        }

        public static string FormatarMoeda(decimal valorMonetario)
        {
            return valorMonetario.ToString("0.00").Replace('.', ',');
        }

        public static string FormatarSimNao(bool flag)
        {
            return flag ? "S" : "N";
        }

        public static string FormatarGenerico(string txt)
        {
            if(txt == null)
                txt = string.Empty;
            txt = RemoverCaracteresInvalidosXML(txt);
            return txt;
        }

        private static string RemoverCaracteresInvalidosXML(string txt)
        {
            txt = txt.Replace("&", "&amp;"); //esse tem que ser o primeiro
            txt = txt.Replace(">", "&gt;");
            txt = txt.Replace("<", "&lt;");
            txt = txt.Replace("#", string.Empty);
            txt = txt.Replace("--", string.Empty);
            txt = txt.Replace("'", string.Empty);
            txt = txt.Replace("\"", string.Empty);
            txt = txt.Replace(System.Environment.NewLine, string.Empty);
            txt = txt.Trim();
            return txt;
        }
    }
}
