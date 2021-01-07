//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    partial class XTend
    {
        /// <summary>
        /// Creates a hashtable from a dictionary
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="K">The key type</typeparam>
        /// <typeparam name="V">The value type</typeparam>
        public static KeyValuePairs<K,V> ToKVPairs<K,V>(this Dictionary<K,V> src)
            => new KeyValuePairs<K,V>(src);

        public static Dictionary<V, K[]> Flip<K,V>(this IReadOnlyDictionary<K,V> data)
            => (from kvp in data.GroupBy(kvp => kvp.Value)
                 let v = kvp.Key
                 let k = kvp.Map(x => x.Key)
                 select (v,k)).ToDictionary();
    }
}