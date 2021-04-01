using System;
using Builder.Directors;
using Builders.VehicleBuilder;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new VehicleBuilder();
            var director= new Director(builder);

            director.ConstructSedanCar();
            var vehicleSedan = builder.GetVehicle();
            Console.WriteLine($"Criado um veiculo do tipo: {vehicleSedan.VehicleType}");
            
            director.ConstructTruck();
            var vehicleTruck = builder.GetVehicle();
            Console.WriteLine($"Criado um veiculo do tipo: {vehicleTruck.VehicleType}");
            
            director.ConstructSUV();

            var vehicleSUV = builder.GetVehicle();

            Console.WriteLine($"Criado um veiculo do tipo: {vehicleSUV.VehicleType}");

            Console.ReadLine();
        }
    }
}
