namespace IOC.InstanceProvider
{
    public interface ICalculator
    {
        string GetOperatorName(string @operator);
        double Calculate(string @operator, double value1, double value2);
    }
}