namespace Factory_Method.Vehicles
{
	public class Car : IVehicle
    {
        public void Start()
		{
			Console.WriteLine("Car started");
		}
	}
}