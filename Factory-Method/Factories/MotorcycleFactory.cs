using Factory_Method.Vehicles;

namespace Factory_Method.Factories
{
	public class MotorcycleFactory : VehicleFactory
	{
		public override IVehicle Create() => new Motorcycle();
	}
}