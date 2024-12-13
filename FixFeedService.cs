using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace FixFeedTest
{
    internal class FixFeedService
    {

        public static async Task ReceiveExecutionSummariesUpdate()
        {
            string hubUrl = "http://localhost:5000/executionSummaryHub";

            var connection = new HubConnectionBuilder()
                            .WithUrl(hubUrl)
                            .Build();

            // Set up a listener for the ReceiveExecutionSummariesUpdate topic
            connection.On<string>("ReceiveExecutionSummariesUpdate", (data) =>
            {
                try
                {
                    var executionSummaryWrapper = JsonConvert.DeserializeObject<ExecutionSummaryWrapper>(data);

                    if (executionSummaryWrapper != null)
                    {
                        Console.WriteLine($"Deserialized ExecutionSummaryWrapper: {executionSummaryWrapper.Summaries.Count} summaries received.");
                    }
                    else
                    {
                        Console.WriteLine("Received data is null after deserialization.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error deserializing data: {ex.Message}");
                }
            });

        }
    }
}
