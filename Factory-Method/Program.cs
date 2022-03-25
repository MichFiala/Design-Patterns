using Factory_Method.Factories;

void ClientMotorcycleShop(VehicleFactory factory)
{
	// Order for motorcycle
	factory.Create();
}

void ClientCarShop(VehicleFactory factory)
{
	// Order for car
	factory.Create();
}

void ClientMotorcycleAndCarShop(VehicleFactory carFactory, VehicleFactory motorcycleFactory)
{
     // Order for motorcycle
	var car1 = carFactory.Create();
     // Order for car
	var motorcycle1 = motorcycleFactory.Create();
	// Start engines
	car1.Start();
	motorcycle1.Start();
}

var carFactory = new CarFactory();
var motorcycleFactory = new MotorcycleFactory();

ClientCarShop(carFactory);
ClientMotorcycleShop(motorcycleFactory);
ClientMotorcycleAndCarShop(carFactory, motorcycleFactory);

