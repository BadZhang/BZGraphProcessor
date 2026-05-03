namespace BZGraphProcessor.Shared
{
    public interface IEvent<T>
    {
        void Invoke(in T arg);
    }
}