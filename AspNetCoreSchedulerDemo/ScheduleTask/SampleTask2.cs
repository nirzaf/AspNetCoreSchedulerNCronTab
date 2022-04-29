using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreSchedulerDemo.BackgroundService;
using AspNetCoreSchedulerDemo.Services;
using Microsoft.Extensions.DependencyInjection;

namespace AspNetCoreSchedulerDemo.ScheduleTask
{
    public class SampleTask2 : ScheduledProcessor
    {
        public SampleTask2(IServiceScopeFactory serviceScopeFactory) : base(serviceScopeFactory)
        {

        }

        protected override string Schedule => "* * * * *"; // every 1 min 

        public override Task ProcessInScope(IServiceProvider scopeServiceProvider)
        {
            Console.WriteLine("SampleTask2 : " + DateTime.Now.ToString(CultureInfo.InvariantCulture));
            IReportGenerator reportGenerator = scopeServiceProvider.GetRequiredService<IReportGenerator>();
            reportGenerator.GenerateDailyReport();
            return Task.CompletedTask;
        }
    }
}
