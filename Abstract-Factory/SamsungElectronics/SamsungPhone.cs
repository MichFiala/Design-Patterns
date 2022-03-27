using Abstract_Factory.Electronics;

namespace Abstract_Factory.SamsungElectronics
{
	public class SamsungPhone : Phone
	{
		public void TurnOff()
		{
			Console.WriteLine("Samsung phone turned off");
		}

		public void TurnOn()
		{
			Console.WriteLine("Samsung phone turned on");
		}
	}
}