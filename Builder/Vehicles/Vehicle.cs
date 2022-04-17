namespace Builder.Vehicles
{
	public class Vehicle
    {
		private int _wheelsCount;
		public string EngineType { get; set; } = string.Empty;
		public void AddWheel() => _wheelsCount++;
	}
}