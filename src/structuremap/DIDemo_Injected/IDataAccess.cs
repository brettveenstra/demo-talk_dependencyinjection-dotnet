using System.Collections.Generic;

namespace DIDemo_Injected
{
  public interface IDataAccess
  {
    List<ReportDataElement> GetData();
  }
}