using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace  GraphQlApp
{
    using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

public partial class GithubResponse
{
    [JsonProperty("data", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
    public Data Data { get; set; }
}

public partial class Data
{
    [JsonProperty("allFilms", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
    public AllFilms AllFilms { get; set; }
}

public partial class AllFilms
{
    [JsonProperty("films", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
    public Film[] Films { get; set; }
}

public partial class Film
{
    [JsonProperty("id", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
    public string Id { get; set; }

    [JsonProperty("title", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
    public string Title { get; set; }

    [JsonProperty("director", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
    public string Director { get; set; }


}
}








