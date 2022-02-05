namespace IOC.InstanceProvider
{
    internal class AddOperator: IMathOperator
    {
        /// <inheritdoc />
        public string Name => "Add";

        /// <inheritdoc />
        public string Operator => "+";

        /// <inheritdoc />
        public double Calculate(double value1, double value2)
        {
            return value1 + value2;
        }
    }
}