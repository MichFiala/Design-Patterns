namespace Decorator
{
	public class EmailNotifierDecorator : NotifierDecorator
	{
		public EmailNotifierDecorator(INotifier notifier) : base(notifier) { }

		public override void Notify()
		{
			Console.WriteLine("Email notification");

			base.Notify();
		}
	}
}