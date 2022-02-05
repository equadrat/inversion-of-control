namespace IOC.InstanceProvider
{
    internal interface IMathOperator
    {
        string Name {get;}
        string Operator {get;}
        double Calculate(double value1, double value2);
    }
}