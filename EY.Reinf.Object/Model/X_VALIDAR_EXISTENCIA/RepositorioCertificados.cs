using System;
using System.Security.Cryptography.X509Certificates;

namespace EY.Reinf.Object.Model.VALIDAR
{
    public class RepositorioCertificados
    {
        public static X509Certificate2 ObterCertificado(string numeroSerie)
        {
            if(String.IsNullOrEmpty(numeroSerie))
                throw new ArgumentException("numeroSerie");

            X509Certificate2 certificado = null;

            X509Certificate2Collection certificados = ObterCertificados();
            X509Certificate2Collection colecao = (X509Certificate2Collection)
                certificados.Find(X509FindType.FindBySerialNumber, numeroSerie, false);

            if(colecao.Count == 1)
                certificado = colecao[0];

            return certificado;
        }

        public static X509Certificate2Collection ObterCertificadosValidos()
        {
            return ObterCertificados(false);
        }

        public static X509Certificate2Collection ObterCertificados()
        {
            return ObterCertificados(true);
        }

        private static X509Certificate2Collection ObterCertificados(bool somenteValidos)
        {
            X509Store store = new X509Store(StoreName.My, StoreLocation.CurrentUser);

            store.Open(OpenFlags.ReadOnly);

            X509Certificate2Collection todosCertificados = (X509Certificate2Collection) store.Certificates;
            X509Certificate2Collection certificadosAssinaturaDigital = (X509Certificate2Collection)
                todosCertificados.Find(X509FindType.FindByKeyUsage, X509KeyUsageFlags.DigitalSignature, somenteValidos);
            return certificadosAssinaturaDigital;
        }
    }
}
