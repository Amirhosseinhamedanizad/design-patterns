using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterDemo.ThirdPartyLibraries
{
    public interface IThridPartyReportingTool
    {
        void LoadReport(string reportName);
        string FormatAndRenderReport(List<string> data);
    }

    //Company purchased this repoting software which is third party software
    public class ThridPartyReportingTool: IThridPartyReportingTool   //adaptee
    {
        private string _reportName = string.Empty;

        public void LoadReport(string reportName)
        {
            _reportName = reportName;

            //Find and Load Report template from Database
        }

        public string FormatAndRenderReport(List<string> data)
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("***************************************************************************");
            sb.AppendLine($"*************{_reportName}******************************************");
            data.ForEach(x =>
            {
                sb.AppendLine($"{x}");
            });
            sb.AppendLine("***************************************************************************");

            return sb.ToString();
        }
    }
}
