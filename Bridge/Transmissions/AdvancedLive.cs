using System;
using Bridge.Platforms;

namespace Bridge.Transmissions
{
    class AdvancedLive : Live
    {
      
      public AdvancedLive(IPlatform platform) : base(platform)
      { }

      public void Subtitles()
      {
        Console.WriteLine("Legendas ativadas");
      }
      
      public void Comments()
      {
        Console.WriteLine("Comentários liberados");
      }

      public void Record()
      {
        Console.WriteLine("Gravando a transmissão");
      }
    }
}