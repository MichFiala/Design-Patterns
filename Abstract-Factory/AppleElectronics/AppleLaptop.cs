using Abstract_Factory.Electronics;

namespace Abstract_Factory.AppleElectronics
{
	public class AppleLaptop : Laptop
	{
		public void Compute()
		{
			Console.WriteLine("Apple laptop started computing");
		}
	}
}