using e2.Framework.Components;
using IOC.OverlayRegistry;

var rootRegistry = new CoreIOCRegistry();

// Setup the IOC/DI registry.
rootRegistry.Register<IMyComponent>().AsSingletonOf(() => new MyComponent("I'm registered in the root-registry."));

var childRegistry1 = rootRegistry.CreateOverlayRegistry();
childRegistry1.Register<IMyComponent>().AsSingletonOf(() => new MyComponent("I'm registered in the child-registry-1."));

var childRegistry2 = rootRegistry.CreateOverlayRegistry();

var rootFactory = rootRegistry.Factory;
var childFactory1 = childRegistry1.Factory;
var childFactory2 = childRegistry2.Factory;

/*
    Overlay registries can be created using a factory too.

    var childRegistry1 = factory.CreateOverlayRegistry();
    var childRegistry2 = factory.CreateOverlayRegistry();
*/

var myComponentFromRoot = rootFactory.GetInstanceOf<IMyComponent>();
var myComponentFromChild1 = childFactory1.GetInstanceOf<IMyComponent>();
var myComponentFromChild2 = childFactory2.GetInstanceOf<IMyComponent>();

Console.WriteLine($"Component from root-registry says: {myComponentFromRoot.Message}");
Console.WriteLine($"Component from child-registry-1 says: {myComponentFromChild1.Message}");
Console.WriteLine($"Component from child-registry-2 says: {myComponentFromChild2.Message}");

Console.WriteLine("\nPress any key to exit the application.");
Console.ReadKey(true);