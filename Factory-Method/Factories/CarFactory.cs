using Factory_Method.Vehicles;

namespace Factory_Method.Factories
{
	public class CarFactory : VehicleFactory
	{
		public override IVehicle Create() => new Car();
	}
}