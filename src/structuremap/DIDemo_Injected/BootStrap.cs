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
          c.Scan(
            s =>
            {
              s.TheCallingAssembly();
              s.WithDefaultConventions();
            });
          c.For<IPrinter>().Singleton()
           .Use<Printer>();

        });

      return container;
    }
  }
}