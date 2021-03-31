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

            director.ConstructorSedanCar();
            director.ConstructorTruck();

            var vehicleSedan = builder.GetVehicle();
            var vehicleTruck = builder.GetVehicle();

            Console.WriteLine($"Criado um veiculo do tipo: {vehicleSedan.VehicleType}");
            Console.WriteLine($"Criado um veiculo do tipo: {vehicleTruck.VehicleType}");

            Console.ReadLine();
        }
    }
}
