using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;

namespace api.Models.Consentimento
{
    public class Consentimento
    {
        #region Solicitacao Consentimento
        public class Solicitacao
        {
            public Data data { get; set; }
            public class Document
            {
                public string identification { get; set; }
                public string rel { get; set; }
            }

            public class LoggedUser
            {
                public Document document { get; set; }
            }

            public class BusinessEntity
            {
                public Document document { get; set; }
            }

            public class Data
            {
                public LoggedUser loggedUser { get; set; }
                public BusinessEntity businessEntity { get; set; }
                public List<string> permissions { get; set; }
                public DateTime expirationDateTime { get; set; }
                public DateTime transactionFromDateTime { get; set; }
                public DateTime transactionToDateTime { get; set; }
            }
        }
        #endregion

        #region Retorno Consentimento
        public class Retorno
        {
            public Data data { get; set; }
            public Links links { get; set; }
            public Meta meta { get; set; }
            public class Data
            {
                public string consentId { get; set; }
                public DateTime creationDateTime { get; set; }
                public string status { get; set; }
                public DateTime statusUpdateDateTime { get; set; }
                public List<string> permissions { get; set; }
                public DateTime expirationDateTime { get; set; }
                public DateTime transactionFromDateTime { get; set; }
                public DateTime transactionToDateTime { get; set; }
            }

            public class Links
            {
                public string self { get; set; }
                public string first { get; set; }
                public string prev { get; set; }
                public string next { get; set; }
                public string last { get; set; }
            }

            public class Meta
            {
                public int totalRecords { get; set; }
                public int totalPages { get; set; }
                public DateTime requestDateTime { get; set; }
            }
        }
        #endregion
        public static Retorno Solicitar(Solicitacao solic)
        {

            NameValueCollection authParams = new NameValueCollection();

            using (WebClient wcCli = new WebClient())
            {
                wcCli.Headers.Add("Content-Type", "application/json");
                wcCli.Headers.Add("Accept", "application/json");
                wcCli.Headers.Add("Authorization", "string");
                wcCli.Headers.Add("x-fapi-auth-date", "stringstringstringstringstrin");
                wcCli.Headers.Add("x-fapi-customer-ip-address", "string");
                wcCli.Headers.Add("x-fapi-interaction-id", "string");
                wcCli.Headers.Add("x-customer-user-agent", "string");

                try
                {
                    byte[] retorno = wcCli.UploadValues("https://example.com/consents/v1/consents", authParams);
                    string retJson = Encoding.UTF8.GetString(retorno);

                    Retorno resp = JsonConvert.DeserializeObject<Retorno>(retJson);

                    return resp;
                }
                catch (WebException ex) // Inválido
                {
                    return null;
                }
            }

        }
    }
}