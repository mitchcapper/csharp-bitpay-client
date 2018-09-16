﻿using Newtonsoft.Json;

namespace BitPayAPI
{
    public class PayoutInstructionBtcSummary
    {

        public PayoutInstructionBtcSummary(double paid, double unpaid)
        {
            Paid = paid;
            Unpaid = unpaid;
        }

        [JsonProperty(PropertyName = "paid")]
        [JsonConverter(typeof(Converters.BtcValueConverter))]
        public double Paid { get; set; }

        [JsonProperty(PropertyName = "unpaid")]
        [JsonConverter(typeof(Converters.BtcValueConverter))]
        public double Unpaid { get; set; }

    }
}
