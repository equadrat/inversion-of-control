namespace IOC.InstanceProvider
{
    internal class SubtractOperator: IMathOperator
    {
        /// <inheritdoc />
        public string Name => "Subtract";

        /// <inheritdoc />
        public string Operator => "-";

        /// <inheritdoc />
        public double Calculate(double value1, double value2)
        {
            return value1 - value2;
        }
    }
}