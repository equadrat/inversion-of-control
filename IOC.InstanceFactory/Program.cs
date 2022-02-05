using e2.Framework.Components;
using IOC.InstanceFactory;

var registry = new CoreIOCRegistry();

// Setup the IOC/DI registry.
registry.Register<IMyModel>().AsInstancePerCallOf<MyModel>();

var factory = registry.Factory;

var instanceFactory = factory.GetInstanceFactoryOf<IMyModel>();

var model1 = instanceFactory.CreateInstance();
model1.ModelId = 1;
model1.Name = "Model1";

var model2 = instanceFactory.CreateInstance();
model2.ModelId = 2;
model2.Name = "Model2";

Console.WriteLine($"Model 1 is of type {model1.GetType()}, ModelId: {model1.ModelId}, Name: \"{model1.Name}\".");
Console.WriteLine($"Model 2 is of type {model2.GetType()}, ModelId: {model2.ModelId}, Name: \"{model2.Name}\".");

Console.WriteLine("\nPress any key to exit the application.");
Console.ReadKey(true);