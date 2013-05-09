// There should never be more than one reason for a class to change.  (hence it will be only doing one thing in the overall system)

class Program
{
  Report report = new Report();
  
  report.Print();
  
  Console.WriteLine("Hitkey");
  Console.ReadKey();
}

class Report
{
  public void Print()
  {
    GetData();
    FormatReport();
    Console.WriteLine("printingreport");
  }
  
  private IList<ReportDataElement> GetData()
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
  
  private void FormatReport()
  {
    Console.WriteLine("formattingreport");
  }
}