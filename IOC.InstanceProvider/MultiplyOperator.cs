namespace IOC.InstanceProvider
{
    internal class MultiplyOperator: IMathOperator
    {
        /// <inheritdoc />
        public string Name => "Multiply";

        /// <inheritdoc />
        public string Operator => "*";

        /// <inheritdoc />
        public double Calculate(double value1, double value2)
        {
            return value1 * value2;
        }
    }
}