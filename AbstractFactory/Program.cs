using System;
using AbstractFactory.App;
using AbstractFactory.Factories;

namespace AbstractFactory
{
  class Program
  {
    static Application ConfigureApplication()
    {
      Application app;
      ITransportFactory transportFactory;
      string company = "lime";

      if(company == "uber")
      {
        transportFactory = new UberTransport();
      }
      else if(company == "ninenine")
      {
        transportFactory = new NineNineTransport();
      }
      else 
      {
        transportFactory = new LimeTransport();
      }

      app = new Application(transportFactory);
      return app;
    }
    static void Main(string[] args)
    {
      var app = ConfigureApplication();

      app.StartRoute();

      Console.ReadLine();
    }
  }
}
