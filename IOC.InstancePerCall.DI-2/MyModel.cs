using e2.Framework.Attributes;

namespace IOC.InstancePerCall.DI
{
    internal class MyModel: IMyModel
    {
        public long ModelId {get;}
        public string? Name {get;}

        public MyModel([CoreIOCDependency(nameof(ModelId))] long modelId, [CoreIOCDependency(nameof(Name))] string? name)
        {
            this.ModelId = modelId;
            this.Name = name;
        }
    }
}