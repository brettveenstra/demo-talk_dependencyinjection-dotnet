// There should never be more than one reason for a class to change.  (hence it will be only doing one thing in the overall system)

class Program
{
  Report report = new Report();
  
  report.Print();
  
  Console.WriteLine("Hitkey");
  Console.ReadKey();
}

// using Interface -- how many ways could we get data access?
class DataAccess : IDataAccess
{
  public IList<ReportDataElement> GetData()
  {
    Console.WriteLine("Gettingdata");
    
    // TODO: add encoding
    // TODO: add permissions
    return new List<ReportDataElement>() { 
      new ReportDataElement
      {
        CustomerFirstName = "Bart",
        CustomerLastName = "Simpon"
      }
    };
  }
}

// using Interface -- how many formats could we have?
class ReportFormatter : IReportFormatter
{
  private void FormatReport()
  {
    // TODO: add settings
    Console.WriteLine("formattingreport");
  }
}

// using Interface -- how many outputs could we have? 
class ReportPrinter : IMediaGenerator
{
  private void Send()
  {
    // TODO: add auditing for billing
    Console.WriteLine("printingreport");
  }
}

class Report
{
  private readonly IDataAccess _dataAccess;
  private readonly IReportFormatter _formatter;
  private readonly IMediaGenerator _generator;
  
  public Report(IDataAccess dataAccess, IReportFormatter formatter, IMediaGenerator generator)
  {
    _dataAccess = dataAccess;
    _formatter = formatter;
    _generator = generator;
  }
  
  // poor man's DI
  public Report()
    : this ( new DataAccess(), new ReportFormatter(), new ReportPrinter())
  {
  }
  
  public void Print()
  {
    _dataAccess.GetData();
    _formatter.FormatReport();
    _generator.Send();
  }
  
}