//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Collections.Generic;

    using static Part;

    [ApiHost(ApiNames.Lookups)]
    public partial struct Lookups
    {
        const NumericKind Closure = UnsignedInts;

    }

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
    }
}