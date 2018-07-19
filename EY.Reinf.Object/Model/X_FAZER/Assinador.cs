using System;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Xml;
using System.Xml;

namespace EY.Reinf.Object.Model
{
    public enum TipoAssinatura
    {
        Sha1,
        Sha256
    }


    public class Assinador
    {
        public X509Certificate2 Certificado
        {
            get { return _certificado; }
            set { _certificado = value; }
        }
        private X509Certificate2 _certificado;

        private int _vResultado;
        private string _vResultadoString;
        private string _vXMLStringAssinado;
        private XmlDocument XMLDoc;

        public int vResultado
        {
            get
            {
                return _vResultado;
            }
            set
            {
                _vResultado = value;
            }
        }

        public string vResultadoString
        {
            get
            {
                return _vResultadoString;
            }
            set
            {
                _vResultadoString = value;
            }
        }

        public string vXMLStringAssinado
        {
            get
            {
                return _vXMLStringAssinado;
            }
            set
            {
                _vXMLStringAssinado = value;
            }
        }

        public XmlDocument Assinar(string lsConteudoXML, string pUri, X509Certificate2 pCertificado, TipoAssinatura tipoassinatura, string idUri)
        {
            pUri = "Reinf";

            //Abrir o arquivo XML a ser assinado e ler o seu conteúdo
            string vXMLString = lsConteudoXML;
            //if (!string.IsNullOrEmpty(pArqXMLAssinar))
            //{
            //    using (StreamReader SR = File.OpenText(pArqXMLAssinar))
            //    {
            //        vXMLString = SR.ReadToEnd();
            //        SR.Close();
            //    }
            //}

            //Atualizar atributos de retorno com conteúdo padrão
            this.vResultado = 0;
            this.vResultadoString = "Assinatura realizada com sucesso";

            try
            {
                // Verifica o certificado a ser utilizado na assinatura
                string _xnome = "";
                if(pCertificado != null)
                {
                    _xnome = pCertificado.Subject.ToString();
                }

                X509Certificate2 _X509Cert = new X509Certificate2();
                X509Store store = new X509Store("MY", StoreLocation.CurrentUser);
                store.Open(OpenFlags.ReadOnly | OpenFlags.OpenExistingOnly);
                X509Certificate2Collection collection = (X509Certificate2Collection) store.Certificates;
                X509Certificate2Collection collection1 = (X509Certificate2Collection) collection.Find(X509FindType.FindBySubjectDistinguishedName, _xnome, false);

                if(collection1.Count == 0)
                {
                    this.vResultado = 2;
                    this.vResultadoString = "Problemas no certificado digital";
                }
                else
                {
                    // certificado ok
                    _X509Cert = collection1[0];
                    string x;
                    x = _X509Cert.GetKeyAlgorithm().ToString();

                    // Create a new XML document.
                    XmlDocument doc = new XmlDocument();

                    // Format the document to ignore white spaces.
                    doc.PreserveWhitespace = false;

                    // Load the passed XML file using it’s name.
                    try
                    {
                        doc.LoadXml(vXMLString);

                        // Verifica se a tag a ser assinada existe é única
                        int qtdeRefUri = doc.GetElementsByTagName(pUri).Count;

                        if(qtdeRefUri == 0)
                        {
                            // a URI indicada não existe
                            this.vResultado = 4;
                            this.vResultadoString = "A tag de assinatura " + pUri.Trim() + " não existe";
                        }
                        // Exsiste mais de uma tag a ser assinada
                        else
                        {
                            if(qtdeRefUri > 1)
                            {
                                // existe mais de uma URI indicada
                                this.vResultado = 5;
                                this.vResultadoString = "A tag de assinatura " + pUri.Trim() + " não é unica";
                            }
                            else
                            {
                                try
                                {
                                    // Create a SignedXml object.
                                    SignedXml signedXml = new SignedXml(doc);

                                    #region Alteracao01
                                    //                                if (!COM_Pin) &&
                                    //clsX509Certificate2Extension.IsA3(x509Cert) &&
                                    //!Empresas.Configuracoes[empresa].CertificadoPINCarregado)
                                    //                                {
                                    //                                    x509Cert.SetPinPrivateKey(Empresas.Configuracoes[empresa].CertificadoPIN);
                                    //                                    Empresas.Configuracoes[empresa].CertificadoPINCarregado = true;
                                    //                                }

                                    if(tipoassinatura == TipoAssinatura.Sha256)
                                    {
                                        signedXml.SignedInfo.SignatureMethod = "http://www.w3.org/2001/04/xmldsig-more#rsa-sha256";
                                        signedXml.SigningKey = _X509Cert.GetRSAPrivateKey();
                                    }
                                    else
                                    {
                                        signedXml.SigningKey = _X509Cert.PrivateKey;
                                    }
                                    #endregion Alteracao01

                                    // Add the key to the SignedXml document
                                    //signedXml.SigningKey = _X509Cert.PrivateKey;

                                    // Create a reference to be signed
                                    Reference reference = new Reference();

                                    // pega o uri que deve ser assinada
                                    XmlAttributeCollection _Uri = doc.GetElementsByTagName(pUri).Item(0).Attributes;
                                    reference.Uri = "#" + idUri;

                                    //foreach (XmlAttribute _atributo in _Uri)
                                    //{
                                    //    if (_atributo.Name == "Id")
                                    //    {
                                    //        reference.Uri = "#" + _atributo.InnerText;
                                    //    }
                                    //}

                                    // Add an enveloped transformation to the reference.
                                    XmlDsigEnvelopedSignatureTransform env = new XmlDsigEnvelopedSignatureTransform();
                                    reference.AddTransform(env);

                                    XmlDsigC14NTransform c14 = new XmlDsigC14NTransform();
                                    reference.AddTransform(c14);

                                    // Add the reference to the SignedXml object.
                                    signedXml.AddReference(reference);
                                    #region Alteracao2
                                    if(tipoassinatura == TipoAssinatura.Sha256)
                                    {
                                        reference.DigestMethod = "http://www.w3.org/2001/04/xmlenc#sha256";
                                    }
                                    #endregion Alteracao2

                                    // Create a new KeyInfo object
                                    KeyInfo keyInfo = new KeyInfo();

                                    // Load the certificate into a KeyInfoX509Data object
                                    // and add it to the KeyInfo object.
                                    keyInfo.AddClause(new KeyInfoX509Data(_X509Cert));

                                    // Add the KeyInfo object to the SignedXml object.
                                    signedXml.KeyInfo = keyInfo;
                                    signedXml.ComputeSignature();

                                    // Get the XML representation of the signature and save
                                    // it to an XmlElement object.
                                    XmlElement xmlDigitalSignature = signedXml.GetXml();

                                    // Gravar o elemento no documento XML
                                    doc.DocumentElement.AppendChild(doc.ImportNode(xmlDigitalSignature, true));
                                    XMLDoc = new XmlDocument();
                                    XMLDoc.PreserveWhitespace = false;
                                    XMLDoc = doc;

                                    // Atualizar a string do XML já assinada
                                    this.vXMLStringAssinado = XMLDoc.OuterXml;

                                    // Gravar o XML no HD
                                    //wob alterei
                                    //StreamWriter SW_2 = File.CreateText(pArqXMLAssinar);
                                    //SW_2.Write(this.vXMLStringAssinado);
                                    //SW_2.Close();
                                }
                                catch(Exception caught)
                                {
                                    this.vResultado = 6;
                                    this.vResultadoString = "Erro ao assinar o documento - " + caught.Message;
                                }
                            }
                        }
                    }
                    catch(Exception caught)
                    {
                        this.vResultado = 3;
                        this.vResultadoString = "XML mal formado - " + caught.Message;
                    }
                }
            }
            catch(Exception caught)
            {
                this.vResultado = 1;
                this.vResultadoString = "Problema ao acessar o certificado digital" + caught.Message;
            }

            return XMLDoc;
        }

        public XmlDocument Assinar(XmlDocument documento, string id)
        {
            if(documento == null)
                throw new ArgumentNullException("documento");
            if(this.Certificado == null)
                throw new InvalidOperationException("certificado");

            Reference reference = new Reference();
            //reference.Uri = "#" + id;

            XmlDsigEnvelopedSignatureTransform env = new XmlDsigEnvelopedSignatureTransform();
            reference.AddTransform(env);

            XmlDsigC14NTransform c14 = new XmlDsigC14NTransform();
            reference.AddTransform(c14);

            reference.DigestMethod = "http://www.w3.org/2001/04/xmlenc#sha256";

            KeyInfo keyInfo = new KeyInfo();

            keyInfo.AddClause(new KeyInfoX509Data(this.Certificado));

            XmlDocument documentoUTF8 = ReconstruirComoUTF8(documento);

            SignedXml signature = new SignedXml(documentoUTF8);
            signature.SigningKey = this.Certificado.PrivateKey;
            signature.AddReference(reference);
            signature.KeyInfo = keyInfo;
            signature.SignedInfo.SignatureMethod = "http://www.w3.org/2001/04/xmldsig-more#rsa-sha256";
            signature.ComputeSignature();

            documentoUTF8.DocumentElement.AppendChild(documentoUTF8.ImportNode(signature.GetXml(), true));
            return documentoUTF8;
        }

        private XmlDocument ReconstruirComoUTF8(XmlDocument documento)
        {
            //sem isso dava: Assinatura do evento inválida. Assinatura Digital do documento XML é inválida
            var bytes = System.Text.Encoding.UTF8.GetBytes(documento.OuterXml);
            var rawDocumentoUTF8 = System.Text.Encoding.UTF8.GetString(bytes);
            XmlDocument documentoUTF8 = new XmlDocument();
            documentoUTF8.LoadXml(rawDocumentoUTF8);
            return documentoUTF8;
        }
    }
}
