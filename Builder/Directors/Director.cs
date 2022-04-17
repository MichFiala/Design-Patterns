using Builder.Builders;
using Builder.Vehicles;

namespace Builder.Directors
{
	public class Director
    {
		private readonly IVehicleBuilder _builder;
        public Director(IVehicleBuilder builder)
        {
			_builder = builder;
		}
		public Vehicle BuildNotFunctionalVehicle()
        {
			_builder.BuildEngine();

			return _builder.Vehicle;
		}

        public Vehicle BuildVehicle()
        {
			_builder.BuildEngine();
			_builder.BuildWheels();

			return _builder.Vehicle;
		}
    }
}