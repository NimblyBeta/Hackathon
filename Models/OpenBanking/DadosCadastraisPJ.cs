using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace api.Models.OpenBanking
{
    public class DadosCadastraisPJ
    { 
        public List<Datum> data { get; set; }
        public Links links { get; set; }
        public Meta meta { get; set; }
        public class OtherDocument
        {
            public string type { get; set; }
            public string number { get; set; }
            public string country { get; set; }
            public string expirationDate { get; set; }
        }

        public class Party
        {
            public string personType { get; set; }
            public string type { get; set; }
            public string civilName { get; set; }
            public string socialName { get; set; }
            public string companyName { get; set; }
            public string tradeName { get; set; }
            public DateTime startDate { get; set; }
            public string shareholding { get; set; }
            public string documentType { get; set; }
            public string documentNumber { get; set; }
            public string documentAdditionalInfo { get; set; }
            public string documentCountry { get; set; }
            public string documentExpirationDate { get; set; }
            public string documentIssueDate { get; set; }
        }

        public class GeographicCoordinates
        {
            public string latitude { get; set; }
            public string longitude { get; set; }
        }

        public class PostalAddress
        {
            public bool isMain { get; set; }
            public string address { get; set; }
            public string additionalInfo { get; set; }
            public string districtName { get; set; }
            public string townName { get; set; }
            public string ibgeTownCode { get; set; }
            public string countrySubDivision { get; set; }
            public string postCode { get; set; }
            public string country { get; set; }
            public string countryCode { get; set; }
            public GeographicCoordinates geographicCoordinates { get; set; }
        }

        public class Phone
        {
            public bool isMain { get; set; }
            public string type { get; set; }
            public string additionalInfo { get; set; }
            public string countryCallingCode { get; set; }
            public string areaCode { get; set; }
            public string number { get; set; }
            public string phoneExtension { get; set; }
        }

        public class Email
        {
            public bool isMain { get; set; }
            public string email { get; set; }
        }

        public class Contacts
        {
            public List<PostalAddress> postalAddresses { get; set; }
            public List<Phone> phones { get; set; }
            public List<Email> emails { get; set; }
        }

        public class Datum
        {
            public DateTime updateDateTime { get; set; }
            public string businessId { get; set; }
            public string brandName { get; set; }
            public string companyName { get; set; }
            public string tradeName { get; set; }
            public DateTime incorporationDate { get; set; }
            public string cnpjNumber { get; set; }
            public List<string> companyCnpjNumber { get; set; }
            public List<OtherDocument> otherDocuments { get; set; }
            public List<Party> parties { get; set; }
            public Contacts contacts { get; set; }
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
}