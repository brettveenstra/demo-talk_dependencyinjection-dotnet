namespace DIDemo_Injected
{
  public class ReportFactory
  {
    public Report Create()
    {
      return new Report(new DataAccess(), new ReportFormatter(), new Printer());
    }
  }
}