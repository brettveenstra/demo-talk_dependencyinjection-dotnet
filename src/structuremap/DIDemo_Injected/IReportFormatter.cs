using System.Collections.Generic;

namespace DIDemo_Injected
{
  public interface IReportFormatter
  {
    void FormatReport(List<ReportDataElement> data);
  }
}