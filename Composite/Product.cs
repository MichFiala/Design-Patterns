namespace Composite
{
	public class Product : IEvaluable
	{
		private readonly decimal _value;
		public Product(decimal value)
		{
			_value = value;
		}
		public decimal GetValue() => _value;
	}
}