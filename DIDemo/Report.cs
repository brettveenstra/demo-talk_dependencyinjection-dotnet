using System;
using System.Collections.Generic;

namespace DIDemo
{
  public class Report
  {
    public void Print()
    {
      List<ReportDataElement> data = this.GetData();
      this.FormatReport(data);
      this.SendToPrinter();
    }

    private void SendToPrinter()
    {
      Console.WriteLine("Sending to Printer");
    }

    private void FormatReport(List<ReportDataElement> data)
    {
      Console.WriteLine("Formatting Report");
    }

    private List<ReportDataElement> GetData()
    {
      Console.WriteLine("Getting data");

      return new List<ReportDataElement>
      {
        new ReportDataElement(DateTime.Now, 123, 100041.27)
      };
    }
  }
}