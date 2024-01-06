using IntegraBasil.Application.Integration.Interfaces;
using IntegraBasil.Application.Integration.Response;
using Newtonsoft.Json;
using System.Dynamic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Runtime.ConstrainedExecution;
using System.Text.Json;

namespace IntegraBasil.Application.Integration.Rest
{
    public class BrasilApiIntegrationRest : IBrasilApiIntegration
    {
        
        public async Task<GenericResponse<List<BankResponse>>> GetAllBanks()
        {

            var request = new HttpRequestMessage(HttpMethod.Get, $"https://brasilapi.com.br/api/banks/v1");

            var response = new GenericResponse<List<BankResponse>>();
            using (var client = new HttpClient())
            {
                var responseBrasilApi = await client.SendAsync(request);
                var contentResp = await responseBrasilApi.Content.ReadAsStringAsync();
                var objResponse = JsonConvert.DeserializeObject<List<BankResponse>>(contentResp);

                if (responseBrasilApi.IsSuccessStatusCode)
                {
                    response.CodeHttp = responseBrasilApi.StatusCode;
                    response.DatasReturn = objResponse;
                }
                else
                {
                    response.CodeHttp = responseBrasilApi.StatusCode;
                    response.ErrorReturn = JsonConvert.DeserializeObject<ExpandoObject>(contentResp);
                }
            }

            return response;


        }

        public async Task<GenericResponse<BankResponse>> GetBankById(string codeBank)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://brasilapi.com.br/api/banks/v1/{codeBank}");

            var response = new GenericResponse<BankResponse>();
            using (var client = new HttpClient())
            {
                var responseBrasilApi = await client.SendAsync(request);
                var contentResp = await responseBrasilApi.Content.ReadAsStringAsync();
                var objResponse = JsonConvert.DeserializeObject<BankResponse>(contentResp);

                if (responseBrasilApi.IsSuccessStatusCode)
                {
                    response.CodeHttp = responseBrasilApi.StatusCode;
                    response.DatasReturn = objResponse;
                }
                else
                {
                    response.CodeHttp = responseBrasilApi.StatusCode;
                    response.ErrorReturn = JsonConvert.DeserializeObject<ExpandoObject>(contentResp);
                }
            }

            return response;
        }

        public async Task<GenericResponse<AddressResponse>> GetByCep(string cep)
        {

            var request = new HttpRequestMessage(HttpMethod.Get, $"https://brasilapi.com.br/api/cep/v1/{cep}");

            var response = new GenericResponse<AddressResponse>();
            using (var client = new HttpClient())
            {
                var responseBrasilApi = await client.SendAsync(request);
                var contentResp = await responseBrasilApi.Content.ReadAsStringAsync();
                var objResponse = JsonConvert.DeserializeObject<AddressResponse>(contentResp);

                if (responseBrasilApi.IsSuccessStatusCode)
                {
                    response.CodeHttp = responseBrasilApi.StatusCode;
                    response.DatasReturn = objResponse;
                }
                else
                {
                    response.CodeHttp = responseBrasilApi.StatusCode;
                    response.ErrorReturn = JsonConvert.DeserializeObject<ExpandoObject>(contentResp);
                }
            }

            return response;

        }
    }
}