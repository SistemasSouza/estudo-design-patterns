using AbstractFactory.Aircrafts;
using AbstractFactory.Factories;
using AbstractFactory.Landvehicles;

namespace AbstractFactory.App
{
    class Application
    {
        private IAircraft _aircraft;
        private ILandvehicle _landvehicle;

        public Application(ITransportFactory factory)
        {
            _aircraft = factory.CreateTransportAircraft();
            _landvehicle = factory.CreateTransportVehicle();
        }

        public void StartRoute()
        {
          _aircraft.StartRoute();
          _landvehicle.StartRoute();
        }
    }
}