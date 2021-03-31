using System;

namespace AbstractFactory.Aircrafts
{
  class Drone : IAircraft
  {
    public void CheckWind()
    {
      Console.WriteLine("Vento 35 km/h ok");
    }

    public void GetCargo()
    {
      Console.WriteLine("encomenda acoplada no compartimento");
    }

    public void StartRoute()
    {
      CheckWind();
      GetCargo();
      Console.WriteLine("decolando, trajeto iniciado");
    }
  }
}