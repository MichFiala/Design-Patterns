using Abstract_Factory.Factories;

bool isAppleFan = true;

ElectronicsFactory factory = isAppleFan ? new AppleFactory() : new SamsungFactory();

var phone = factory.CreatePhone();

phone.TurnOn();