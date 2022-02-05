using e2.Framework.Components;
using IOC.Singleton.DI;

var registry = new CoreIOCRegistry();

// Setup the IOC/DI registry.
registry.Register<IMyComponent>().AsSingletonOf<MyComponent>();
registry.Register<IMyOrchestrator>().AsSingletonOf<MyOrchestrator>();

var factory = registry.Factory;

var myOrchestrator = factory.GetInstanceOf<IMyOrchestrator>();

Console.WriteLine(
    $"Implemented type: {myOrchestrator.GetType()}\n" +
    $"Concatenated result is \"{myOrchestrator.Concatenate("Hello", " ", "World", "!")}\".");

Console.WriteLine("\nPress any key to exit the application.");
Console.ReadKey(true);