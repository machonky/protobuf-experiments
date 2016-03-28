namespace ProtocolBufferExperiments
{
    public interface IHandleCommand<in T> where T:ICommand
    {
        void Handle(T cmd);
    }
}
