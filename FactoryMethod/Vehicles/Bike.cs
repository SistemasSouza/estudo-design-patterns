using System;

namespace FactoryMethod.Vehicles
{
  class Bike : IVehicle
  {
    public void GetCargo()
    {
      Console.WriteLine("Pegamos a encomenda de bicicleta");
    }

    public void StartRoute()
    {
      GetCargo();
      Console.WriteLine("Iniciando a entrega de bicicleta");
    }
  }
}