using Builder.Components;

namespace Builder.Products
{
    class Vehicle
    {
      private VehicleType vehicleType;
      private int seats;
      private Engine engine;
      private TransmissionType transmission;

      public VehicleType VehicleType 
      {
        get => vehicleType;
        set => vehicleType = value;
      }
      public int Seats 
      {
        get => seats;
        set => seats = value;
      }
      public Engine Engine 
      {
        get => engine;
        set => engine = value;
      }
      public TransmissionType Transmission 
      {
        get => transmission;
        set => transmission = value;
      }


    }
}