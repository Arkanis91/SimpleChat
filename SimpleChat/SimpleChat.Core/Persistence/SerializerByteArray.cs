using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SimpleChat.Core.Persistence
{
    public class SerializerByteArray<T> : ISerializer<T, byte[]> where T : class
    {
        public T Deserialize(byte[] data)
        {
            var formatter = new BinaryFormatter();
            var ms = new MemoryStream(data);
            return (T)formatter.Deserialize(ms);
        }

        public byte[] Serialize(T obj)
        {
            var streamMemory = new MemoryStream();
            var formatter = new BinaryFormatter();
            formatter.Serialize(streamMemory, obj);
            return streamMemory.GetBuffer();
        }
    }
}
