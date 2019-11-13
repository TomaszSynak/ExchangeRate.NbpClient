namespace ExchangeRate.NbpClient.Abstractions
{
    using System.Collections.Generic;

    public class CurrencyDto
    {
        public string Table { get; set; }

        public string Currency { get; set; }

        public string Code { get; set; }

        public IReadOnlyCollection<ExchangeRateDto> Rates { get; set; }
    }
}
