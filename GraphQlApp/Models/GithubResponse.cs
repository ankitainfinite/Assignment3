using Newtonsoft.Json;


namespace  GraphQlApp
{
public partial class Film
{
    
    [JsonProperty("title", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
    public string Title { get; set; }

    [JsonProperty("director", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
    public string Director { get; set; }


}
}








