using Builder.Vehicles;

namespace Builder.Builders
{
	public class CarBuilder : IVehicleBuilder
	{
		private readonly Vehicle _vehicle = new Vehicle();

		public Vehicle Vehicle => _vehicle;

		public void BuildEngine()
		{
			_vehicle.EngineType = "Car engine";
		}

		public void BuildWheels()
		{
			for (int i = 0; i < 4; i++)
				_vehicle.AddWheel();
		}
	}
}