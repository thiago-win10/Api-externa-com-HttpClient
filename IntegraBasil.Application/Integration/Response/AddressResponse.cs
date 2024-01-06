using Newtonsoft.Json;

namespace IntegraBasil.Application.Integration.Response
{
    public class AddressResponse
    {
        [JsonProperty("cep")]
        public string? Cep { get; set; }

        [JsonProperty("state")]
        public string? Estado { get; set; }

        [JsonProperty("city")]
        public string? Cidade { get; set; }

        [JsonProperty("neighborhood")]
        public string? Regiao { get; set; }

        [JsonProperty("street")]
        public string? Rua { get; set; }

        [JsonProperty("service")]
        public string? Servico { get; set; }
    }
}
