namespace ExchangeRate.NbpClient
{
    using System;
    using System.Net.Http;
    using System.Threading.Tasks;
    using Abstractions;
    using Newtonsoft.Json;

    public class NbpClient : INbpClient
    {
        private readonly HttpClient _httpClient;

        public NbpClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<CurrencyDto> GetExchangeRateAsync(Currency currency, DateTime dateTime)
        {
            var uri = $"api/exchangerates/rates/A/{currency}/{dateTime:yyyy-MM-dd}/";

            var response = await _httpClient.GetStringAsync(uri);

            return JsonConvert.DeserializeObject<CurrencyDto>(response);
        }
    }
}
