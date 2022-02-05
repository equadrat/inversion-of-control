using e2.Framework.Attributes;
using JetBrains.Annotations;

namespace IOC.InstancePerCall.DI
{
    internal class MyModel: IMyModel
    {
        [CoreIOCDependency]
        [UsedImplicitly]
        public long ModelId {get; private set;}

        [CoreIOCDependency]
        [UsedImplicitly]
        public string? Name {get; private set;}
    }
}