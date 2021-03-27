using AdapterDemo.ThirdPartyLibraries;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterDemo
{
    //adapter : incompatible interfaces connect together
    public class EnhanceRenderingAdapter : IInternalReportingTool 
    {
        private readonly IThridPartyReportingTool _thridPartyReportingTool;

        public EnhanceRenderingAdapter(IThridPartyReportingTool thridPartyReportingTool)
        {
            _thridPartyReportingTool = thridPartyReportingTool;
        }
        public void ShowReport(Report report)
        {
            //intention here is to enhance the internal reporting tool with new rendering capability 
            //which is purchased from third party company :)
            _thridPartyReportingTool.LoadReport(report.ReportName);
            Console.WriteLine(_thridPartyReportingTool.FormatAndRenderReport(report.Data));       
        }
    }
}
