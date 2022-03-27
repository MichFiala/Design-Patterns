using Abstract_Factory.Electronics;

namespace Abstract_Factory.AppleElectronics
{
	public class ApplePhone : Phone
	{
		public void TurnOff()
		{
			Console.WriteLine("Apple phone turned off");
		}

		public void TurnOn()
		{
			Console.WriteLine("Apple phone turned on");
		}
	}
}