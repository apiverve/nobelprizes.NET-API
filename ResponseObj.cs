using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
    /// <summary>
    /// NobelPrizes data
    /// </summary>
    public class NobelPrizes
    {
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("born")]
        public string Born { get; set; }

        [JsonProperty("died")]
        public string Died { get; set; }

        [JsonProperty("countryborn")]
        public string Countryborn { get; set; }

        [JsonProperty("countrybornCode")]
        public string CountrybornCode { get; set; }

        [JsonProperty("born city")]
        public string Borncity { get; set; }

        [JsonProperty("diedCountry")]
        public string DiedCountry { get; set; }

        [JsonProperty("diedCountryCode")]
        public string DiedCountryCode { get; set; }

        [JsonProperty("diedCity")]
        public string DiedCity { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("year")]
        public string Year { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("motivation")]
        public string Motivation { get; set; }

        [JsonProperty("organization")]
        public string Organization { get; set; }

        [JsonProperty("organizationCity")]
        public string OrganizationCity { get; set; }

        [JsonProperty("organizationCountry")]
        public string OrganizationCountry { get; set; }

    }
    /// <summary>
    /// Data data
    /// </summary>
    public class Data
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("filteredOn")]
        public string[] FilteredOn { get; set; }

        [JsonProperty("nobelPrizes")]
        public NobelPrizes[] NobelPrizes { get; set; }

    }
    /// <summary>
    /// API Response object
    /// </summary>
    public class ResponseObj
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("error")]
        public object Error { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }

    }
}
