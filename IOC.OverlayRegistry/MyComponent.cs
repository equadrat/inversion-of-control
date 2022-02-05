namespace IOC.OverlayRegistry
{
    internal class MyComponent: IMyComponent
    {
        /// <inheritdoc />
        public string Message {get;}

        internal MyComponent(string message)
        {
            this.Message = message;
        }
    }
}