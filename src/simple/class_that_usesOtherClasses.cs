// There should never be more than one reason for a class to change.  (hence it will be only doing one thing in the overall system)

class Program
{
  Report report = new Report();
  
  report.Print();
  
  Console.WriteLine("Hitkey");
  Console.ReadKey();
}

class DataAccess
{
  public IList<ReportDataElement> GetData()
  {
    Console.WriteLine("Gettingdata");
    return new List<ReportDataElement>() { 
      new ReportDataElement
      {
        CustomerFirstName = "Bart",
        CustomerLastName = "Simpon"
      }
    };
  }
}

class ReportFormatter
{
  private void FormatReport()
  {
    Console.WriteLine("formattingreport");
  }
}

class ReportPrinter
{
  private void Send()
  {
    Console.WriteLine("printingreport");
  }
}

class Report
{
  public void Print()
  {
    var dataAccess = new DataAccess()
    dataAccess.GetData();
    
    var formatter = new ReportFormatter()
    formatter.FormatReport();
    
    var printer = new ReportPrinter()
    printer.Send();
  }
  
}