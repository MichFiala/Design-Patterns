namespace Decorator
{
	public class SmsNotifierDecorator : NotifierDecorator
	{
		public SmsNotifierDecorator(INotifier notifier) : base(notifier) { }

		public override void Notify()
        {
			Console.WriteLine("SMS Notification");
			base.Notify();
		}
	}
}