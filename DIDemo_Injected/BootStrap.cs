using StructureMap;

namespace DIDemo_Injected
{
  public class BootStrap
  {
    public IContainer Initalize()
    {
      var container = new Container(
        c =>
        {
          c.For<IDataAccess>()
           .Use<DataAccess>();
          c.For<IReportFormatter>()
           .Use<ReportFormatter>();
          c.For<IPrinter>()
           .Use<Printer>();
        });

      return container;
    }
  }
}