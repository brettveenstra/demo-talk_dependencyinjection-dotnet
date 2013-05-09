using System;

namespace DIDemo_Injected
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      // batch reporting with Factory
      for (int i = 0; i < 100; i++)
      {

        Report report = new ReportFactory().Create();
        report.Print();
      }

      Console.WriteLine("\n\r\n\rReports printed... Hit any key");
      Console.ReadKey();
    }
  }
}