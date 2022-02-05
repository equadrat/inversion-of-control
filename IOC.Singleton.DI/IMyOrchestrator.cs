namespace IOC.Singleton.DI
{
    public interface IMyOrchestrator
    {
        string? Concatenate(params string[] values);
    }
}