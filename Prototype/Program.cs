// See https://aka.ms/new-console-template for more information
using Prototype.Vehicles;

var car1 = new Car
{
	Engine = new Prototype.Parts.Engine { Name = "Engine A" },
	Name = "Car 1",
	Cost = 10,
};

var car2 = (Car)car1.Clone();
var car3 = (Car)car1.DeepClone();

Console.WriteLine($"Car2: {car2.Name} {car2.Engine?.Name} {car2.Cost}");
Console.WriteLine($"Reference equals: {object.ReferenceEquals(car1.Engine, car2.Engine)}\n");

Console.WriteLine($"Car3: {car3.Name} {car3.Engine?.Name} {car3.Cost}");
Console.WriteLine($"Reference equals: {object.ReferenceEquals(car1.Engine, car3.Engine)}");
