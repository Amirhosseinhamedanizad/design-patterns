using AdapterDemo.ThirdPartyLibraries;
using System;
using System.Collections.Generic;

namespace AdapterDemo
{
    class Program   //client
    {
        static void Main(string[] args)
        {
            Report report = new Report
            {
                ReportName = "Employees EOD Salary",
                Data = new List<string> { "Jacky Lima: $35,000 ,  Robin James: $55,0000, Anne Lime: $105,00000"}
            };

            IThridPartyReportingTool thirdPartReportingTool = new ThridPartyReportingTool();

            EnhanceRenderingAdapter adapter = new EnhanceRenderingAdapter(thirdPartReportingTool);
            adapter.ShowReport(report);

            Console.ReadKey();
        }
    }
}
