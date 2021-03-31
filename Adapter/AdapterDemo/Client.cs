using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterDemo
{
    public class Report
    {
        public string ReportName { get; set; }
        public List<string> Data { get; set; }
    }

    public interface IInternalReportingTool
    {
        void ShowReport(Report report);
    }
}
