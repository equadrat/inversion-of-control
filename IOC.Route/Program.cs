using e2.Framework.Components;
using IOC.Route;

var registry = new CoreIOCRegistry();

// Setup the IOC/DI registry.
registry.Register<MyComponent>().AsSingleton();
registry.Register<IMyComponent1>().AsRouteTo<MyComponent>();
registry.Register<IMyComponent2>().AsRouteTo<MyComponent>();

var factory = registry.Factory;

var myComponent1 = factory.GetInstanceOf<IMyComponent1>();
var myComponent2 = factory.GetInstanceOf<IMyComponent2>();

Console.WriteLine($"Component1 and Component2 are the same instance: {ReferenceEquals(myComponent1, myComponent2)}");

Console.WriteLine("\nPress any key to exit the application.");
Console.ReadKey(true);