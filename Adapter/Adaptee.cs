namespace Adapter
{
    /// <summary>
    /// This class doesnt implement IInfo interface
    /// We need to create adapter for it
    /// </summary>
	public class Adaptee
    {
		public string GetSpecificInformation() => "Specific information";
	}
}