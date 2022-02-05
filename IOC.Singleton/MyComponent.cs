namespace IOC.Singleton
{
    internal class MyComponent : IMyComponent
    {
        public string Concatenate(string value1, string value2)
        {
            return string.Concat(value1, value2);
        }
    }
}
