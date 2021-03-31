namespace Builder.Components
{
    class Engine
    {
      private int power;

      public Engine(int power)
      {
          Power = power;
      }

      public int Power 
      {
        get => power;
        set => power = value; 
      }    
    }
}