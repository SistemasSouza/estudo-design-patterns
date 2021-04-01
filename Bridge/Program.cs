using System;
using Bridge.Platforms;
using Bridge.Transmissions;

namespace Bridge
{
  class Program
  {
    static void StartLive(IPlatform platform)
    {
      Console.WriteLine("Aguarde...");

      var live = new Live(platform);

      live.Broadcasting();
      live.Result();
    }

    static void StartLiveAdvanced(IPlatform platform)
    {
      Console.WriteLine("Aguarde...");

      var live = new AdvancedLive(platform);

      live.Broadcasting();
      live.Comments();
      live.Subtitles();
      live.Record();
      live.Result();
    }
    static void Main(string[] args)
    {
      StartLiveAdvanced(new YouTube());
      StartLive(new TwitchTV());
      StartLive(new Facebook());
      StartLiveAdvanced(new DLive());

      Console.ReadLine();
    }
  }
}
