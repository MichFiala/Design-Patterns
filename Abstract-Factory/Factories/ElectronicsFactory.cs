using Abstract_Factory.Electronics;

namespace Abstract_Factory.Factories
{
	public abstract class ElectronicsFactory
    {
		public abstract Phone CreatePhone();

		public abstract Laptop CreateLaptop();
	}
}