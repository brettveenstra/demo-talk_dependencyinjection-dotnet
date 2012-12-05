using System;

namespace DIDemo_Injected
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      IDataAccess dataAccess = new DataAccess();
      IReportFormatter formatter = new ReportFormatter();
      IPrinter printer = new Printer();
      
      Report report = new Report(dataAccess, formatter, printer);
      report.Print();

      Console.WriteLine("\n\r\n\rReport printed... Hit any key");
      Console.ReadKey();
    }
  }
}