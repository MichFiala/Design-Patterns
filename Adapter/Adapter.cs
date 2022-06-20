namespace Adapter
{
	public class Adapter : IInfo
	{
		private readonly Adaptee _adaptee;
		public Adapter(Adaptee adaptee)
		{
			_adaptee = adaptee;
		}
		public string GetInfo() => _adaptee.GetSpecificInformation();
	}
}