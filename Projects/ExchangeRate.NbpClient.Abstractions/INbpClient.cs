namespace ExchangeRate.NbpClient.Abstractions
{
    using System;
    using System.Threading.Tasks;

    public interface INbpClient
    {
        Task<CurrencyDto> GetExchangeRateAsync(Currency currency, DateTime dateTime);
    }
}
