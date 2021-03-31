using System;

namespace AbstractFactory.Aircrafts
{
  class Airplane : IAircraft
  {
    public void CheckWind()
    {
      Console.WriteLine("Checando vento, ventos a 30km/h, ventos ok");
    }

    public void GetCargo()
    {
      Console.WriteLine("Passageiros a bordo, voô autorizado");
    }

    public void StartRoute()
    {
      CheckWind();
      GetCargo();
      Console.WriteLine("decolando, trajeto iniciado");
    }
  }
}