using System;
using System.Collections.Generic;

namespace DIDemo_Injected
{
  public class DataAccess : IDataAccess
  {
    public DataAccess()
    {
      Console.WriteLine("\tcreated: {0} - {1}", GetType(), DateTime.Now);
    }

    public List<ReportDataElement> GetData()
    {
      Console.WriteLine("Getting data");

      return new List<ReportDataElement>
      {
        new ReportDataElement(DateTime.Now, 123, 100041.27)
      };
    }
  }
}