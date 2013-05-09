using System;
using System.Collections.Generic;

namespace DIDemo_Injected
{
  public class ReportFormatter : IReportFormatter
  {
    public ReportFormatter()
    {
      Console.WriteLine("\tcreated: {0} - {1}", GetType(), DateTime.Now);
    }

    public void FormatReport(List<ReportDataElement> data)
    {
      Console.WriteLine("Formatting Report");
    }
  }
}