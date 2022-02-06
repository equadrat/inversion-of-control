namespace IOC.Route
{
    internal class MyComponent: IMyComponent1,
                                IMyComponent2
    {
        public string Concatenate(string value1, string value2)
        {
            return string.Concat(value1, value2);
        }

        public string Join(string value1, string value2)
        {
            return this.Concatenate(value1, value2);
        }
    }
}