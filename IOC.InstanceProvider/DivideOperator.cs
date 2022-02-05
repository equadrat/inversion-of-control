namespace IOC.InstanceProvider
{
    internal class DivideOperator: IMathOperator
    {
        /// <inheritdoc />
        public string Name => "Divide";

        /// <inheritdoc />
        public string Operator => "/";

        /// <inheritdoc />
        public double Calculate(double value1, double value2)
        {
            return value1 / value2;
        }
    }
}