// See https://aka.ms/new-console-template for more information
using Adapter;

Adaptee adaptee = new Adaptee();

IInfo infoService = new Adapter.Adapter(adaptee);

Console.WriteLine(infoService.GetInfo());
