using Builder.Vehicles;

namespace Builder.Builders
{
	public class MotorcycleBuilder : IVehicleBuilder
	{
		private readonly Vehicle _vehicle = new Vehicle();
		public Vehicle Vehicle => _vehicle;
		public void BuildEngine()
		{
			_vehicle.EngineType = "Motorcycle engine";
		}

		public void BuildWheels()
		{
			for (int i = 0; i < 2; i++)
				_vehicle.AddWheel();
		}
	}
}