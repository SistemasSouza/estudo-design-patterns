using Builder.Components;
using Builder.Products;

namespace Builders
{
    interface IBuilder
    {
      void Reset();
      Vehicle GetVehicle();

      void SetSeats(int seats);

      void SetEngine(Engine engine);
      void SetTransmissionType (TransmissionType transmission);
      void SetVehicleType(VehicleType vehicleType);     
    }
}