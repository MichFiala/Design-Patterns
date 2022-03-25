using Factory_Method.Vehicles;

namespace Factory_Method.Factories
{
	public abstract class VehicleFactory
    {
		public abstract IVehicle Create();
        // Other bussiness action for Creator
        public void CreateAndStartVehicle()
        {
			var vehicle = Create();

			vehicle.Start();
		}
	}
}