using System;

namespace DIDemo_Injected
{
  public class Printer : IPrinter
  {
    public Printer()
    {
      Console.WriteLine("\tcreated: {0} - {1}", GetType(), DateTime.Now);
    }

    public void SendToPrinter()
    {
      Console.WriteLine("Sending to Printer");
    }
  }
}