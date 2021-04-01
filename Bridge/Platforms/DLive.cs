using System;

namespace Bridge.Platforms
{
  class DLive : IPlatform
  {
    public DLive()
    {
      ConfigureRMTP();
    }

    public void AuthToken()
    {
      Console.WriteLine("DLive: Autorização concedida");
    }

    public void ConfigureRMTP()
    {
      AuthToken();
      Console.WriteLine("DLive: configurando servidor RMTP");
    }
  }
}