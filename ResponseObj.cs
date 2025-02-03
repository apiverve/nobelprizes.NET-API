using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class nobelPrizes
{
    [JsonProperty("firstName")]
    public string firstName { get; set; }

    [JsonProperty("lastName")]
    public string lastName { get; set; }

    [JsonProperty("born")]
    public string born { get; set; }

    [JsonProperty("died")]
    public string died { get; set; }

    [JsonProperty("countryborn")]
    public string countryborn { get; set; }

    [JsonProperty("countrybornCode")]
    public string countrybornCode { get; set; }

    [JsonProperty("born city")]
    public string borncity { get; set; }

    [JsonProperty("diedCountry")]
    public string diedCountry { get; set; }

    [JsonProperty("diedCountryCode")]
    public string diedCountryCode { get; set; }

    [JsonProperty("diedCity")]
    public string diedCity { get; set; }

    [JsonProperty("gender")]
    public string gender { get; set; }

    [JsonProperty("year")]
    public string year { get; set; }

    [JsonProperty("category")]
    public string category { get; set; }

    [JsonProperty("motivation")]
    public string motivation { get; set; }

    [JsonProperty("organization")]
    public string organization { get; set; }

    [JsonProperty("organizationCity")]
    public string organizationCity { get; set; }

    [JsonProperty("organizationCountry")]
    public string organizationCountry { get; set; }

}

public class data
{
    [JsonProperty("count")]
    public int count { get; set; }

    [JsonProperty("filteredOn")]
    public string[] filteredOn { get; set; }

    [JsonProperty("nobelPrizes")]
    public nobelPrizes[] nobelPrizes { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

    [JsonProperty("code")]
    public int code { get; set; }

}

}
