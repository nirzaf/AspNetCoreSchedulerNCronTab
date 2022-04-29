using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreSchedulerDemo.Services
{
    public interface IReportGenerator
    {
        string GenerateDailyReport();

        Task GenerateDailyReportAsync();
    }
}
