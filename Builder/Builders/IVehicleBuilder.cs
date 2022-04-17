using Builder.Vehicles;

namespace Builder.Builders
{
	public interface IVehicleBuilder
    {
		void BuildWheels();

		void BuildEngine();

		Vehicle Vehicle { get; }
	}
}