using System;

namespace DIDemo
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      Report report = new Report();
      report.Print();

      Console.WriteLine("\n\r\n\rReport printed... Hit any key");
      Console.ReadKey();
    }
  }
}