namespace Prototype.Parts
{
	public class Engine : ICloneable
	{
        public string? Name { get; set; }
		public object Clone()
		{
			return this.MemberwiseClone();
		}
	}
}