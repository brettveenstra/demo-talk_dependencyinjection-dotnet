using System.Collections.Generic;

namespace DIDemo_Injected
{
  public class Report
  {
    private readonly IDataAccess _dataAccess;
    private readonly IReportFormatter _formatter;
    private readonly IPrinter _printer;

    public Report(IDataAccess dataAccess, IReportFormatter formatter, IPrinter printer)
    {
      this._dataAccess = dataAccess;
      this._formatter = formatter;
      this._printer = printer;
    }

    public void Print()
    {
      List<ReportDataElement> data = this._dataAccess.GetData();
      this._formatter.FormatReport(data);
      this._printer.SendToPrinter();
    }
  }
}