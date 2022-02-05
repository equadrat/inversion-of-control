using e2.Framework.Components;
using IOC.Singleton;

var registry = new CoreIOCRegistry();

// Setup the IOC/DI registry.
registry.Register<IMyComponent>().AsSingletonOf<MyComponent>();

/*
Alternatives:
    Use an existing instance:
        registry.Register<IMyComponent>().AsSingletonOf(new MyComponent());

    Use a parameterless function to construct the instance:
        registry.Register<IMyComponent>().AsSingletonOf(() => new MyComponent());

    Use a parametrized function to construct the instance:
        registry.Register<IMyComponent>().AsSingletonOf(factory => new MyComponent());

    Use a Lazy-object to provide an instance.
        var lazyObject = new Lazy<MyComponent>(() => new MyComponent());
        registry.Register<IMyComponent>().AsSingletonOf(lazyObject);
*/

var factory = registry.Factory;

var myComponent = factory.GetInstanceOf<IMyComponent>();

Console.WriteLine(
    $"Implemented type: {myComponent.GetType()}\n" +
    $"Concatenated result is \"{myComponent.Concatenate("Hello ", "World!")}\".");

Console.WriteLine("\nPress any key to exit the application.");
Console.ReadKey(true);