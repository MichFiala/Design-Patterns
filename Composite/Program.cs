// See https://aka.ms/new-console-template for more information
using Composite;

var product = new Product(50);
var product2 = new Product(30);
var product3 = new Product(10);

var subBox = new Box(product2, product3);

IEvaluable box = new Box(subBox, product);
Console.WriteLine($"Value of box is {box.GetValue()}");
