using System;

namespace Bridge.Platforms
{
  class Facebook : IPlatform
  {
    public Facebook()
    {
      ConfigureRMTP();
    }

    public void AuthToken()
    {
      Console.WriteLine("Facebook: Autorização concedida");
    }

    public void ConfigureRMTP()
    {
      AuthToken();
      Console.WriteLine("Facebook: configurando servidor RMTP");
    }
  }
}