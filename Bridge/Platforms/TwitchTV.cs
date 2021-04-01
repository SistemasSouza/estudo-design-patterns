using System;

namespace Bridge.Platforms
{
  class TwitchTV : IPlatform
  {
    public TwitchTV()
    {
      ConfigureRMTP();
    }

    public void AuthToken()
    {
      Console.WriteLine("TwitchTV: Autorização concedida");
    }

    public void ConfigureRMTP()
    {
      AuthToken();
      Console.WriteLine("TwitchTV: configurando servidor RMTP");
    }
  }
}