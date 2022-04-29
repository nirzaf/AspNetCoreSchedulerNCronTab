using AspNetCoreSchedulerDemo.BackgroundService;
using System;
using System.Globalization;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace AspNetCoreSchedulerDemo.ScheduleTask
{
    public class SampleTask1 : ScheduledProcessor
    {
        public SampleTask1(IServiceScopeFactory serviceScopeFactory) : base(serviceScopeFactory)
        {
                
        }

        protected override string Schedule => "* * * * *"; // every 1 min 

        public override async Task ProcessInScope(IServiceProvider scopeServiceProvider)
        {
            Console.WriteLine("SampleTask1 : " + DateTime.Now.ToString(CultureInfo.InvariantCulture));
            // return Task.CompletedTask;
            await Task.Run(() => Task.CompletedTask);
        }
    }
}
