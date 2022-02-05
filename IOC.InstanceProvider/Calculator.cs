using e2.Framework.Components;

namespace IOC.InstanceProvider
{
    internal class Calculator: ICalculator
    {
        private readonly ICoreIOCInstanceProvider<IMathOperator> _registredMathOperators;
        private int _registryContainerVersion;
        private readonly Dictionary<string, IMathOperator> _mathOperators;

        internal Calculator(ICoreIOCInstanceProvider<IMathOperator> registredMathOperators)
        {
            if (registredMathOperators == null) throw new ArgumentNullException(nameof(registredMathOperators));

            this._registredMathOperators = registredMathOperators;

            unchecked
            {
                this._registryContainerVersion = registredMathOperators.ContainerVersion - 1;
            }

            this._mathOperators = new Dictionary<string, IMathOperator>();
        }

        /// <inheritdoc />
        public string GetOperatorName(string @operator)
        {
            this.SyncMathOperators();

            return this._mathOperators[@operator].Name;
        }

        public double Calculate(string @operator, double value1, double value2)
        {
            this.SyncMathOperators();

            var mathOperator = this._mathOperators[@operator];
            return mathOperator.Calculate(value1, value2);
        }

        private void SyncMathOperators()
        {
            var currentContainerVersion = this._registredMathOperators.ContainerVersion;
            if (this._registryContainerVersion == currentContainerVersion) return;

            this._mathOperators.Clear();

            var mathOperators = this._registredMathOperators.GetMap().Select(this._registredMathOperators.GetInstance);
            foreach (var mathOperator in mathOperators)
            {
                this._mathOperators.Add(mathOperator.Operator, mathOperator);
            }

            this._registryContainerVersion = currentContainerVersion;
        }
    }
}