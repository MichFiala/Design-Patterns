namespace Decorator
{
	public abstract class NotifierDecorator : INotifier
	{
		private readonly INotifier _notifier;
		public NotifierDecorator(INotifier notifier)
		{
			_notifier = notifier;
		}
		public virtual void Notify() => _notifier.Notify();
	}
}