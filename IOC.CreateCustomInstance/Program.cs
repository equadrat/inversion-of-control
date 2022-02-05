using e2.Framework.Components;
using IOC.CreateCustomInstance;

var registry = new CoreIOCRegistry();

// Setup the IOC/DI registry.
registry.Register<IMyComponent>().AsSingletonOf<MyComponent>();

var factory = registry.Factory;

var myOrchestrator = factory.CreateCustomInstanceOf<MyOrchestrator>();

Console.WriteLine(
    $"Implemented type: {myOrchestrator.GetType()}\n" +
    $"Concatenated result is \"{myOrchestrator.Concatenate("Hello", " ", "World", "!")}\".");

Console.WriteLine("\nPress any key to exit the application.");
Console.ReadKey(true);