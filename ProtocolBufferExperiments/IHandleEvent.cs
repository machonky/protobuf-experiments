namespace ProtocolBufferExperiments
{
    public interface IHandleEvent<in T> where T : IEvent
    {
        void Handle(T cmd);
    }
}