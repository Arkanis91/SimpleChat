using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SimpleChat.Core.Persistence
{
    /// <summary>
    /// serializes to xml format
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class FileSerializerXml<T> : IFileSerializer<T> where T : class
    {
        /// <summary>
        /// empty constructor
        /// </summary>
        public FileSerializerXml()
        {

        }

        /// <inheritdoc/>
        public T Deserialize(string filepath)
        {
            T serialized = null;

            using (Stream stream = File.Open(filepath, FileMode.OpenOrCreate))
            {
                if (stream.Length != 0)
                {
                    var serializer = new XmlSerializer(typeof(T));
                    serialized = (T)serializer.Deserialize(stream);
                }
            }

            return serialized;
        }

        /// <inheritdoc/>
        public void Serialize(T obj, string filepath)
        {
            var directoryInfo = new FileInfo(filepath).Directory;
            if (directoryInfo != null && !directoryInfo.Exists)
                directoryInfo.Create();

            using (Stream stream = File.Open(filepath, FileMode.Create))
            {
                var serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(stream, obj);
            }
        }
    }
}
