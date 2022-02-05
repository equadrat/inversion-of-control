using e2.Framework.Components;
using IOC.InstanceProvider;

var registry = new CoreIOCRegistry();

// Setup the IOC/DI registry.
registry.Register<AddOperator>().AsSingleton();
registry.Register<SubtractOperator>().AsSingleton();
registry.Register<MultiplyOperator>().AsSingleton();
registry.Register<DivideOperator>().AsSingleton();
registry.Register<ICalculator>().AsSingletonOf<Calculator>();

var factory = registry.Factory;

var calculator = factory.GetInstanceOf<ICalculator>();

Console.WriteLine($"{calculator.GetOperatorName("+")}: 8 + 2 = {calculator.Calculate("+", 8, 2)}");
Console.WriteLine($"{calculator.GetOperatorName("-")}: 8 - 2 = {calculator.Calculate("-", 8, 2)}");
Console.WriteLine($"{calculator.GetOperatorName("*")}: 8 * 2 = {calculator.Calculate("*", 8, 2)}");
Console.WriteLine($"{calculator.GetOperatorName("/")}: 8 / 2 = {calculator.Calculate("/", 8, 2)}");

Console.WriteLine("\nPress any key to exit the application.");
Console.ReadKey(true);