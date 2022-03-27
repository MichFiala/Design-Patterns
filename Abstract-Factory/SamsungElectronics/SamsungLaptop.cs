using Abstract_Factory.Electronics;

namespace Abstract_Factory.SamsungElectronics
{
	public class SamsungLaptop : Laptop
	{
		public void Compute()
		{
			Console.WriteLine("Samsung laptop started computing");
		}
	}
}