namespace IOC.InstancePerCall.DI
{
    internal class MyModel: IMyModel
    {
        public long ModelId {get;}
        public string? Name {get;}

        public MyModel(long modelId, string? name)
        {
            this.ModelId = modelId;
            this.Name = name;
        }
    }
}