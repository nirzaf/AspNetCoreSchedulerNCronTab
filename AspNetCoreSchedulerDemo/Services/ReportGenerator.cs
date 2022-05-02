using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace AspNetCoreSchedulerDemo.Services
{
    public class ReportGenerator : IReportGenerator
    {
        // private readonly ILogger _logger;
        // public ReportGenerator(ILogger logger)
        // {
        //     _logger = logger;
        // }

        public string GenerateDailyReport()
        {
            Console.WriteLine("GenerateDailyReport : " + DateTime.Now.ToString());
           // _logger.LogInformation("GenerateDailyReport : " + DateTime.Now.ToString());
            return "GenerateDailyReport";
        }

        public async Task GenerateDailyReportAsync()
        {
            Console.WriteLine("GenerateDailyReport : " + DateTime.Now.ToString());
            //_logger.LogInformation("GenerateDailyReport : " + DateTime.Now.ToString());
            
            // write your logic Async
            await Task.Run(() =>
            {
                return true;
            });
        }
    }
}
