using Newtonsoft.Json;

namespace IntegraBasil.Application.Integration.Response
{
    public class BankResponse
    {
        [JsonProperty("ispb")]
        public string? Ispb { get; set; }

        [JsonProperty("name")]
        public string? Nome { get; set; }

        [JsonProperty("code")]
        public int? Codigo { get; set; }

        [JsonProperty("fullName")]
        public string? NomeCompleto { get; set; }
    }
}
