using System;
using Bridge.Platforms;

namespace Bridge.Transmissions
{
  class Live : ITransmission
  {
    private IPlatform _platform;
    public Live(IPlatform platform)
    {
      _platform = platform;
    }
    public void Broadcasting()
    {
      Console.WriteLine($"Iniciando a transmissão no: {_platform}");
    }

    public void Result()
    {
      Console.WriteLine("**** ON AIR ****");
    }
  }
}