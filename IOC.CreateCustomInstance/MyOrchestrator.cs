namespace IOC.CreateCustomInstance
{
    internal class MyOrchestrator
    {
        private readonly IMyComponent _myComponent;

        internal MyOrchestrator(IMyComponent myComponent)
        {
            if (myComponent == null) throw new ArgumentNullException(nameof(myComponent));
            this._myComponent = myComponent;
        }

        public string? Concatenate(params string[] values)
        {
            var numberOfValues = values.Length;
            if (numberOfValues == 0) return null;

            var result = values[0];

            for (var i = 1; i < numberOfValues; i++)
            {
                result = this._myComponent.Concatenate(result, values[i]);
            }

            return result;
        }
    }
}