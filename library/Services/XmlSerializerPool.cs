using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PostSpamer.library.Services
{
    class XmlSerializerPool
    {
        private static readonly ConcurrentDictionary<Type, XmlSerializer> _SerializersPool = new ConcurrentDictionary<Type, XmlSerializer>();

        public static XmlSerializer GetSerializer<T>() => GetSerializer(typeof(T));

        public static XmlSerializer GetSerializer(Type ObjectType) => _SerializersPool.GetOrAdd(ObjectType, type => new XmlSerializer(type));
        
    }
}
