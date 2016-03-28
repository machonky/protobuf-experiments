using Google.Protobuf;

namespace ProtocolBufferExperiments
{
    public class IMessageFactory
    {
        public static IMessage Create<T>(ByteString bytes) where T: IMessage
        {
            var msg = (IMessage) System.Activator.CreateInstance<T>();
            msg.MergeFrom(bytes);
            return msg;
        }
    }
}