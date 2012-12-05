using System;
using StructureMap;

namespace DIDemo_Injected
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      var bootstrap = new BootStrap();
      IContainer container = bootstrap.Initalize();

      Report report = container.GetInstance<Report>();
      report.Print();

      Console.WriteLine("\n\r\n\rReport printed... Hit any key");
      Console.ReadKey();
    }
  }
}