using Prototype.Parts;

namespace Prototype.Vehicles
{
	public class Car : ICloneable
	{
		public Engine? Engine { get; set; }
		public string? Name { get; set; }
		public decimal Cost { get; set; }
		public object Clone()
		{
			return this.MemberwiseClone();
		}

        public object DeepClone()
        {
			var car = new Car();
			car.Engine = Engine?.Clone() as Engine;
			car.Name = new string(Name);
			car.Cost = Cost;

			return car;
		}
	}
}