using Builder.Components;
using Builder.Products;

namespace Builders.VehicleBuilder
{
  class VehicleBuilder : IBuilder
  {
    Vehicle vehicle = new Vehicle();

    public Vehicle GetVehicle()
    {
      var result = vehicle;
      Reset();
      return result;
    }

    public void Reset()
    {
      vehicle = new Vehicle();
    }

    public void SetEngine(Engine engine)
    {
     vehicle.Engine = engine;
    }

    public void SetSeats(int seats)
    {
      vehicle.Seats = seats;
    }

    public void SetTransmissionType(TransmissionType transmission)
    {
     vehicle.Transmission = transmission;
    }

    public void SetVehicleType(VehicleType vehicleType)
    {
      vehicle.VehicleType = vehicleType;
    }
  }
}