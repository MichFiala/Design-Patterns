namespace Decorator
{
	public class Notifier : INotifier
	{
		public void Notify() => Console.WriteLine("Simple notification");
	}
}