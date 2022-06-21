namespace Composite
{
	public class Box : IEvaluable
	{
		private readonly List<IEvaluable> _children;

		public Box(params IEvaluable[] children)
		{
			_children = children.ToList();
		}
		public decimal GetValue() => _children.Sum(x => x.GetValue());
	}
}