using Abstract_Factory.Electronics;
using Abstract_Factory.SamsungElectronics;

namespace Abstract_Factory.Factories
{
	public class SamsungFactory : ElectronicsFactory
	{
		public override Laptop CreateLaptop()
		{
			return new SamsungLaptop();
		}

		public override Phone CreatePhone()
		{
			return new SamsungPhone();
		}
	}
}