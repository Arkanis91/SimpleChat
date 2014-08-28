using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleChat.Core.Persistence
{
    /// <summary>
    /// interface for local persistent classes
    /// </summary>
    /// <typeparam name="TIn"></typeparam>
    /// <typeparam name="TOut"></typeparam>
    public interface ISerializer<TIn, TOut>
     where TIn : class
    {
        /// <summary>
        /// deserializes T from filepath
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        TIn Deserialize(TOut data);

        /// <summary>
        /// serializes T obj to filepath
        /// </summary>
        /// <param name="obj"></param>
        TOut Serialize(TIn obj);
    }
}
