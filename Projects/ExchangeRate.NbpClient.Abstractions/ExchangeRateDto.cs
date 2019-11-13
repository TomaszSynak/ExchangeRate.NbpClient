namespace ExchangeRate.NbpClient.Abstractions
{
    using System;

    public class ExchangeRateDto
    {
        public string No { get; set; }

        public DateTime EffectiveDate { get; set; }

        public decimal Mid { get; set; }
    }
}
