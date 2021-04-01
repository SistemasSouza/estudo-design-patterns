using System;

namespace Bridge.Platforms
{
  class YouTube : IPlatform
  {
    public YouTube()
    {
      ConfigureRMTP();
    }

    public void AuthToken()
    {
      Console.WriteLine("Youtube: Autorização concedida");
    }

    public void ConfigureRMTP()
    {
      AuthToken();
      Console.WriteLine("Youtube: configurando servidor RMTP");
    }
  }
}