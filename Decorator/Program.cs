// See https://aka.ms/new-console-template for more information
using Decorator;

var simple = new Notifier();
simple.Notify();

Console.WriteLine();

Console.WriteLine("Chain of notifiers: ");
INotifier notifierChain = new Notifier();
notifierChain = new EmailNotifierDecorator(notifierChain);
notifierChain = new SmsNotifierDecorator(notifierChain);

notifierChain.Notify();




