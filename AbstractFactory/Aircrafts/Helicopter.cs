using System;

namespace AbstractFactory.Aircrafts
{
  class Helicopter : IAircraft
  {
    public void CheckWind()
    {
      Console.WriteLine("Verificando ventos a sudeste");
    }

    public void GetCargo()
    {
      Console.WriteLine("Passgeiros Ok, Ligando helices");
    }

    public void StartRoute()
    {
      CheckWind();
      GetCargo();
      Console.WriteLine("Decolando");
    }
  }
}