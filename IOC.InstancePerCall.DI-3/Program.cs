using e2.Framework.Components;
using e2.Framework.Models;
using IOC.InstancePerCall.DI;

var registry = new CoreIOCRegistry();

// Setup the IOC/DI registry.
registry.Register<IMyModel>().AsInstancePerCallOf<MyModel>();

/*
Alternatives:
    Use a parameterless function to construct the instance:
        registry.Register<IMyModel>().AsInstancePerCallOf(() => new MyModel());

    Use a parametrized function to construct the instance (factory only):
        registry.Register<IMyModel>().AsInstancePerCallOf(factory => new MyModel());

    Use a parametrized function to construct the instance (factory and parameter dictionary):
        registry.Register<IMyModel>().AsInstancePerCallOf((factory, parameterDictionary) => new MyModel());
*/

var factory = registry.Factory;

var model1 = factory.CreateInstanceOf<IMyModel>(new CoreIOCParameter(nameof(IMyModel.ModelId), 1L), new CoreIOCParameter(nameof(IMyModel.Name), "Model1"));
var model2 = factory.CreateInstanceOf<IMyModel>(new CoreIOCParameter(nameof(IMyModel.ModelId), 2L), new CoreIOCParameter(nameof(IMyModel.Name), "Model2"));

Console.WriteLine($"Model 1 is of type {model1.GetType()}, ModelId: {model1.ModelId}, Name: \"{model1.Name}\".");
Console.WriteLine($"Model 2 is of type {model2.GetType()}, ModelId: {model2.ModelId}, Name: \"{model2.Name}\".");

Console.WriteLine("\nPress any key to exit the application.");
Console.ReadKey(true);