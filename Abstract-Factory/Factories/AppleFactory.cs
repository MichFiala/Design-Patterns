using Abstract_Factory.AppleElectronics;
using Abstract_Factory.Electronics;

namespace Abstract_Factory.Factories
{
	public class AppleFactory : ElectronicsFactory
	{
		public override Laptop CreateLaptop()
		{
			return new AppleLaptop();
		}

		public override Phone CreatePhone()
		{
			return new ApplePhone();
		}
	}
}