using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreSchedulerDemo.Services
{
    public class ReportGenerator : IReportGenerator
    {
        public ReportGenerator()
        {
                
        }

        public string GenerateDailyReport()
        {
            Console.WriteLine("GenerateDailyReport : " + DateTime.Now.ToString());

            return "GenerateDailyReport";
        }

        public async Task GenerateDailyReportAsync()
        {
            Console.WriteLine("GenerateDailyReport : " + DateTime.Now.ToString());

            // write your logic Async

            await Task.Run(() =>
            {
                return true;
            });
        }
    }
}
