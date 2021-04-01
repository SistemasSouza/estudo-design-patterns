using Builder.Components;
using Builders;

namespace Builder.Directors
{
    class Director
    {
      IBuilder builder;

      public Director(IBuilder builder)
      {
          this.builder = builder;
      }

      public void ConstructSedanCar()
      {
        builder.SetVehicleType(VehicleType.SEDAN);
        builder.SetEngine(new Engine(2000));
        builder.SetSeats(4);
        builder.SetTransmissionType(TransmissionType.AUTOMATIC);
      }    
      
      public void ConstructTruck()
      {
        builder.SetVehicleType(VehicleType.TRUCK);
        builder.SetEngine(new Engine(4000));
        builder.SetSeats(2);
        builder.SetTransmissionType(TransmissionType.MANUAL);
      }

      public void ConstructSUV()
      {
        builder.SetVehicleType(VehicleType.SUV);
        builder.SetEngine(new Engine(2600));
        builder.SetSeats(4);
        builder.SetTransmissionType(TransmissionType.AUTOMATIC_SEQUENTIAL);
        builder.SetAirBag();
      }        
    }
}