using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixFeedTest
{
    internal class ExecutionSummary
    {
        public string Symbol { get; set; }

        // Total metrics
        public decimal TotalBuyVolume { get; set; }
        public decimal TotalSellVolume { get; set; }
        public decimal TotalBuyValue { get; set; }
        public decimal TotalSellValue { get; set; }

        // Time-based metrics
        public decimal BoughtInOneMin { get; set; }
        public decimal BoughtInTenMin { get; set; }
        public decimal BoughtInThirtyMin { get; set; }
        public decimal BoughtInSixtyMin { get; set; }
        public decimal BoughtInOneTwentyMin { get; set; }
    }

}
