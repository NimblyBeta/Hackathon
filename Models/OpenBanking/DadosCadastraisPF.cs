using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace api.Models.OpenBanking
{
    public class DadosCadastraisPF
    {
        public List<Datum> data { get; set; }
        public Links links { get; set; }
        public Meta meta { get; set; }
        public class Documents
        {
            public string cpfNumber { get; set; }
            public string passportNumber { get; set; }
            public string passportCountry { get; set; }
            public string passportExpirationDate { get; set; }
            public string passportIssueDate { get; set; }
            public string type { get; set; }
            public string number { get; set; }
            public string expirationDate { get; set; }
            public string issueDate { get; set; }
            public string country { get; set; }
            public string typeAdditionalInfo { get; set; }
        }

        public class OtherDocument
        {
            public string type { get; set; }
            public string typeAdditionalInfo { get; set; }
            public string number { get; set; }
            public string checkDigit { get; set; }
            public string additionalInfo { get; set; }
            public string expirationDate { get; set; }
        }

        public class Nationality
        {
            public string otherNationalitiesInfo { get; set; }
            public List<Document> documents { get; set; }
        }

        public class Filiation
        {
            public string type { get; set; }
            public string civilName { get; set; }
            public string socialName { get; set; }
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
            public string personalId { get; set; }
            public string brandName { get; set; }
            public string civilName { get; set; }
            public string socialName { get; set; }
            public string birthDate { get; set; }
            public string maritalStatusCode { get; set; }
            public string maritalStatusAdditionalInfo { get; set; }
            public string sex { get; set; }
            public List<string> companyCnpj { get; set; }
            public Documents documents { get; set; }
            public List<OtherDocument> otherDocuments { get; set; }
            public bool hasBrazilianNationality { get; set; }
            public List<Nationality> nationality { get; set; }
            public List<Filiation> filiation { get; set; }
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