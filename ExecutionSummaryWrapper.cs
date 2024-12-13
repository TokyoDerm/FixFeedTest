using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixFeedTest
{
    internal class ExecutionSummaryWrapper
    {
        public List<ExecutionSummary> Summaries { get; set; } = new();

        public decimal MaxTradeValue { get; set; }
        public int TotalTrades { get; set; }
        public int TradesInOneMinute { get; set; }
        public int TradesInFiveMinutes { get; set; }
        public DateTime? LastHeartbeatTime { get; set; }
    }

}
