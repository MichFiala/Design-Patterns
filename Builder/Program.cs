// See https://aka.ms/new-console-template for more information
using Builder.Builders;
using Builder.Directors;

var carBuilder = new CarBuilder();
var motorcycleBuilder = new MotorcycleBuilder();
// Use director for building vehicle
var director = new Director(carBuilder);
var vehicle = director.BuildNotFunctionalVehicle();
// Or use builder by client
motorcycleBuilder.BuildWheels();
motorcycleBuilder.BuildEngine();

var motorcycle = motorcycleBuilder.Vehicle;

